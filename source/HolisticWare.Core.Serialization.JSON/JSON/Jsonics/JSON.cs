using System;
using System.Threading.Tasks;

namespace Core.Serialization.JSON.Jsonics
{
    /// <summary>
    /// 
    /// </summary>
    /// https://github.com/trampster/Jsonics
    public class JSON : IStorageTransmission
    {
        public T DeserializeUnmarshall<T>(string text)
        {
            //create an optimized Json converter for type
            global::Jsonics.IJsonConverter<T> json_converter = global::Jsonics.JsonFactory.Compile<T>();

            return json_converter.FromJson(text);
        }

        public Task<T> DeserializeUnmarshallAsync<T>(string text)
        {
            throw new NotImplementedException();
        }

        public string SerializeMarshall<T>(T t)
        {
            //create an optimized Json converter for type
            global::Jsonics.IJsonConverter<T> json_converter = global::Jsonics.JsonFactory.Compile<T>();

            return json_converter.ToJson(t);
        }

        public async Task<string> SerializeMarshallAsync<T>(T t)
        {
            throw new NotImplementedException();
        }
    }
}
