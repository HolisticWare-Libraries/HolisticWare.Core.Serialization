using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using HolisticWare.Ph4ct3x;

namespace HolisticWare.System.Text.Json;

[
    JsonSourceGenerationOptions
                (
                    WriteIndented = true, 
                    PropertyNamingPolicy = typeof(HolisticWare.System.Text.Json.PropertyNamingPolicy)
                )
]
[JsonSerializable(typeof(Person))]
internal partial class
                                        SourceGenerationContext 
                                        :
                                        JsonSerializerContext
{
    public 
                                        SourceGenerationContext
                                        (
                                            JsonSerializerOptions options
                                        ) 
                                        :
                                        base(options)
    {
        return;
    }

    public override 
        JsonTypeInfo 
                                        GetTypeInfo
                                        (
                                            Type type
                                        )
    {
        throw new NotImplementedException();
    }

    protected override JsonSerializerOptions GeneratedSerializerOptions { get; }
}
