using System;
using System.Threading.Tasks;

namespace Core.Serialization.TOML.Nett
{
    public class TOML : ISerializer
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
            return null;
        }

        public async Task<string> SerializeAsync<T>(T t)
        {
            throw new NotImplementedException();
        }
    }
}
