using System;
using System.Threading.Tasks;

namespace Core.Serialization.JSON.fastJSON
{
    /// <summary>
    /// 
    /// </summary>
    /// https://github.com/mgholam/fastJSON
    /// https://www.codeproject.com/Articles/159450/fastJSON-Smallest-Fastest-Polymorphic-JSON-Seriali
    public class JSON : IStorageTransmission
    {
        public T DeserializeUnmarshall<T>(string text)
        {
            return global::fastJSON.JSON.ToObject<T>(text);
        }

        public Task<T> DeserializeUnmarshallAsync<T>(string text)
        {
            throw new NotImplementedException();
        }

        public string SerializeMarshall<T>(T t)
        {
            return global::fastJSON.JSON.ToJSON(t);
        }

        public async Task<string> SerializeMarshallAsync<T>(T t)
        {
            throw new NotImplementedException();
        }
    }
}
