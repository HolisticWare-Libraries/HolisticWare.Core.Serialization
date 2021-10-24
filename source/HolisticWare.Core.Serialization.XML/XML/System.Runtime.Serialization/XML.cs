using System;
using System.Threading.Tasks;

namespace Core.Serialization.XML.System.Runtime.Serialization
{
    /// <summary>
    /// 
    /// </summary>
    /// https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.datacontractserializer?view=netframework-4.7.2
    public class XML : ISerializer
    {
        public T Deserialize<T>(string text)
        {
            T result = default(T);

            using (global::System.IO.StringReader r = new global::System.IO.StringReader(text))
            {
                using (global::System.Xml.XmlReader r_xml = global::System.Xml.XmlReader.Create(r))
                {
                    global::System.Runtime.Serialization.DataContractSerializer serializer = null;
                    serializer = new global::System.Runtime.Serialization.DataContractSerializer(typeof(T));
                    result = (T)serializer.ReadObject(r_xml);
                }
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
            string result = null;

            using (global::System.IO.MemoryStream ms = new global::System.IO.MemoryStream())
            {
                global::System.Runtime.Serialization.DataContractSerializer serializer = null;
                serializer = new global::System.Runtime.Serialization.DataContractSerializer(typeof(T));

                serializer.WriteObject(ms, t);

                ms.Seek(0, global::System.IO.SeekOrigin.Begin);

                using (global::System.IO.StreamReader sr = new global::System.IO.StreamReader(ms))
                {
                    result = sr.ReadToEnd();
                }
            }

            return result;
        }

        public async Task<string> SerializeAsync<T>(T t)
        {
            string result = null;

            using (global::System.IO.MemoryStream ms = new global::System.IO.MemoryStream())
            {
                global::System.Runtime.Serialization.DataContractSerializer serializer = null;
                serializer = new global::System.Runtime.Serialization.DataContractSerializer(typeof(T));

                serializer.WriteObject(ms, t);

                ms.Seek(0, global::System.IO.SeekOrigin.Begin);

                using (global::System.IO.StreamReader sr = new global::System.IO.StreamReader(ms))
                {
                    result = await sr.ReadToEndAsync();
                }
            }

            return result;
        }
    }
}
