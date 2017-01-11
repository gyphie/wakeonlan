using System;

namespace WakeOnLan.Business
{
	public class Entry
	{
		public Entry() { }

		public string Name { get; set; }
		public string HostOrIP { get; set; }
		public string MediaAccessControl { get; set; }
		public UInt16 PortNumber { get; set; }

		public bool UsePingPacket { get; set; }
		public bool UseBroadcast { get; set; }

		public string Password { get; set; }

		public string FormattedMac(string separator)
		{
			return Utilities.FormatMediaAccessControl(this.MediaAccessControl, separator);
		}
		public byte[] GetMacBytes()
		{
			return Utilities.HexStringToBytes(this.MediaAccessControl);
		}

		public UInt16 MaxNumberOfSends { get; set; }
		public UInt16 DelayBetweenSends { get; set; }
		public UInt16 NumberOfSends { get; set; }
	}
}
