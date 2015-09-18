using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace WakeOnLan.Business
{
	public static class WOL
	{
		private static byte[] sync = new byte[6] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };

		public static WOL.Results Wake(Entry entry)
		{
			try
			{
				var hasPassword = !string.IsNullOrEmpty(entry.Password) && entry.Password.Length == 12;
				var payloadLength = hasPassword ? 114 : 102;

				byte[] payload = new byte[payloadLength];
				Buffer.BlockCopy(sync, 0, payload, 0, sync.Length);

				int offset = sync.Length;
				var mac = entry.GetMacBytes();
				for (int i = 0; i < 16; i += 1)
				{
					Buffer.BlockCopy(mac, 0, payload, i * mac.Length + offset, mac.Length);
				}

				if (hasPassword)
				{
					Buffer.BlockCopy(Utilities.HexStringToBytes(entry.Password), 0, payload, 102, 0);
				}


				var host = entry.UseBroadcast ? IPAddress.Broadcast.ToString() : entry.HostOrIP;
				if (entry.UsePingPacket)
				{
					using (var ping = new Ping())
					{
						ping.Send(host, 5, payload);
						return Results.Sent;
					}
				}
				else
				{
					using (var client = new UdpClient())
					{
						client.Send(payload, payload.Length, host, entry.PortNumber);
						return Results.Sent;
					}
				}
			}
			catch
			{
				return Results.Error;
			}
		}

		public enum Results
		{
			Unknown,
			Sent,
			Error
		}
	}
}
