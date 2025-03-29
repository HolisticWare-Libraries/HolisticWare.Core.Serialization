/*
please provide code sample in C# for
   jil
serialization and deserialization
*/

using System;
using System.Collections.Generic;
using System.IO;
using Jil;

namespace SerializationExample;
public class Employee
{
   public int Id { get; set; }
   public string Name { get; set; }
   public string Email { get; set; }
   public string Dept { get; set; }
}

class Program
{
   static void Main(string[] args)
   {
      /*
         https://github.com/RicoSuter/NJsonSchema?tab=readme-ov-file
         https://github.com/RicoSuter/NJsonSchema/wiki/SampleJsonSchemaGenerator
         https://github.com/RicoSuter/SigSpec
      */

      var schema = JsonSchema.FromSampleJson("...");
      var schemaJson = schema.ToJson();

      string json_schema = 
      """
      {
      "$schema": "http://json-schema.org/draft-04/schema#",
      "title": "Person",
      "type": "object",
      "additionalProperties": false,
      "required": [
         "FirstName",
         "LastName"
      ],
      "properties": {
         "FirstName": {
            "type": "string"
         },
         "MiddleName": {
            "type": [
            "null",
            "string"
            ]
         },
         "LastName": {
            "type": "string"
         },
         "Gender": {
            "oneOf": [
            {
               "$ref": "#/definitions/Gender"
            }
            ]
         },
         "NumberWithRange": {
            "type": "integer",
            "format": "int32",
            "maximum": 5.0,
            "minimum": 2.0
         },
         "Birthday": {
            "type": "string",
            "format": "date-time"
         },
         "Company": {
            "oneOf": [
            {
               "$ref": "#/definitions/Company"
            },
            {
               "type": "null"
            }
            ]
         },
         "Cars": {
            "type": [
            "array",
            "null"
            ],
            "items": {
            "$ref": "#/definitions/Car"
            }
         }
      },
      "definitions": {
         "Gender": {
            "type": "integer",
            "description": "",
            "x-enumNames": [
            "Male",
            "Female"
            ],
            "enum": [
            0,
            1
            ]
         },
         "Company": {
            "type": "object",
            "additionalProperties": false,
            "properties": {
            "Name": {
               "type": [
                  "null",
                  "string"
               ]
            }
            }
         },
         "Car": {
            "type": "object",
            "additionalProperties": false,
            "properties": {
            "Name": {
               "type": [
                  "null",
                  "string"
               ]
            },
            "Manufacturer": {
               "oneOf": [
                  {
                  "$ref": "#/definitions/Company"
                  },
                  {
                  "type": "null"
                  }
               ]
            }
            }
         }
      }
      }
      """;

      /*
        var location = Assembly.GetExecutingAssembly().Location;
        var path = Path.GetFullPath(Path.Combine(location, @"..\..\..\Schemas"));
        var schemaJson = File.ReadAllText($"{path}Test.json");
        var schema = JsonSchema4.FromJsonAsync(schemaJson).Result;
        var generator = new CSharpGenerator(schema);
        var generatedFile = generator.GenerateFile();
      */

   }
}

