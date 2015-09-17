using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WakeOnLan.Business
{
	public static class Persistence
	{
		private static string GetFilePath()
		{
			return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "org.itsourfamily.wol", "data.json");
		}

		public static bool LoadData(out Entry defaults, out List<Entry> entries)
		{
			defaults = null;
			entries = null;

			var dataFileName = Persistence.GetFilePath();
			if (!File.Exists(dataFileName))
			{
				return false;
			}

			var dataFileContent = File.ReadAllText(dataFileName, Encoding.UTF8);
			JObject jsonObj = JObject.Parse(dataFileContent);

			defaults = new Entry();
			defaults.PortNumber = jsonObj["default"]["PortNumber"].Value<UInt16>();
			defaults.UsePingPacket = jsonObj["default"]["UsePingPacket"].Value<bool>();
			defaults.UseBroadcast = jsonObj["default"]["UseBroadcast"].Value<bool>();

			entries = new List<Entry>();

			foreach (var jsEntry in jsonObj["entries"])
			{
				var entry = new Entry();
				entry.Name = jsEntry["Name"].Value<string>();
				entry.HostOrIP = jsEntry["HostOrIP"].Value<string>();
				entry.PortNumber = jsEntry["PortNumber"].Value<UInt16>();
				entry.MediaAccessControl = jsEntry["MediaAccessControl"].Value<string>();
				entry.UsePingPacket = jsEntry["UsePingPacket"].Value<bool>();
				entry.UseBroadcast = jsEntry["UseBroadcast"].Value<bool>();
				entry.Password = jsEntry["Password"].Value<string>();

				entries.Add(entry);
			}

			return true;
		}

		public static void SaveData(Entry defaults, List<Entry> entries)
		{
			var saveObj = new
			{
				@default = defaults,
				entries = entries
			};

			string fileName = Persistence.GetFilePath();
			
			JsonSerializer serializer = new JsonSerializer();
			serializer.Converters.Add(new JavaScriptDateTimeConverter());
			serializer.NullValueHandling = NullValueHandling.Include;

			Directory.CreateDirectory(Path.GetDirectoryName(fileName));

			using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
			{
				using (JsonWriter writer = new JsonTextWriter(sw))
				{
					serializer.Serialize(writer, saveObj);
				}
			}
		}
	}
}
