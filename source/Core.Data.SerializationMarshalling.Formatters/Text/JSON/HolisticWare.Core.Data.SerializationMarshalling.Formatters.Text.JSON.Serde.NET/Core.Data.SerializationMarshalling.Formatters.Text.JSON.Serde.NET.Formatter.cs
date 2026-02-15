namespace Core.Data.SerializationMarshalling.Formatters.Text.JSON.Serde.NET;

public partial class
                                        Formatter
{
    public static
        string?
                                        Serialize<T>
                                        (
                                            T t
                                        )
                                        where T
                                        :
                                        global::Serde.ISerializeProvider<T>
    {
        string? result = default(string);

        result = global::Serde.Json.JsonSerializer.Serialize(t);

        return result;
    }

    public static
        T?
                                        Deserialize<T>
                                        (
                                            string json
                                        )
                                        where T
                                        :
                                        global::Serde.ISerializeProvider<T>
    {
        if (!typeof(T).IsDefined(typeof(global::Serde.GenerateSerde), true))
        {
            string msg = "T must have attribute [Serde.GenerateSerde] Serde.GenerateSerdeAttribute";
            throw new System.ArgumentException(msg);
        }

        T? t = default(T);

        // t = global::Serde.Json.JsonSerializer.Deserialize(json);

        return t;
    }
}