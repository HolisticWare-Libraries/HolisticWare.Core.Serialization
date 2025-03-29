using MessagePack;
using MessagePack.Resolvers;

namespace HolisticWare.MessagePack;


public static class CustomMessagePackSerializer
{
    private static readonly 
        MessagePackSerializerOptions 
                                        Options 
                                        = MessagePackSerializerOptions
                                            .Standard
                                            .WithResolver(ContractlessStandardResolver.Instance)
                                            .WithCompression(MessagePackCompression.Lz4BlockArray);

    public static 
        byte[]
                                        Serialize<T>
                                        (
                                            T obj
                                        )
    {
        return MessagePackSerializer.Serialize(obj, Options);
    }

    public static 
        T
                                        Deserialize<T>
                                        (
                                            byte[] data
                                        )
    {
        return MessagePackSerializer.Deserialize<T>(data, Options);
    }

    public static string SerializeToJson<T>(T obj)
    {
        var binaryData = Serialize(obj);
        return MessagePackSerializer.ConvertToJson(binaryData);
    }

    public static T DeserializeFromJson<T>(string json)
    {
        var binaryData = MessagePackSerializer.ConvertFromJson(json);
        return Deserialize<T>(binaryData);
    }
}
