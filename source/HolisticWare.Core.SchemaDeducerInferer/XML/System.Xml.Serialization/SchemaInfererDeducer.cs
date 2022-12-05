using System.Collections.Generic;
using System.Threading.Tasks;
using XmlSchemaClassGenerator;

namespace Core.Serialization.SchemaInferenceDeduction.XML.System.Xml.Serialization
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
            global::System.Xml.Schema.XmlSchema schema = null;

            //Begin parsing source XML document

            global::System.Xml.XmlDocument doc = new global::System.Xml.XmlDocument();

            try
            {
                //Assume string XML
                doc.LoadXml(data);
            }
            catch
            {
                //String XML load failed.   Try loading as a file path
                try
                {
                    doc.Load(data);
                }
                catch
                {
                    throw new global::System.Xml.Schema.XmlSchemaException("XML document is not well-formed.");
                }
            }

            global::System.Xml.XmlElement root = doc.DocumentElement;

            global::System.Xml.XmlReader reader = null;
            reader = global::System.Xml.XmlReader.Create(new System.IO.StringReader(data));
            global::System.Xml.Schema.XmlSchemaSet schema_set = null;
            schema_set = new global::System.Xml.Schema.XmlSchemaSet();
            global::System.Xml.Schema.XmlSchemaInference schema_inferred = null;
            schema_inferred = new global::System.Xml.Schema.XmlSchemaInference();
            schema_set = schema_inferred.InferSchema(reader);

            foreach (global::System.Xml.Schema.XmlSchema s in schema_set.Schemas())
            {
                using (global::System.IO.StringWriter sw = new global::System.IO.StringWriter())
                {
                    using (global::System.Xml.XmlWriter writer = global::System.Xml.XmlWriter.Create(sw))
                    {
                        s.Write(writer);
                    }
                }
            }

            return
                //(
                    schema
                //    types: types
                //)
                ;
        }

        string ISchemaInfererDeducer.InferDeduceSchema(string data)
        {
            return null;
        }
    }
}