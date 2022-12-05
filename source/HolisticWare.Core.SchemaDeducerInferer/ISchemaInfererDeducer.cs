using System.Threading.Tasks;

namespace Core.Serialization.SchemaInferenceDeduction
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISchemaInfererDeducer
    {
        string InferDeduceSchema(string data);
    }
}