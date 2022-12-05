using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Serialization.SchemaInferenceDeduction.XML.XmlSchemaClassGenerator
{
    /// <summary>
    /// 
    /// </summary>
    /// https://www.itprotoday.com/microsoft-visual-studio/generate-xml-schemas-programmatically-net
    /// https://github.com/mganss/XmlSchemaClassGenerator
    /// https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.xsddatacontractexporter?view=net-5.0
    /// 
    public class SchemaInfererDeducer
                        :
                        ISchemaInfererDeducer
    {
        public async
            Task
                <
                    //(
                    global::System.Xml.Schema.XmlSchema //schema,
                    //IEnumerable<NJsonSchema.CodeGeneration.CodeArtifact> types
                //)
                >
                                                InferDeduceSchema
                                                            (
                                                                string data
                                                            )
        {
            return
                //(
                    schema
                //    types: types
                //)
                ;
        }

    }
}