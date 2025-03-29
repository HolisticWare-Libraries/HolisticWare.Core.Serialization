/*
please provide code sample in C# for
   System.Text.Json
serialization and deserialization with source generator


*/


using System;
using System.Text.Json;
using AppConsole.System.Text.Json.CodeGeneration;

public class Program
{
   public static void Main()
   {
      WeatherForecast forecast = new()
      {
         Date = DateTime.Now,
         TemperatureCelsius = 25,
         Summary = "Sunny"
      };

      // Serialize
      string jsonString = JsonSerializer.Serialize
                                          (
                                             forecast, 
                                             SourceGenerationContext.Default.WeatherForecast
                                          );
      Console.WriteLine($"Serialized JSON: {jsonString}");

      // Deserialize
      WeatherForecast? deserializedForecast = JsonSerializer.Deserialize<WeatherForecast>
                                                               (
                                                                  jsonString, 
                                                                  SourceGenerationContext.Default.WeatherForecast
                                                               );
      Console.WriteLine($"Deserialized Object: {deserializedForecast?.Summary}");
   }
}
