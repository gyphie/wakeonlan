using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WakeOnLan.Business
{
	public class Entry
	{
		public Entry()
		{

		}

		public string Name { get; set; }
		public string HostOrIP { get; set; }
		public string MediaAccessControl { get; set; }
		public UInt16 PortNumber { get; set; }

		public bool UsePingPacket { get; set; }
		public bool UseBroadcast { get; set; }
	}
}
