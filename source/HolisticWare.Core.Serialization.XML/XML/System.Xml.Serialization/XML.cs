using System;
using System.Threading.Tasks;

namespace Core.Serialization.XML.System.Xml.Serialization
{
    /// <summary>
    /// 
    /// </summary>
    /// https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer?view=netframework-4.7.2
    public class XML : ISerializer
    {
        public T Deserialize<T>(string text)
        {
            global::System.Xml.Serialization.XmlSerializer serializer = null;
            serializer = new global::System.Xml.Serialization.XmlSerializer(typeof(T));

            T result = default(T);

            using (global::System.IO.TextReader r = new global::System.IO.StringReader(text))
            {
                result = (T)serializer.Deserialize(r);
            }

            return result;
        }

        public async Task<T> DeserializeAsync<T>(string text)
        {
            return await Task.Run
                (
                    () =>
                    {
                        return Deserialize<T>(text);
                    }
                );
        }

        public string Serialize<T>(T t)
        {
            // if you can, only create one serializer
            // creating serializers is an expensive
            // operation and can be slow
            global::System.Xml.Serialization.XmlSerializer serializer = null;

            serializer = new global::System.Xml.Serialization.XmlSerializer(typeof(T));

            // we will write the our result to memory
            //await using
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            // the string will be utf8 encoded
            //await using
            global::System.IO.StreamWriter writer = new global::System.IO.StreamWriter
                                                                                (
                                                                                    stream,
                                                                                    global::System.Text.Encoding.UTF8
                                                                                );

            // here we go!
            serializer.Serialize(writer, t);

            // flush our write to make sure its all there
            writer.Flush();

            // reset the stream back to 0
            stream.Position = 0;

            using global::System.IO.StreamReader reader = new global::System.IO.StreamReader(stream);

            string xml = reader.ReadToEnd();

            return xml;
        }

        public async Task<string> SerializeAsync<T>(T t)
        {
            // if you can, only create one serializer
            // creating serializers is an expensive
            // operation and can be slow
            global::System.Xml.Serialization.XmlSerializer serializer = null;

            serializer = new global::System.Xml.Serialization.XmlSerializer(typeof(T));

            // we will write the our result to memory
            //await using
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            // the string will be utf8 encoded
            //await using
            global::System.IO.StreamWriter writer = new global::System.IO.StreamWriter
                                                                                (
                                                                                    stream,
                                                                                    global::System.Text.Encoding.UTF8
                                                                                );

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
