using System;
using System.Threading.Tasks;

namespace Core.Serialization.JSON.System.Text.Json.Simple
{
    public class JSON : IStorageTransmission
    {
        public T DeserializeUnmarshall<T>(string text)
        {
            global::System.Text.Json.JsonSerializerOptions options = null;
            options = new global::System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true
            };
            T t = global::System.Text.Json.JsonSerializer.Deserialize<T>(text, options);

            return t;
        }

        public async Task<T> DeserializeUnmarshallAsync<T>(string text)
        {
            global::System.Text.Json.JsonSerializerOptions options = null;
            options = new global::System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true
            };

            T t = default(T);
            using
                (
                    global::System.IO.MemoryStream ms
                                = new global::System.IO.MemoryStream
                                                        (
                                                            global::System.Text.Encoding.UTF8.GetBytes(text)
                                                        )
                )
            {
                t = await global::System.Text.Json.JsonSerializer.DeserializeAsync<T>(ms, options);
            }

            return t;
        }

        public string SerializeMarshall<T>(T t)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(t);
        }

        public async Task<string> SerializeMarshallAsync<T>(T t)
        {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            await global::System.Text.Json.JsonSerializer.SerializeAsync(stream, t);

            // reset the stream back to 0
            stream.Position = 0;

            using global::System.IO.StreamReader reader = new global::System.IO.StreamReader(stream);

            // we reread the stream to a string
            string json = await reader.ReadToEndAsync();

            return json;
        }
    }
}
