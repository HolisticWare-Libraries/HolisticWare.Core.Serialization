

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
Console.WriteLine($"float somatotype_mesomorphic_float = { somatotype_mesomorphic_float}");



// csi ./tests/interactive-shells/cscript-scriptcs/somatotype/unit-test-data-32.csx 
// somatotype_mesomorphic = 7.2176
