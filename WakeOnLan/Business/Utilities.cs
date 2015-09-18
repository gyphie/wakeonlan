using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace WakeOnLan.Business
{
	public static class Utilities
	{
		public static bool IsValidateMediaAccessControl(string value)
		{
			if (string.IsNullOrWhiteSpace(value)) return false;
			return Regex.IsMatch(value, @"^[0-9A-F]{2}([ :-]?)[0-9A-F]{2}\1[0-9A-F]{2}\1[0-9A-F]{2}\1[0-9A-F]{2}\1[0-9A-F]{2}$", RegexOptions.IgnoreCase);
		}
		public static bool IsValidateHostName(string value)
		{
			if (string.IsNullOrWhiteSpace(value)) return false;
			return Uri.CheckHostName(value) != UriHostNameType.Unknown;
		}
		public static bool IsValidIpAddress(string value)
		{
			if (string.IsNullOrWhiteSpace(value)) return false;
			IPAddress dummy;
			return IPAddress.TryParse(value, out dummy);
		}
		public static bool IsValidPort(string value)
		{
			if (string.IsNullOrWhiteSpace(value)) return false;
			UInt16 dummy;
			return UInt16.TryParse(value, out dummy);
		}

		public static string FormatMediaAccessControl(string mac, string separator)
		{
			if (!IsValidateMediaAccessControl(mac)) return mac;
			mac = mac ?? "";
			mac = mac.ToUpper().Replace(":", "").Replace("-", "").Replace(" ", "");
			return string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}", separator, mac.Substring(0,2),mac.Substring(2,2),mac.Substring(4,2),mac.Substring(6,2),mac.Substring(8,2),mac.Substring(10,2));
		}

		public static bool IsValidSecureOnPassword(string value)
		{
			if (string.IsNullOrWhiteSpace(value)) return true;
			return Regex.IsMatch(value, @"^[0-9A-F]{12}$", RegexOptions.IgnoreCase);
		}

		public static string FormatIpAddress(string ipAddress)
		{
			if (!IsValidIpAddress(ipAddress)) return ipAddress;
			return IPAddress.Parse(ipAddress).ToString(); ;
		}

		public static UInt16 ParsePort(string port)
		{
			if (!IsValidPort(port)) throw new ArgumentOutOfRangeException("port", "Part is not a valid 16 bit value");
			return UInt16.Parse(port);
		}

		public static byte[] HexStringToBytes(string p)
		{
			byte[] bytes = new byte[6];
			for (int i = 0; i < p.Length; i += 2) {
				bytes[i/2] = (byte)Convert.ToUInt16(p.Substring(i, 2), 16);
			}

			return bytes;
		}
	}
}
