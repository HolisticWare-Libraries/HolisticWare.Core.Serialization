using System;
using System.Threading.Tasks;

namespace Core.Serialization.JSON.System.Xml.Serialization
{
    public class XML : ISerializer
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
            // if you can, only create one serializer
            // creating serializers is an expensive
            // operation and can be slow
            System.Xml.Serialization.XmlSerializer serializer = null;

            serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));

            // we will write the our result to memory
            await using global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            // the string will be utf8 encoded
            await using global::System.IO.StreamWriter writer = new global::System.IO.StreamWriter(stream, Encoding.UTF8);

            // here we go!
            serializer.Serialize(writer, t);

            // flush our write to make sure its all there
            await writer.FlushAsync();

            // reset the stream back to 0
            stream.Position = 0;

            using global::System.IO.StreamReader reader = new global::System.IO.StreamReader(stream);

            string xml = await reader.ReadToEndAsync();

            return xml;
        }
    }
}
