using System;
using System.Threading.Tasks;

namespace Core.Serialization.JSON.System.Text.Json.Simple
{
    public class JSON : ISerializer
    {
        public T Deserialize<T>(string text)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeserializeAsync<T>(string text)
        {
            throw new NotImplementedException();
        }

        public string Serialize<T>(T t)
        {
            string json = JsonSerializer.Serialize(t);

            return json;
        }

        public Task<string> SerializeAsync<T>(T t)
        {
            throw new NotImplementedException();
        }
    }
}