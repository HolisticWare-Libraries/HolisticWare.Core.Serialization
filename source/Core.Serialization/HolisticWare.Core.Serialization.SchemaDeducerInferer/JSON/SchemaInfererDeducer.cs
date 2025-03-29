using System.Collections.Generic;
using System.Threading.Tasks;
using NJsonSchema;

namespace Core.Serialization.SchemaInferenceDeduction.JSON
{
    /// <summary>
    /// SchemaInfererDeducer
    /// 
    /// </summary>
    public partial class
                                        SchemaInfererDeducer
                                        :
                                        ISchemaInfererDeducer
    {
        public
            NJsonSchema.JsonSchema
                                        InferDeduceSchemaAsync
                                        (
                                            string data
                                        )
        {
            NJsonSchema.JsonSchema schema = NJsonSchema.JsonSchema.FromSampleJson(data);

            schema = NJsonSchema.JsonSchema.FromJsonAsync();

            NJsonSchema.JsonSchema schema1 = JsonSchema.FromSampleJson("...");
            string schemaJson = schema1.ToJson();

            return schema;
        }

        public async
            Task
                <
                (
                    NJsonSchema.JsonSchema schema,
                    IEnumerable<NJsonSchema.CodeGeneration.CodeArtifact> types
                )
                >
                                        InferDeduceSchemaAsync
                                        (
                                            string data
                                        )
        {
            NJsonSchema.JsonSchema schema = await NJsonSchema.JsonSchema.FromJsonAsync(data);

            IEnumerable<NJsonSchema.CodeGeneration.CodeArtifact> types = GenerateTypes(schema);

            return
                (
                    schema: schema,
                    types: types
                );
        }

        private
            IEnumerable<NJsonSchema.CodeGeneration.CodeArtifact>
                                        GenerateTypes
                                        (
                                            JsonSchema schema
                                        )
        {
            NJsonSchema.CodeGeneration.CSharp.CSharpGenerator generator = null;
            generator = new NJsonSchema.CodeGeneration.CSharp.CSharpGenerator(schema);

            return generator.GenerateTypes();
        }

        public string InferDeduceSchema(string data)
        {
            throw new System.NotImplementedException();
        }
    }
}