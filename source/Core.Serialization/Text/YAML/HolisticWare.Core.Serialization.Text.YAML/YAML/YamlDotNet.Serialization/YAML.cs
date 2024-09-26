using System;
using System.Threading.Tasks;

namespace Core.Serialization.YAML.YamlDotNet.Serialization
{
    public class YAML : ISerializerMarshaller
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
            global::YamlDotNet.Serialization.Serializer serializer = null;

            serializer = new global::YamlDotNet.Serialization.Serializer();
            var yaml = new System.Text.StringBuilder();

            //await using
            global::System.IO.StringWriter textWriter = new global::System.IO.StringWriter(yaml);

            serializer.Serialize(textWriter, t, typeof(T));

            return yaml.ToString();
        }

        public async Task<string> SerializeMarshallAsync<T>(T t)
        {
            global::YamlDotNet.Serialization.Serializer serializer = null;

            serializer = new global::YamlDotNet.Serialization.Serializer();
            var yaml = new System.Text.StringBuilder();

            //await using
            global::System.IO.StringWriter textWriter = new global::System.IO.StringWriter(yaml);

            serializer.Serialize(textWriter, t, typeof(T));

            return yaml.ToString();
        }
    }
}
