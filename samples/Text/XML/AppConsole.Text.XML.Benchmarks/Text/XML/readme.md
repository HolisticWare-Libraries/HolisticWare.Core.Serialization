# Results

2024-09-28

| Method                                             | Job      | Runtime  |        Mean |       Error |      StdDev | Completed Work Items | Lock Contentions | Exceptions |   Gen0 |   Gen1 |   Gen2 | Allocated |
|----------------------------------------------------|----------|----------|------------:|------------:|------------:|---------------------:|-----------------:|-----------:|-------:|-------:|-------:|----------:|
| System_Runtime_Serialization_DeserializeUnmarshall | .NET 8.0 | .NET 8.0 |          NA |          NA |          NA |                   NA |               NA |         NA |     NA |     NA |     NA |        NA |
| System_Runtime_Serialization_SerializeMarshall     | .NET 8.0 | .NET 8.0 |    642.9 ns |     7.01 ns |     6.56 ns |                    - |                - |          - | 0.7248 | 0.0029 |      - |   5.92 KB |
| System_Xml_Serialization_DeserializeUnmarshall     | .NET 8.0 | .NET 8.0 |  2,866.1 ns |    32.81 ns |    27.40 ns |                    - |                - |          - | 1.6327 | 0.0076 |      - |  13.37 KB |
| System_Xml_Serialization__SerializeMarshall        | .NET 8.0 | .NET 8.0 |  2,732.4 ns |    33.41 ns |    27.90 ns |                    - |                - |          - | 2.7237 | 0.0076 |      - |  22.31 KB |
| HolisticWare_YAXLib_DeserializeUnmarshall          | .NET 8.0 | .NET 8.0 | 18,762.0 ns |   304.42 ns |   284.75 ns |                    - |                - |          - | 4.6997 | 0.3662 | 0.1221 |  38.84 KB |
| HolisticWare_YAXLib_SerializeMarshall              | .NET 8.0 | .NET 8.0 | 19,832.7 ns |   369.12 ns |   362.52 ns |                    - |                - |          - | 5.0659 | 0.3662 | 0.1831 |  41.68 KB |
| YAXLib_DeserializeUnmarshall                       | .NET 8.0 | .NET 8.0 | 20,075.0 ns |   304.21 ns |   284.55 ns |                    - |                - |          - | 4.6997 | 0.3662 | 0.1221 |  38.76 KB |
| YAXLib_SerializeMarshall                           | .NET 8.0 | .NET 8.0 | 18,456.7 ns |   203.74 ns |   170.13 ns |                    - |                - |          - | 5.0659 | 0.3662 | 0.1831 |  41.68 KB |
| HolisticWare_NetBike_DeserializeUnmarshall         | .NET 8.0 | .NET 8.0 | 95,552.9 ns | 1,893.74 ns | 1,944.74 ns |                    - |                - |          - | 2.3193 | 1.0986 | 0.4883 |  19.36 KB |
| HolisticWare_NetBike_SerializeMarshall             | .NET 8.0 | .NET 8.0 | 60,780.2 ns | 1,191.03 ns | 1,114.09 ns |                    - |                - |          - | 2.5635 | 1.2207 | 0.3662 |  21.78 KB |
| NetBike_DeserializeUnmarshall                      | .NET 8.0 | .NET 8.0 | 94,267.7 ns | 1,714.40 ns | 2,168.17 ns |                    - |                - |          - | 2.3193 | 1.0986 | 0.4883 |  19.36 KB |
| NetBike_SerializeMarshall                          | .NET 8.0 | .NET 8.0 | 60,184.3 ns | 1,163.71 ns | 1,195.05 ns |                    - |                - |          - | 2.5635 | 1.2207 | 0.3662 |  21.78 KB |
| HolisticWare_NetBike_DeserializeUnmarshall         | .NET 9.0 | .NET 9.0 | 90,324.5 ns | 1,507.49 ns | 1,410.11 ns |                    - |                - |          - | 2.3193 | 1.0986 |      - |  19.33 KB |
| HolisticWare_NetBike_SerializeMarshall             | .NET 9.0 | .NET 9.0 | 55,020.8 ns |   837.75 ns |   742.64 ns |                    - |                - |          - | 2.5635 | 1.2207 |      - |  21.76 KB |
| HolisticWare_YAXLib_DeserializeUnmarshall          | .NET 9.0 | .NET 9.0 | 18,479.9 ns |   240.13 ns |   200.52 ns |                    - |                - |          - | 4.7607 | 0.3662 | 0.1221 |  38.85 KB |
| HolisticWare_YAXLib_SerializeMarshall              | .NET 9.0 | .NET 9.0 | 17,916.4 ns |   252.39 ns |   223.74 ns |                    - |                - |          - | 5.0659 | 0.3662 | 0.1221 |  41.78 KB |
| NetBike_DeserializeUnmarshall                      | .NET 9.0 | .NET 9.0 | 88,995.3 ns | 1,705.10 ns | 1,895.22 ns |                    - |                - |          - | 2.3193 | 1.0986 |      - |  19.33 KB |
| NetBike_SerializeMarshall                          | .NET 9.0 | .NET 9.0 | 55,099.3 ns |   908.82 ns |   850.11 ns |                    - |                - |          - | 2.5635 | 1.2207 |      - |  21.76 KB |
| System_Runtime_Serialization_DeserializeUnmarshall | .NET 9.0 | .NET 9.0 |          NA |          NA |          NA |                   NA |               NA |         NA |     NA |     NA |     NA |        NA |
| System_Runtime_Serialization_SerializeMarshall     | .NET 9.0 | .NET 9.0 |    661.1 ns |     5.42 ns |     5.07 ns |                    - |                - |          - | 0.7248 | 0.0038 |      - |   5.92 KB |
| System_Xml_Serialization_DeserializeUnmarshall     | .NET 9.0 | .NET 9.0 |  2,714.6 ns |    28.44 ns |    26.61 ns |                    - |                - |          - | 1.6327 | 0.0153 |      - |  13.37 KB |
| System_Xml_Serialization__SerializeMarshall        | .NET 9.0 | .NET 9.0 |  2,603.3 ns |    31.18 ns |    27.64 ns |                    - |                - |          - | 2.7237 | 0.0687 |      - |  22.31 KB |
| YAXLib_DeserializeUnmarshall                       | .NET 9.0 | .NET 9.0 | 18,022.6 ns |   315.07 ns |   279.30 ns |                    - |                - |          - | 4.6997 | 0.3662 | 0.1221 |  38.85 KB |
| YAXLib_SerializeMarshall                           | .NET 9.0 | .NET 9.0 | 18,082.2 ns |   277.85 ns |   232.02 ns |                    - |                - |          - | 5.0659 | 0.3662 | 0.1221 |  41.78 KB |
