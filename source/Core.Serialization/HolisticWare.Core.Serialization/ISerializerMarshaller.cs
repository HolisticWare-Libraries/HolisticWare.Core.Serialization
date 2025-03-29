using System.Threading.Tasks;

namespace Core.Serialization;

/// <summary>
/// 
/// </summary>
/// https://en.wikipedia.org/wiki/Marshalling_(computer_science)
public interface 
                                        ISerializerMarshaller
{
    public 
        string
                                        SerializeMarshall<T>
                                        (
                                            T t
                                        );

    //public Task<string>   SerializeAsync<T>(T t);
}
