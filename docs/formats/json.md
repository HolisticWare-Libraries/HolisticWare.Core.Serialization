# JSON to C#

https://github.com/glideapps/quicktype

```
npm install -g quicktype
```

https://github.com/sleeuwen/dotnet-json

https://github.com/bladefist/JsonUtils


```
# Whitespace-safe and recursive
shopt -s globstar
for JSON_FILE in **/*.json; 
do
    echo "quicktype" $JSON_FILE

    quicktype \
        --lang csharp \
        --top-level Generated \
        --out $JSON_FILE.cs \
        --src-lang json \
        --src $JSON_FILE

done


```

## Troubleshooting

### Error `The JSON value could not be converted to Path`

```
The JSON value could not be converted to Path: $ | LineNumber: 0 | BytePositionInLine: 1.
```

Most likely tried to deserialize object:

```csharp
ConfigRoot cg = System.Text.Json.JsonSerializer.Deserialize<ConfigRoot>
                                                            (
                                                                content_json,
                                                                new System.Text.Json.JsonSerializerOptions
                                                                {
                                                                    ReadCommentHandling = System.Text.Json.JsonCommentHandling.Skip
                                                                }
                                                            );
```

instead of array of objects:

```csharp
ConfigRoot[] cg = System.Text.Json.JsonSerializer.Deserialize<ConfigRoot[]>
                                                            (
                                                                content_json,
                                                                new System.Text.Json.JsonSerializerOptions
                                                                {
                                                                    ReadCommentHandling = System.Text.Json.JsonCommentHandling.Skip
                                                                }
                                                            );
```
