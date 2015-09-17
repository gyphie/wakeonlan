using System;
using System.Collections.Generic;
using System.IO;
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
				byte[] payload = new byte[102];
				Buffer.BlockCopy(sync, 0, payload, 0, sync.Length);

				int offset = sync.Length;
				var mac = entry.GetMacBytes();
				for (int i = 0; i < 16; i += 1)
				{
					Buffer.BlockCopy(mac, 0, payload, i * mac.Length + offset, mac.Length);
				}

				if (entry.UsePingPacket)
				{
					using (var ping = new Ping())
					{
						ping.Send(entry.HostOrIP, 5, payload);
						return Results.Sent;
					}

				}
				else
				{
					using (var client = new UdpClient())
					{
						client.Send(payload, payload.Length, entry.HostOrIP, entry.PortNumber);
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
