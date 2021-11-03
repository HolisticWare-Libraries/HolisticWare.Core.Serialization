using System;
using System.Threading.Tasks;

namespace Core.Serialization.TOML.Nett
{
    public class TOML : ISerializerMarshaller
    {
        public T Deserialize<T>(string text)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeserializeAsync<T>(string text)
        {
            throw new NotImplementedException();
        }

        public string SerializeMarshall<T>(T t)
        {
            return null;
        }

        public async Task<string> SerializeMarshallAsync<T>(T t)
        {
            throw new NotImplementedException();
        }
    }
}
