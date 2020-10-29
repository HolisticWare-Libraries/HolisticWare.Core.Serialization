using System;
using System.Threading.Tasks;

namespace Core.Serialization
{
    public class CharacterSeparatedValues : ISerializer
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
            System.Text.StringBuilder csv = new System.Text.StringBuilder();

            System.IO.StringWriter textWriter = new System.IO.StringWriter(csv);
            using var csvWriter = new CsvWriter(textWriter);

            // automatically map the properties of T
            csvWriter.Configuration.AutoMap<T>();

            // we want to have a header row (optional)
            csvWriter.WriteHeader<T>();
            await csvWriter.NextRecordAsync();

            // write our record
            csvWriter.WriteRecord(input);

            // make sure all records are flushed to stream
            await csvWriter.FlushAsync();

            return csv.ToString();
        }

        public Task<string> SerializeAsync<T>(T t)
        {
            throw new NotImplementedException();
        }
    }
}