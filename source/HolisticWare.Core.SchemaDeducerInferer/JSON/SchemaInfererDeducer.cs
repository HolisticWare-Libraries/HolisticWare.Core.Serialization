using System.Collections.Generic;
using System.Threading.Tasks;
using NJsonSchema;

namespace Core.Serialization.SchemaInferenceDeduction.JSON
{
    /// <summary>
    /// 
    /// </summary>
    public class SchemaInfererDeducer
                        :
                        ISchemaInfererDeducer
    {
        public async
            Task
                <
                (
                    NJsonSchema.JsonSchema schema,
                    IEnumerable<NJsonSchema.CodeGeneration.CodeArtifact> types
                )
                >
                                                InferDeduceSchema
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

        string ISchemaInfererDeducer.InferDeduceSchema(string data)
        {
            throw new System.NotImplementedException();
        }
    }
}