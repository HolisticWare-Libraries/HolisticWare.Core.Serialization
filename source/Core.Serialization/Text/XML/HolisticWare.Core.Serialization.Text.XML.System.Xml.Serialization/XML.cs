using System.Threading.Tasks;

namespace Core.Serialization.Text.XML.System.Xml.Serialization;

/// <summary>
/// XML class for serialization/deserialization with System.Xml.Serialization.XmlSerializer
/// </summary>
/// https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer
public partial class 
                                        XML 
                                        :
                                        IStorageTransmission
{
    public 
        T 
                                        DeserializeUnmarshall<T>
                                        (
                                            string text
                                        )
                                        where T 
                                        :
                                        new()
    {
        global::System.Xml.Serialization.XmlSerializer serializer = null;
        serializer = new global::System.Xml.Serialization.XmlSerializer(typeof(T));

        T result = default(T);

        using (global::System.IO.TextReader r = new global::System.IO.StringReader(text))
        {
            result = (T)serializer.Deserialize(r);
        }

        return result;
    }

    public async 
        Task<T> 
                                        DeserializeUnmarshallAsync<T>
                                        (
                                            string text
                                        )
                                        where T 
                                        :
                                        new()
    {
        return await Task.Run
                            (
                                () =>
                                {
                                    return DeserializeUnmarshall<T>(text);
                                }
                            );
    }

    public 
        string
                                        SerializeMarshall<T>
                                        (
                                            T t
                                        )
    {
        global::System.Xml.Serialization.XmlSerializer serializer = null;
        serializer = new global::System.Xml.Serialization.XmlSerializer(typeof(T));

        global::System.IO.MemoryStream stream = new ();
        global::System.IO.StreamWriter writer = new 
                                                    (
                                                        stream,
                                                        global::System.Text.Encoding.UTF8
                                                    );

        serializer.Serialize(writer, t);
        writer.Flush();
        stream.Position = 0;

        using global::System.IO.StreamReader reader = new (stream);
        string xml = reader.ReadToEnd();

        return xml;
    }

    public async 
        Task<string> 
                                        SerializeMarshallAsync<T>
                                        (
                                            T t
                                        )
    {
        return await Task.Run
                            (
                                () =>
                                {
                                    return SerializeMarshallAsync<T>(t);
                                }
                            );
    }
}
