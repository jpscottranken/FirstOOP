using System;
using System.Windows.Forms;

namespace ProductsMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Product product1 = new Product();
            MessageBox.Show(product1.GetDisplayText("\n"), "BEFORE INFO");
            product1.Code = "C#";
            product1.Description = "Murach's C#"; 
            product1.Price = 59.50m;
            MessageBox.Show(product1.GetDisplayText("\n"), "AFTER INFO");

            Product product2 = new Product("ASP.NET",
                                            "Murachs ASP.NET Programming",
                                            77.99m);
            MessageBox.Show(product2.GetDisplayText("\n"), "PRODUCT2");

        }
    }
}
