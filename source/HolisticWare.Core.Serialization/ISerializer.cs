using System.Threading.Tasks;

namespace Core.Serialization
{
    public interface ISerializer
    {
        public string   Serialize<T>(T t);
        public T        Deserialize<T>(string text);

        //public Task<string>   SerializeAsync<T>(T t);
        //public Task<T>        DeserializeAsync<T>(string text);
    }
}