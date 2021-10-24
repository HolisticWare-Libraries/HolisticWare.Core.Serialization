

https://www.w3.org/XML/Schema

XMLSchemaExporter:

http://msdn.microsoft.com/en-us/library/system.xml.serialization.xmlschemaexporter.aspx 

 XML Schema Object Model:

http://msdn.microsoft.com/en-us/library/bs8hh90b(v=VS.100).aspx 

XML Schema Class:

http://msdn.microsoft.com/en-us/library/system.xml.schema.xmlschema.aspx

https://docs.microsoft.com/en-us/dotnet/api/system.xml.schema.xmlschemainference.inferschema?view=net-5.0

```
XmlReader reader = XmlReader.Create("contosoBooks.xml");
XmlSchemaSet schemaSet = new XmlSchemaSet();
XmlSchemaInference schema = new XmlSchemaInference();

schemaSet = schema.InferSchema(reader);

foreach (XmlSchema s in schemaSet.Schemas())
{
    s.Write(Console.Out);
}
```