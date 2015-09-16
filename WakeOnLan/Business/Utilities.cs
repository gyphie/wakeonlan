using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WakeOnLan.Business
{
	public static class Utilities
	{
		public static bool IsValidateMediaAccessControl(string mac)
		{
			return false;
		}
		public static bool IsValidateHostName(string hostName)
		{
			return false;
		}
		public static bool IsValidIpAddress(string ipAddress)
		{
			return false;
		}
		public static bool IsValidPort(UInt16 port)
		{
			return port > 0 && port < UInt16.MaxValue;
		}

		public static string FormatMediaAccessControl(string mac)
		{
			if (!IsValidateMediaAccessControl(mac)) return mac;
			mac = mac ?? "";
			mac = mac.ToUpper().Replace(":", "").Replace("-", "").Replace(" ", "");
			return string.Format("{0}:{1}:{2}:{3}:{4}:{5}", mac.Substring(0,2),mac.Substring(2,2),mac.Substring(4,2),mac.Substring(6,2),mac.Substring(8,2),mac.Substring(10,2));
		}

		public static string FormatIpAddress(string ipAddress)
		{
			return "";
		}
	}
}
