// https://cakebuild.net/docs/fundamentals/preprocessor-directives

#addin nuget:?package=YamlDotNet&loaddependencies=true
#addin nuget:?package=Newtonsoft.Json&loaddependencies=true

using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.RepresentationModel;
using Newtonsoft.Json;


StringReader sr = 
                new StringReader
                (
                    @"
                        TestPaySignService:
                            Test:
                                TestString:
                                    settings-key: TestStringValue
                                    types:
                                        - type1
                                        - type2

                                TestString2:
                                    settings-key: TestStringValue2
                                    types:
                                        - type1
                                        - type2
                    "
                );

string text = System.IO.File.ReadAllText("./data/plan-nutrition.yaml");
sr = new StringReader(text);

Deserializer deserializer = new Deserializer();
var yaml_object = 
            //deserializer.Deserialize<dynamic>(sr)["TestPaySignService"]["Test"].Values
            //
            //deserializer.Deserialize<dynamic>(sr)["Nutrition"]["Energy"].Values
            //deserializer.Deserialize<dynamic>(sr)["Nutrition"]["Energy"]
            //deserializer.Deserialize<dynamic>(sr)["Nutrition"]
            deserializer.Deserialize<dynamic>(sr)
            ;

/*
JsonSerializer serializer_compact = new JsonSerializer();
serializer_compact.Serialize
                        (
                            Console.Out, 
                            yaml_object
                        );
*/

Console.WriteLine(JsonUtil.JsonPrettify(JsonConvert.SerializeObject(yaml_object)));

class JsonUtil
{
    public static string JsonPrettify(string json)
    {
        using (StringReader stringReader = new StringReader(json))
        using (StringWriter stringWriter = new StringWriter())
        {
            JsonTextReader jsonReader = new JsonTextReader(stringReader);
            JsonTextWriter jsonWriter = new JsonTextWriter(stringWriter) { Formatting = Formatting.Indented };
            jsonWriter.WriteToken(jsonReader);
            return stringWriter.ToString();
        }
    }
}