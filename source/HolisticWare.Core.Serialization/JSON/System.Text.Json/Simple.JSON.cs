using System;
using System.Threading.Tasks;

namespace Core.Serialization.JSON.System.Text.Json
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
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            JsonSerializer.Serialize(stream, t);

            // reset the stream back to 0
            stream.Position = 0;

            using var reader = new StreamReader(stream);

            // we reread the stream to a string
            var json = await reader.ReadToEndAsync();
        }

        public Task<string> SerializeAsync<T>(T t)
        {
            throw new NotImplementedException();
        }
    }
}