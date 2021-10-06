using System;
using System.Threading.Tasks;

namespace HolisticWare.Core.Serialization.JSON
{
    public class CodeGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        /// https://github.com/RicoSuter/NJsonSchema
        public async
                Task<NJsonSchema.JsonSchema>
                                            JSONSchemaFromJSON
                                                        (
                                                            string json
                                                        )
        {
            NJsonSchema.JsonSchema schema = await NJsonSchema.JsonSchema.FromJsonAsync(json);
            string schemaData = schema.ToJson();

            return schema;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="json_schema"></param>
        /// <returns></returns>
        /// https://github.com/RicoSuter/NJsonSchema
        public async
                Task<string>
                                            CodeFromJSONSchema
                                                        (
                                                            NJsonSchema.JsonSchema json_schema
                                                        )
        {
            NJsonSchema.CodeGeneration.CSharp.CSharpGenerator generator;
            NJsonSchema.CodeGeneration.CSharp.CSharpGeneratorSettings generator_settings;

            generator_settings = new NJsonSchema.CodeGeneration.CSharp.CSharpGeneratorSettings()
            {
                ClassStyle = NJsonSchema.CodeGeneration.CSharp.CSharpClassStyle.Poco,
                JsonLibrary = NJsonSchema.CodeGeneration.CSharp.CSharpJsonLibrary.SystemTextJson
            };

            generator = new NJsonSchema.CodeGeneration.CSharp.CSharpGenerator
                                                                    (
                                                                        json_schema,
                                                                        generator_settings
                                                                    );
            string code = generator.GenerateFile();

            return code;
        }
    }
}
