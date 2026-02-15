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
    private static readonly
        Microsoft.IO.RecyclableMemoryStreamManager
                                        manager = new ();

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
        return this.SerializeMarshall_MemoryStream<T>(t);
    }

    public
        string
                                        SerializeMarshall_MemoryStream<T>
                                        (
                                            T t
                                        )
    {
        string xml = default;
        global::System.Xml.Serialization.XmlSerializer serializer = null;
        serializer = new global::System.Xml.Serialization.XmlSerializer(typeof(T));

        using (global::System.IO.MemoryStream stream = new ())
        using
            (
                global::System.IO.StreamReader reader = new
                                                        (
                                                            stream,
                                                            global::System.Text.Encoding.UTF8
                                                        )

            )
        {
            xml = reader.ReadToEnd();
        }

        return xml;
    }

    public
        string
                                        SerializeMarshall_RecyclableMemoryStream<T>
                                        (
                                            T t
                                        )
    {
        global::System.Xml.Serialization.XmlSerializer serializer = new(typeof(T));
        string xml = default;

        using (Microsoft.IO.RecyclableMemoryStream stream = manager.GetStream())
        using ( global::System.IO.StringWriter writer = new () )
        {
            serializer.Serialize(writer, t);
            xml = writer.ToString();
        }

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
