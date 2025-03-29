using System.Threading.Tasks;

namespace Core.Serialization.SchemaInferenceDeduction
{
    /// <summary>
    /// ISchemaInfererDeducer.
    /// </summary>
    public interface
                                        ISchemaInfererDeducer
    {
        public
            string
                                        InferDeduceSchema
                                        (
                                            string data
                                        );
    }
}