/*
please provide code sample in C# for
   Newtonsoft.Json
serialization and deserialization
*/

using Newtonsoft.Json;
using System;

public class Product
{
   public string Name { get; set; }
   public DateTime ExpiryDate { get; set; }
   public decimal Price { get; set; }
   public string[] Sizes { get; set; }
}

public class Program
{
   public static void Main()
   {
      Product product = new Product
      {
         Name = "Apple",
         ExpiryDate = new DateTime(2024, 12, 28),
         Price = 3.99M,
         Sizes = new string[] { "Small", "Medium", "Large" }
      };

      string json = JsonConvert.SerializeObject(product, Formatting.Indented);
      Console.WriteLine(json);
      
      
      
      json = 
         @"{
            'Name': 'Apple',
            'ExpiryDate': '2024-12-28T00:00:00',
            'Price': 3.99,
            'Sizes': ['Small', 'Medium', 'Large']
        }";

      product = JsonConvert.DeserializeObject<Product>(json);
      Console.WriteLine($"Name: {product.Name}");
      Console.WriteLine($"Expiry Date: {product.ExpiryDate}");
      Console.WriteLine($"Price: {product.Price}");
      Console.WriteLine($"Sizes: {string.Join(", ", product.Sizes)}");   }
}
