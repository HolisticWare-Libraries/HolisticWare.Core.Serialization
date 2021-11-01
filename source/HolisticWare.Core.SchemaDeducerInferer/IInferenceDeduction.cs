using System.Threading.Tasks;

namespace Core.Serialization
{
    /// <summary>
    /// 
    /// </summary>
    public interface IInferenceDeduction
    {
        string InferDeduceSchema(string data);
    }
}