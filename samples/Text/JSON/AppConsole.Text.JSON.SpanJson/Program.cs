/*
please provide code sample in C# for
   SpanJson
serialization and deserialization
*/
using SpanJson;
using SpanJson.Resolvers;
using System;

public class 
                                        Program
{
    public static
        void 
                                        Main
                                        (                                            
                                        )
    {
        CustomPropertyNames obj = new CustomPropertyNames
        {
            OriginalName = "Example",
            AnotherProperty = 123
        };

        // Serialize the object to JSON using the custom resolver
        string json = JsonSerializer.Generic.Utf16.Serialize
                                                        <
                                                            CustomPropertyNames, 
                                                            CustomResolver<char>
                                                        >
                                                        (obj);

        Console.WriteLine(json);

        // Deserialize the JSON back to an object using the custom resolver
        CustomPropertyNames? deserializedObj = JsonSerializer.Generic.Utf16.Deserialize<CustomPropertyNames, CustomResolver<char>>(json);
        Console.WriteLine(deserializedObj.OriginalName); // Output: Example
        Console.WriteLine(deserializedObj.AnotherProperty); // Output: 123
    }
}