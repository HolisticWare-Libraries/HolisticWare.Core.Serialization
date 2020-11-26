using System;
using System.Threading.Tasks;

namespace Core.Serialization.JSON.Newtonsoft.Json
{
    /// <summary>
    /// 
    /// </summary>
    /// https://www.newtonsoft.com/json/help/html/SerializingJSON.htm
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
            string json = global::Newtonsoft.Json.JsonConvert.SerializeObject(t);

            return json;
        }

        public async Task<string> SerializeAsync<T>(T t)
        {
            return null;
        }
    }
}
