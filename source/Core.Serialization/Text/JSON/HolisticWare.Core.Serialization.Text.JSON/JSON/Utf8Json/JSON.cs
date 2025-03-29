using System;
using System.Threading.Tasks;

namespace Core.Serialization.JSON.Utf8Json
{
    /// <summary>
    /// 
    /// </summary>
    /// https://github.com/neuecc/Utf8Json
    /// 
    public class JSON : IStorageTransmission
    {
        public T DeserializeUnmarshall<T>(string text)
        {
            return global::Utf8Json.JsonSerializer.Deserialize<T>(text);
            ;
        }

        public Task<T> DeserializeUnmarshallAsync<T>(string text)
        {
            throw new NotImplementedException();
        }

        public string SerializeMarshall<T>(T t)
        {
            return global::Utf8Json.JsonSerializer.ToJsonString<T>(t);
        }

        public async Task<string> SerializeMarshallAsync<T>(T t)
        {
            throw new NotImplementedException();
        }
    }
}
