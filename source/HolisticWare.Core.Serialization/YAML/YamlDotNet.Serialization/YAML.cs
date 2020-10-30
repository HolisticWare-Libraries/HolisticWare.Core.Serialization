using System;
using System.Threading.Tasks;

namespace Core.Serialization.YAML.YamlDotNet.Serialization
{
    public class YAML : ISerializer
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
        }

        public async Task<string> SerializeAsync<T>(T t)
        {
            global::YamlDotNet.Serialization.Serializer serializer = null;

            serializer = new global::YamlDotNet.Serialization.Serializer();
            var yaml = new System.Text.StringBuilder();

            await using System.IO.StringWriter textWriter = new System.IO.StringWriter(yaml);

            serializer.Serialize(textWriter, t, typeof(T));

            return yaml.ToString();
        }
    }
}
