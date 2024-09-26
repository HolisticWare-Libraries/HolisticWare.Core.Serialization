# HolisticWare.Core.Serialization

readme.md

*   package `HolisticWare.Core.Serialization`

    *   namespace `Core.Serialization`

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

*   https://github.com/AoxeTech/Aoxe.Serialization

*   https://github.com/StoyanShopov/XmlFacade/

*   https://github.com/Marvin-Brouwer/FluentSerializer

*   https://github.com/khalidabuhakmeh/conversions

    *   https://khalidabuhakmeh.com/convert-a-csharp-object-to-almost-any-format

## Formats

## Binary

### MemoryPack

*   https://github.com/Cysharp/MemoryPack

    *   faster than `MessagePack` for C#/.NET only environments

*   fixed length (zero formatter)

*   https://neuecc.medium.com/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516

### MessagePack

*   https://github.com/neuecc/MessagePack-CSharp

*   https://github.com/neuecc/MessagePack-CSharp#high-level-api-messagepackserializer

*   variable length

*   adopted by Microsoft standard products such as 

    *   Visual Studio 2022, 
    
    *   SignalR MessagePack Hub Protocol, and 
    
    *   the Blazor Server protocol(blazorpack).

*   https://github.com/akkadotnet/Akka.Serialization.MessagePack

### protobuf

*   https://developers.google.com/protocol-buffers/docs/csharptutorial

*   https://developers.google.com/protocol-buffers/docs/reference/csharp-generated

*   https://docs.microsoft.com/en-us/aspnet/core/grpc/protobuf?view=aspnetcore-5.0

*   https://docs.microsoft.com/en-us/aspnet/core/grpc/basics?view=aspnetcore-5.0

*   https://github.com/protobuf-net/protobuf-net#1-first-decorate-your-classes

*   https://github.com/protobuf-net/protobuf-net/wiki/Attributes

### bond

*   http://microsoft.github.io/bond/manual/bond_cs.html#attributes

*   http://microsoft.github.io/bond/manual/bond_over_grpc.html

*   https://microsoft.github.io/bond/why_bond.html

*   https://stackoverflow.com/questions/39571388/using-microsoft-bond-in-a-c-sharp-project

*   https://github.com/microsoft/bond

*   https://github.com/jterry75/Bond-ASP.NET-Core-Formatters/tree/master/test/Bond.AspNetCore.Mvc.Formatters.Tests

### flatbuffers

*   https://github.com/google/flatbuffers

    *   https://www.nuget.org/packages/Google.FlatBuffers

*   https://github.com/jamescourtney/FlatSharp

*   https://google.github.io/flatbuffers/flatbuffers_guide_use_c-sharp.html


*   FBS schema file

    *   https://github.com/jamescourtney/FlatSharp/blob/master/samples/Example2-SchemaFiles/SchemaFilesExample.fbs

*   https://medium.com/@icex33/beyond-json-introduction-to-flatbuffers-fba1dfd0dcfe

### BinaryPack

*   https://github.com/Sergio0694/BinaryPack

*   https://github.com/SubnauticaNitrox/BinaryPack

### avro

*   https://github.com/AdrianStrugala/AvroConvert

*   https://engineering.chrobinson.com/dotnet-avro/guides/cli-generate/

*   https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.datacontractattribute?view=net-5.0

*   https://github.com/apache/avro/pulls?q=is%3Apr+moljac+is%3Aclosed

*   https://github.com/apache/avro/pull/307

### thrift

*   https://livebook.manning.com/book/programmers-guide-to-apache-thrift/chapter-13/86

*   http://www.alternatestack.com/uncategorized/apache-thrift-and-its-usage-in-c/

*   https://github.com/sivabudh/thrifly

*   https://dev.to/jeikabu/migrating-to-aspnet-core-w-apache-thrift-45f6

*   https://thrift.apache.org/tutorial/netstd

### MessageShark

*   https://github.com/rpgmaker/MessageShark

*   https://github.com/rpgmaker/MessageShark/blob/master/Samples/MessageShark.Samples.ProtoBufVsMessageShark/MessageShark.Samples.ProtoBufVsMessageShark/SimpleObject.cs

### ZeroFormatter

*   https://github.com/neuecc/ZeroFormatter/

### Binaron

*   https://github.com/zachsaw/Binaron.Serializer

*   https://github.com/salarcode/Bois

### Hyperion

*   https://github.com/akkadotnet/Hyperion

### bebop

*   https://github.com/betwixt-labs/bebop

### netserializer

*   https://github.com/tomba/netserializer

### Wire

*   https://github.com/asynkron/Wire

### Apex.Serialization

*   https://github.com/dbolin/Apex.Serialization

### BinarySerializer

*   https://github.com/jefffhaynes/BinarySerializer

### Combined

*   https://github.com/bfriesen/XSerializer/tree/master

*   https://github.com/AoxeTech/Aoxe.Serialization

#### Bender

*   https://github.com/mikeobrien/Bender



https://github.com/xfrogcn/Xfrogcn.BinaryFormatter


*   https://github.com/Mallos/Mallos.Serialization

