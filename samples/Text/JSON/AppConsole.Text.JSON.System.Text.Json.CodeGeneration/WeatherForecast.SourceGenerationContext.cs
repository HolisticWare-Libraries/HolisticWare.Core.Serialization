using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace AppConsole.System.Text.Json.CodeGeneration;


// WeatherForecast.SourceGenerationContext
[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(WeatherForecast))]
internal partial class SourceGenerationContext : JsonSerializerContext
{
    /*
    public SourceGenerationContext(JsonSerializerOptions? options) : base(options)
    {
    }

    public override JsonTypeInfo? GetTypeInfo(Type type)
    {
        throw new NotImplementedException();
    }

    protected override JsonSerializerOptions? GeneratedSerializerOptions { get; }
    */
}
