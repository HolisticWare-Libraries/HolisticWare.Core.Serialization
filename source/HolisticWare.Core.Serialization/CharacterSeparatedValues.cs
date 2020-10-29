using System;
using System.Threading.Tasks;

using CsvHelper;
using CsvHelper.Configuration;

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

            System.IO.StringWriter text_writer = new System.IO.StringWriter(csv);
            CsvConfiguration csv_configuration = new CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture);

            using CsvWriter csvWriter = new CsvWriter(text_writer, csv_configuration);

            // automatically map the properties of T
            csvWriter.Configuration.AutoMap<T>();

            // we want to have a header row (optional)
            csvWriter.WriteHeader<T>();
            csvWriter.NextRecord();

            // write our record
            csvWriter.WriteRecord(t);

            // make sure all records are flushed to stream
            csvWriter.Flush();

            return csv.ToString();
        }

        public Task<string> SerializeAsync<T>(T t)
        {
            throw new NotImplementedException();
        }
    }
}
