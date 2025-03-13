# JSON Schema

readme.md

## QuickType


*   https://github.com/glideapps/quicktype

    *   https://app.quicktype.io/

    *   Supported Inputs

        *   JSON
        
        *   JSON API URLs
        
        *   JSON Schema


```
npm install -g quicktype
```

```
# Run quicktype without arguments for help and options
quicktype

# quicktype a simple JSON object in C#
echo '{ "name": "David" }' | quicktype -l csharp

# quicktype a top-level array and save as Go source
echo '[1, 2, 3]' | quicktype -o ints.go

# quicktype a sample JSON file in Swift
quicktype person.json -o Person.swift

# A verbose way to do the same thing
quicktype \
  --src person.json \
  --src-lang json \
  --lang swift \
  --top-level Person \
  --out Person.swift

# quicktype a directory of samples as a C++ program
# Suppose ./blockchain is a directory with files:
#   latest-block.json transactions.json marketcap.json
quicktype ./blockchain -o blockchain-api.cpp

# quicktype a live JSON API as a Java program
quicktype https://api.somewhere.com/data -o Data.java
```

```
# First, infer a JSON schema from a sample.
quicktype pokedex.json -l schema -o schema.json

# Review the schema, make changes,
# and commit it to your project repo.

# Finally, generate model code from schema in your
# build process for whatever languages you need:
quicktype -s schema schema.json -o src/android/Models.cs

# All of these models will serialize to and from the same
# JSON, so different programs in your stack can communicate
# seamlessly.
```

## `NJsonSchema`


## `Newtonsoft.Json.Schema``

*   commercial??