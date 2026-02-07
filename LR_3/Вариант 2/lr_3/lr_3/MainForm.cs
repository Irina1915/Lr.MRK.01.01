using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr_3
{
    public partial class MainForm : Form
    {
        private Dictionary<string, List<Product>> products_ = new Dictionary<string, List<Product>>();

        public MainForm()
        {
            InitializeComponent();
            FotoPictureBox.Size = new Size(190, 270);
            FotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            products_.Add("Фрукты",
                new List<Product>()
                {
                    new Product ("Мандарины", 13.0, 5, 15, "4be19b3db8bb492ef1989c03eb1c47a6.jpg"),
                    new Product ("Гранаты", 25.0, 7, 13, "1000_F_700516778_Djx5jeOeRrXM1nRc2VEVx5FXDKHFm55w.jpg")
                }
            );

            products_.Add("Овощи",
                new List<Product>()
                {
                    new Product ("Огурцы", 8.0, 6, 34, "hXo3vOHzsW_small.jpg"),
                    new Product ("Помидоры", 3.0, 5, 12, "439cbe2e06118f2106ac5453f63b1b3c.jpg")
                }
            );

            products_.Add("Мясо",
                new List<Product>()
                {
                    new Product ("Курица", 20.0, 10, 35, "35064-ed4_big_wide.jpg"),
                    new Product ("Говядина", 13.0, 10, 10, "i2.jpg")
                }
            );


            List<string> allCategories = products_.Keys.ToList();
            ProductListBox.DataSource = allCategories;
        }

        private void ProductListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = ProductListBox.SelectedItem.ToString();
            List<Product> productSelectedCategory = products_[selectedCategory];

            ProductComboBox.DataSource= productSelectedCategory;
            ProductComboBox.DisplayMember = "Name";
        }

        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product selectedProduct = ProductComboBox.SelectedItem as Product;
            PriceLabel.Text = selectedProduct.Price;
            DataLabel.Text = selectedProduct.Data;
            labelKol_vo.Text = selectedProduct.Kol_vo;

            if (selectedProduct.Foto != null)
            {
                FotoPictureBox.Image = Image.FromFile(selectedProduct.Foto);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            TextRichBox.AppendText("Продукты из категории: " + ProductListBox.Text + ": " + ProductComboBox.Text + ", " + labelKol_vo.Text + " \n");
        }
    }
}