https://github.com/ReubenBond/Hagar

https://github.com/skbkontur/GroBuf


## Textual

### JSON

*   `System.Text.Json`

    *   https://docs.microsoft.com/en-us/dotnet/api/system.text.json

*   `Newtonsoft.Json`

*   `fastJSON` `PowerJSON`

    *   https://github.com/mgholam/fastJSON

        *   https://github.com/kamranayub/fastJSON

        *   https://www.codeproject.com/Articles/159450/fastJSON-Smallest-Fastest-Polymorphic-JSON-Seriali

        *   https://github.com/chuxuantinh/PowerJSON

*   `NetJSON`

    *   https://github.com/rpgmaker/NetJSON/

*   `Utf8Json`

    *   https://github.com/neuecc/Utf8Json

*   `Jsonincs`

    *   https://github.com/trampster/Jsonics

*   `Jil`

    *   https://github.com/kevin-montrose/Jil

        ```
        Jil.DeserializationException
        "Expected character: '\\'"
        ```

        *   https://stackoverflow.com/questions/29536206/jil-net-json-deserialization-exception

        *   https://github.com/kevin-montrose/Jil/blob/master/Jil/Options.cs

*   `SpanJson`

    *   https://github.com/Tornhoof/SpanJson

        *   problem: `net6`, `net5`

        *   https://github.com/Tornhoof/SpanJson/issues?q=is%3Aissue+netstandard

        *   fork

            *   https://github.com/cuteant/SpanJson

            *   fork for nugets

                *   https://github.com/HolisticWare/HolisticWare.SpanJson
             
*   `litJSON`

   *   https://litjson.net/
   
*   `Swifter.Json`

    *   https://github.com/Dogwei/Swifter.Json

*   `jsonfx`

    https://github.com/jsonfx/jsonfx

*   https://github.com/gregsdennis/Manatee.Json

*   https://github.com/libla/TinyJSON

#### JSON Schema

*   https://github.com/dansiegel/Mobile.BuildTools/blob/master/tools/Mobile.BuildTools.SchemaGenerator/Program.cs#L34-L45

## Online Tools

*   JSON to C#

    *   https://json2csharp.com/

    *   https://app.quicktype.io/?l=csharp

    *   https://www.site24x7.com/tools/json-to-csharp.html

    *   https://wtools.io/convert-json-to-csharp-class

    *   https://jsonutils.com/

*   https://transform.tools/json-to-json-schema

*   https://github.com/jsonsystems/public#cli

#### References / Links


#### Benchmarks

*   https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to

*   https://michaelscodingspot.com/the-battle-of-c-to-json-serializers-in-net-core-3/

*   https://aloiskraus.wordpress.com/2019/09/29/net-serialization-benchmark-2019-roundup/

*   https://theburningmonk.com/2014/08/json-serializers-benchmarks-updated-2/

*   https://www.codeproject.com/Articles/159450/fastJSON-Smallest-Fastest-Polymorphic-JSON-Seriali

*   https://endjin.com/blog/2021/05/csharp-serialization-with-system-text-json-schema

*   https://github.com/maximn/SerializationPerformanceTest_CSharp

*   JSON schema generators proposed so far:

    *   Online:

        *   https://www.liquid-technologies.com/online-json-to-schema-converter

        *   http://www.jsonschema.net (1 input)

        *   https://easy-json-schema.github.io (1 input)

*   https://github.com/Alois-xx/SerializerTests

*   https://github.com/Im5tu/SerializationBenchmarks

### XML

*   https://www.reddit.com/r/csharp/comments/s8wky4/which_xml_parser_should_i_use/

*   `XmlDocument`

    is focused on full, piece-by-piece XML DOM control. Use this if you need to inspect or edit the DOM with extreme precision. It uses XmlNode objects as a generic container for the XML elements, attributes, and contents. XPath queries can be used with this.

*   `XDocument` 

    is geared toward LINQ usage. Use this if you need to retrieve or edit entire sets of data within an XML document based on filters. It, too, uses a generic XML node representation. XPath queries can be used with this.

*   `XmlSerializer` 

    is used to convert between XML-formatted text and C# objects. If you have POCOs you need to map from/to XML, use this.

*   `XmlReader` 

    is an XML-aware stream reader that gets used by the serializer and other tools. Use this if you need to just ferry XML blobs between files and other sources/consumers.

Which one you use is really up to you. Underneath it all, they're all mostly the same, and are intertwined with each other.

```csharp
namespace Tests.CommonShared
{
    public class Something
    {
        public Something()
        {
        }

        public string Name
        {
            get;
            set;
        }

        public DateTime DateOfBirth
        {
            get;
            set;
        }
    }
}
```

```xml
<?xml version="1.0" encoding="UTF-8"?>
    <Something>
        <DateOfBirth>2021-10-06T18:07:06.901969+02:00</DateOfBirth>
        <Name>something</Name>
    </Something>
```

```xml
<?xml version="1.0" encoding="UTF-8"?>
    <root>
        <DateOfBirth>2021-10-06T18:07:06.901969+02:00</DateOfBirth>
        <Name>something</Name>
    </root>
```

