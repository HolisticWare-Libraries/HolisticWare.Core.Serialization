# HolisticWare.Core.Serialization

HolisticWare.Core.Serialization package with `Core.Serialization` namespace.

Definition:

*   https://en.wikipedia.org/wiki/Serialization

*   https://en.wikipedia.org/wiki/Comparison_of_data-serialization_formats

*   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/

*   https://stackoverflow.com/questions/633402/what-is-serialization#:~:text=Serialization%20is%20the%20process%20of%20converting%20an%20object%20into%20a,reverse%20process%20is%20called%20deserialization.

*   https://en.wikipedia.org/wiki/Marshalling_(computer_science)

*   https://github.com/morrisjdev/FileContextCore

Terms:

*   Serialization/Deserialization

    *   C#

*   Marshalling/Unmarshalling

    *   Julia
    
## References / Links

*   https://github.com/khalidabuhakmeh/conversions

    *   https://khalidabuhakmeh.com/convert-a-csharp-object-to-almost-any-format

## Formats

### JSON

*   `System.Text.Json`

    *   https://docs.microsoft.com/en-us/dotnet/api/system.text.json
    
*   `Newtonsoft.Json`

    *   

*   https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to

### XML

### YAML

### TOML

*   https://github.com/toml-lang/toml

*   https://en.wikipedia.org/wiki/TOML

*   https://learnxinyminutes.com/docs/toml/

*   https://toml.io/en/

*   https://github.com/rossipedia/toml-net

*   https://github.com/xoofx/Tomlyn

*   https://www.genericgamedev.com/general/serialisation-comparing-xml-sdl-toml-json/

*   https://en.wikipedia.org/wiki/Recfiles

### SOAP

### OData

### BSON

## Code Generation

*   code generation

    *   C#
    
    *   other
    
        using intermediate C#
        
        *   Julia
        
        *   R
        
        *   Python
        
        *   Matlab/Octave
        
## C# POCO classes from formats


### JSON

JSON to JSON Schema

*   NJsonSchema
    
    *   https://github.com/RicoSuter/NJsonSchema

        *   Applications which use the library:

            *   VisualJsonEditor, a JSON schema based file editor for Windows.

            *   NSwag: The Swagger API toolchain for .NET

            *   SigSpec for SignalR Core: Specification and code generator for SignalR Core.

    *   https://gist.github.com/rushfrisby/c8f58f346548bf31e045

    *   https://stackoverflow.com/questions/21611674/how-to-auto-generate-a-c-sharp-class-file-from-a-json-string

    *   https://stackoverflow.com/questions/9229237/benefits-and-drawbacks-of-generated-c-sharp-classes-for-json-objects

    *   https://medium.com/@nuno.caneco/dont-write-your-web-api-client-code-6f1dd36263b5

    *   https://elanderson.net/2019/11/using-nswag-to-generate-c-client-classes-for-asp-net-core-3/


### XML 

*   https://github.com/mganss/XmlSchemaClassGenerator

*   https://stackoverflow.com/questions/3680353/how-do-i-programmatically-generate-an-xml-schema-from-a-type

*   http://mikehadlow.blogspot.com/2007/01/writing-your-own-xsdexe.html

*   https://www.itprotoday.com/microsoft-visual-studio/generate-xml-schemas-programmatically-net


1.  invoke `xsd.exe` programmatically by referencing it, which is available with .NET SDK:

    *   http://msdn.microsoft.com/en-us/library/x6c1kb0s.aspx 

2.  use built-in schema class in .NET

    *   XMLSchemaExporter

        *   http://msdn.microsoft.com/en-us/library/system.xml.serialization.xmlschemaexporter.aspx 

    *   XML Schema Object Model

        *   http://msdn.microsoft.com/en-us/library/bs8hh90b(v=VS.100).aspx 

    *   XML Schema Class

        *   http://msdn.microsoft.com/en-us/library/system.xml.schema.xmlschema.aspx

### YAML

*   https://stackoverflow.com/questions/25095893/seeking-guidance-reading-yaml-files-with-c-sharp

*   text formatters

    *   https://github.com/fiyazbinhasan/CoreFormatters

## Diverse

*   Data Annotations (Metadata, ModelMetadata)

    *   https://github.com/search?l=C%23&q=ModelMetadataType

    *   https://github.com/search?q=Microsoft.AspNetCore.Mvc&type=code

    *   https://github.com/search?q=Microsoft.AspNetCore.Mvc.ModelMetadataType&type=code

    *   https://github.com/aspnet/Mvc/blob/master/src/Microsoft.AspNetCore.Mvc.Core/ModelMetadataTypeAttribute.cs

    *   https://github.com/aspnet/Mvc/blob/master/src/Microsoft.AspNetCore.Mvc.Core/ModelBinding/Metadata/ModelAttributes.cs

    *   more

        *   https://github.com/Kentico/kontent-delivery-sdk-net/wiki/Strong-Types-Explained-%E2%80%93-DataAnnotations-attributes

        *   https://github.com/Kentico/kontent-delivery-sdk-net/wiki/Partial-class-customization-techniques

## Performance

*   https://blog.fractalia.se/blog/keeping-system-text-json-lean/

# Serialization


