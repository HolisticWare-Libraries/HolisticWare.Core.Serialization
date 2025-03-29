

double  somatotype_mesomorphic_double =    
                            0.858 * 8.1           // Excel D21
                            +
                            0.601 * 11.4          // Excel D22 
                            +
                            0.188 * 36.10         // Excel D25
                            +
                            0.161 * 43.60         // Excel D26
                            +
                            - 0.131 * 190         // Excel D12 
                            +
                            4.5
                            ;

Console.WriteLine($"double somatotype_mesomorphic_double = {somatotype_mesomorphic_double}");

float  somatotype_mesomorphic_float =    
                    (float)
                        (
                            0.858f * 8.1f           // Excel D21
                            +
                            0.601f * 11.4f          // Excel D22 
                            +
                            0.188f * 36.10f         // Excel D25
                            +
                            0.161f * 43.60f         // Excel D26
                            +
                            - 0.131f * 190f         // Excel D12 
                            +
                            4.5f
                        )
                        ;
Console.WriteLine($"float somatotype_mesomorphic_float = { somatotype_mesomorphic_float}");

decimal  somatotype_mesomorphic_decimal =    
                    (decimal)
                        (
                            0.858m * 8.1m           // Excel D21
                            +
                            0.601m * 11.4m          // Excel D22 
                            +
                            0.188m * 36.10m         // Excel D25
                            +
                            0.161m * 43.60m         // Excel D26
                            +
                            - 0.131m * 190m         // Excel D12 
                            +
                            4.5m
                        )
                        ;
Console.WriteLine($"float somatotype_mesomorphic_float = { somatotype_mesomorphic_float}");


// csi ./tests/interactive-shells/cscript-scriptcs/somatotype/unit-test-data-32.csx 
// somatotype_mesomorphic = 7.2176
