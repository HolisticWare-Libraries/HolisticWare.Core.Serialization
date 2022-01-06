using System.Threading.Tasks;

namespace Core.Serialization.SchemaInferenceDeduction
{
    /// <summary>
    /// 
    /// </summary>
    /// https://github.com/RicoSuter/NJsonSchema
    /// 
    public class SchemaInfererDeducer
                        :
                        ISchemaInfererDeducer
    {
        public string InferDeduceSchema(string data)
        {
            string result = null;

            Task<NJsonSchema.JsonSchema> schema = NJsonSchema.JsonSchema.FromJsonAsync(data);


            NJsonSchema.CodeGeneration.CSharp.CSharpGenerator generator = null;
            generator = new NJsonSchema.CodeGeneration.CSharp.CSharpGenerator(schema);

            System.Collections.Generic.IEnumerable<NJsonSchema.CodeGeneration.CodeArtifact> types = null;
            types = generator.GenerateTypes();



            return result;
        }


    }
}