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

		public static bool LoadData(ref Entry defaults, out List<Entry> entries)
		{
			entries = null;

			var dataFileName = Persistence.GetFilePath();
			if (!File.Exists(dataFileName))
			{
				return false;
			}

			var dataFileContent = File.ReadAllText(dataFileName, Encoding.UTF8);
			JObject jsonObj = JObject.Parse(dataFileContent);

			defaults = defaults ?? new Entry();
			try
			{
				JObject defJson = jsonObj.Value<JObject>("default");

				if (defJson != null)
				{
					var portNumber = defJson.Value<UInt16>("PortNumber");
					defaults.PortNumber = portNumber <= 0 ? defaults.PortNumber : portNumber;
					defaults.UsePingPacket = defJson.Value<bool>("UsePingPacket");
					defaults.UseBroadcast = defJson.Value<bool>("UseBroadcast");

					var maxNumberOfSends = defJson.Value<UInt16>("MaxNumberOfSends");
					defaults.MaxNumberOfSends = maxNumberOfSends <= 0 ? defaults.MaxNumberOfSends : maxNumberOfSends;

					var numberOfSends = defJson.Value<UInt16>("NumberOfSends"); ;
					defaults.NumberOfSends = numberOfSends <= 0 ? defaults.NumberOfSends : numberOfSends;

					var delayBetweenSends = defJson.Value<UInt16>("DelayBetweenSends");
					defaults.DelayBetweenSends = delayBetweenSends <= 0 ? defaults.DelayBetweenSends : delayBetweenSends;
				}
			}
			catch { }	// Ignore settings load errors

			entries = new List<Entry>();

			foreach (var jsEntry in jsonObj["entries"])
			{
				try
				{
					var entry = new Entry();
					entry.Name = jsEntry.Value<string>("Name");
					entry.HostOrIP = jsEntry.Value<string>("HostOrIP");
					entry.PortNumber = jsEntry.Value<UInt16>("PortNumber");
					entry.MediaAccessControl = jsEntry.Value<string>("MediaAccessControl");
					entry.UsePingPacket = jsEntry.Value<bool>("UsePingPacket");
					entry.UseBroadcast = jsEntry.Value<bool>("UseBroadcast");
					entry.Password = jsEntry.Value<string>("Password");
					entry.NumberOfSends = defaults.NumberOfSends;
					entry.MaxNumberOfSends = defaults.MaxNumberOfSends;
					entry.DelayBetweenSends = defaults.DelayBetweenSends;

					entries.Add(entry);
				}
				catch { } // Ignore settings load errors
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
