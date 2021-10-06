using System;
using System.Threading.Tasks;

namespace Core.Serialization.JSON.System.Text.Json.Simple
{
    public class JSON : ISerializer
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
            string json = global::System.Text.Json.JsonSerializer.Serialize(t);

            return json;
        }

        public async Task<string> SerializeAsync<T>(T t)
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
