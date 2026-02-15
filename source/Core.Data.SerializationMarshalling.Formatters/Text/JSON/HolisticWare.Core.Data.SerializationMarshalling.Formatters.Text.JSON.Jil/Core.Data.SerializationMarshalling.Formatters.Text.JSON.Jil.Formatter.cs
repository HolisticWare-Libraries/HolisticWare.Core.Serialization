namespace Core.Data.Formatters.Text.JSON.Jil;

public partial class
                                        Formatter
{
    public static
        string?
                                        Serialize<T>
                                        (
                                            T t
                                        )
    {
        string? result = global::Jil.JSON.Serialize(t);

        return result;
    }

    public static
        T?
                                        Deserialize<T>
                                        (
                                            string json
                                        )
    {
        T? t = global::Jil.JSON.Deserialize<T>(json);

        return t;
    }

}