```
System.InvalidOperationException : There is an error in XML document (2, 2).
---- System.InvalidOperationException : <root xmlns=''> was not expected.
```

```
System.InvalidOperationException : There is an error in XML document (2, 2).
xmlns='' was not expected.
```

```
[Serializable, XmlRoot("root")]
public partial class Something
{
}
```

```
XmlSerializer xs = new XmlSerializer
(typeof(User), new XmlRootAttribute("yourRootName"));
```


*   PerfXml

    *   https://github.com/CoderWeather/PerfXml

        *   https://www.nuget.org/packages/PerfXml

ExtendedXmlSerializer

    https://github.com/ExtendedXmlSerializer/home

NetBike.Xml

    https://github.com/netbike/netbike.xml

https://github.com/JonCanning/CerealBox

YAXLib

    https://github.com/YAXLib/YAXLib

SharpSerializer

    https://github.com/polenter/SharpSerializer
    
        https://www.sharpserializer.net/en/index.html

XSerializer

    https://github.com/bfriesen/XSerializer

*   AtlasXmlSerializer

    *   https://github.com/Atlas-Project/AtlasXmlSerializer

https://github.com/tangdf/FastXmlSerialization

https://github.com/leonbreedt/xmapper

https://www.erikthecoder.net/2019/08/02/xml-parsing-performance-csharp-versus-go/

https://www.reddit.com/r/csharp/comments/drz89h/i_made_binarypack_the_fastest_and_most_efficient/

#### `xsd`

*   https://stackoverflow.com/questions/3680353/how-do-i-programmatically-generate-an-xml-schema-from-a-type/

*   http://mikehadlow.blogspot.com/2007/01/writing-your-own-xsdexe.html

*   `XmlCodeExporter`

    *   https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlcodeexporter?redirectedfrom=MSDN&view=netframework-4.8

#### `XmlSchemaInference`

*   https://docs.microsoft.com/en-us/dotnet/api/system.xml.schema.xmlschemainference?view=net-5.0

#### Alternatives

*   https://github.com/ZingBallyhoo/StackXML

*   https://neuecc.medium.com/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516

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

### INI 

*   https://www.codeproject.com/Articles/5387487/Csharp-INI-File-Parser


### CSV

*   https://github.com/kevin-montrose/Cesil

### SOAP

### OData

### BSON

*   https://github.com/karlseguin/Metsys.Bson

*   https://github.com/atheken/NoRM


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

### HyperSerializer

*   https://github.com/adam-dot-cohen/HyperSerializer

### Apex.Serialization

*   https://github.com/dbolin/Apex.Serialization

    *   Tips for best performance

        *   Use sealed type declarations when possible - this allows the serializer to skip writing any type information

        *   Create empty constructors (or constructors that assign to every field from parameters matching the field types) for classes that will be serialized/deserialized a lot (only helps if there's no inline field initialization as well)

        *   Use different serializer instances for different workloads (e.g. one for serializing a few objects at a time and one for large graphs), and pool serializer instances

        *   Don't inherit from standard collections

*   https://github.com/Alois-xx/SerializerTests/pull/9/files

```
    <PackageReference Include="Apex.Serialization" Version="1.0.0" />
```


### INI file

*   https://www.codeproject.com/Tips/5319923/IniReader-A-Simple-Tiny-INI-Reader

### Microformats

#### vCards

*   https://github.com/mixerp/MixERP.Net.VCards

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

### `System.Text.Json`

*   https://blog.fractalia.se/blog/keeping-system-text-json-lean/

# Serialization


## Workflow

1.  generate C# classes from XML or JSON or ________ (file the blank)

2.  copy file to preserve attributes and create new class (Buddy class) by:

    2.1 renaming class

    2.2 renaming namespace

        add namespace suffix `.Serialization.Formatters`

2.  add partial class for serialization api

    `*.Serialization.cs`

    2.1 mark the class with Metadata attribute

    2.2 add API for serialization

3.  convert C# class to Buddy class with Serialization Attributes from step 1

    *   XML

    *   JSON

        *

## WebApi

*   https://github.com/WebApiContrib/WebAPIContrib.Core#formatters

*   https://wakeupandcode.com/xml-json-serialization-in-asp-net-core/

*   https://blog.elmah.io/lessons-learned-after-migrating-25-projects-to-net-core/

*   https://weblog.west-wind.com/posts/2012/mar/09/using-an-alternate-json-serializer-in-aspnet-web-api


## Diverse

*   https://github.com/Wagsn/SerializerSharp/tree/master/SerializerSharp

*   https://nugetmusthaves.com/Tag/serializer

*   https://github.com/eallegretta/serialization-providers

*   http://universalserializer.com/

*   https://github.com/BillBensing/MessageSerializer-CSharp

*   http://www.iana.org/assignments/media-types/media-types.xhtml

*   https://docs.spring.io/spring-cloud-stream/docs/Brooklyn.M1/reference/html/contenttypemanagement.html#mime-types


### tests

*   https://github.com/Alois-xx/SerializerTests

*   https://github.com/neuecc/SerializerTests
