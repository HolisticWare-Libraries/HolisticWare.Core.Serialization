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
            YamlDotNet.Serialization.Serializer serializer = new global::YamlDotNet.Serialization.Serializer();
            System.Text.StringBuilder yaml = new System.Text.StringBuilder();

            //await using
            System.IO.StringWriter textWriter = new System.IO.StringWriter(yaml);

            serializer.Serialize(textWriter, t, typeof(T));

            return yaml.ToString();
        }
    }
}
