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
        }

        public async Task<string> SerializeAsync<T>(T t)
        {
            var serializer = new global::YamlDotNet.Serialization.Serializer();
            var yaml = new StringBuilder();

            await using var textWriter = new StringWriter(yaml);

            serializer.Serialize(textWriter, input, typeof(T));

            Console.WriteLine(yaml.ToString());
        }
    }
}
