using System;

namespace ProductsMaintenance
{
    public class Product
    {
        // a constructor public Product() { }
        // three public properties
        public string Code { get; set; } = ""; 
        public string Description { get; set; } = ""; 
        public decimal Price { get; set; }

        //  No-Arg Constructor
        public Product() { }

        //  Full-Arg Constructor
        public Product(string c, string d, decimal p) 
        {
            Code = c;
            Description = d;
            Price = p;
        }

        // a public method
        public string GetDisplayText(string sep) => 
            $"{Code}{sep}{Price.ToString("c")}{sep}{Description}";
    }
}
