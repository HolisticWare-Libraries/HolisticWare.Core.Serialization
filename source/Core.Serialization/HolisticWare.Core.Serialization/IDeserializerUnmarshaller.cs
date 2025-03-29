using System.Threading.Tasks;

namespace Core.Serialization
{
    /// <summary>
    /// 
    /// </summary>
    /// https://en.wikipedia.org/wiki/Marshalling_(computer_science)
    public interface IDeserializerUnmarshaller
    {
        public 
            T
                                        DeserializeUnmarshall<T>
                                        (
                                            string text
                                        )
                                        where T : new()
                                        ;

        //public Task<T>        DeserializeAsync<T>(string text);
    }
}