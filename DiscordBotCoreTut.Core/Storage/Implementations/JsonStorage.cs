using System.IO;
using static System.IO.Directory;
using Newtonsoft.Json;

namespace DiscordBotCoreTut.Storage.Implementations
{
    public class JsonStorage : IDataStorage
    {
        public void StoreObject(object obj, string key)
        {
            var file = $"{key}.json";
            var path = Path.GetDirectoryName(file);
            CreateDirectory(path);
            var json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(file, json);
        }

        public T RestoreObject<T>(string key)
        {
            var json = File.ReadAllText($"{key}.json");
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}