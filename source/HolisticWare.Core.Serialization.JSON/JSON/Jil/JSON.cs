using System;
using System.Threading.Tasks;

namespace Core.Serialization.JSON.Jil
{
    /// <summary>
    /// 
    /// </summary>
    /// https://github.com/kevin-montrose/Jil
    public class JSON : IStorageTransmission
    {
        public T DeserializeUnmarshall<T>(string text)
        {
            T t = default(T);

            using (global::System.IO.StringReader input = new global::System.IO.StringReader(text))
            {
                t = global::Jil.JSON.Deserialize<T>(input);
            }

            return t;
        }

        public Task<T> DeserializeUnmarshallAsync<T>(string text)
        {
            throw new NotImplementedException();
        }

        public string SerializeMarshall<T>(T t)
        {
            string json = null;

            using (global::System.IO.StringWriter output = new global::System.IO.StringWriter())
            {
                global::Jil.JSON.Serialize(t, output);
                json = output.ToString();
            }

            return json;
        }

        public async Task<string> SerializeMarshallAsync<T>(T t)
        {
            throw new NotImplementedException();
        }
    }
}
