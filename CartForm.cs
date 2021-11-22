using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrabajoPractico4
{
    public partial class CartForm : Form
    {

        private Market _market { get; }        
        private User _currentUser { get; }
        private Cart _cart{ get; }
        private List<Product> _products { get; }
        private Purchase _purchase { get; set; }

        private double currentTotal;
        

        public CartForm(Market market, User currentUser)
        {
            InitializeComponent();

            _market = market;
            _currentUser = currentUser;
            _cart = _currentUser.cart;
            _products = _cart.products;
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            foreach (Product product in _products)
            {

                String name = product.name;
                Double price = product.price;

                productsListBox.Items.Add(name);

                currentTotal+=price;
            }
            changeCurrentTotal();
        }


        private void UpdateProductListBox()
        {
            productsListBox.Items.Clear();
            currentTotal = 0;

            foreach (Product product in _products)
            {

                String name = product.name;
                Double price = product.price;

                productsListBox.Items.Add(name);

                currentTotal += price;
            }
            changeCurrentTotal();
        }        

        private void changeCurrentTotal()
        {
            totalLabel.Text = currentTotal.ToString();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (_products.Count > 0)
            {
                _market.AddPurchase(currentTotal, _currentUser.userId, _products);


                foreach (Product product in _products)
                {
                    _market.ModifyStockOfProduct(product);
                }
                _market.UpdatePurchasesOnSystem();
                MessageBox.Show("Muchas gracias por su compra," + _currentUser.name + "!!" + "\n Usted compro: \n" + parsePurchaseProductsToString(_products) + "\n Por un total de: " + currentTotal, "Muchas gracias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No tiene productos en su carrito!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private String parsePurchaseProductsToString(List<Product> products)
        {
            String productName;
            String productList = "";

            foreach (Product product in products)
            {
                productName = product.name.ToString();
                productList += productName+"-";
            }

            return productList;
        }

        private void deleteSelectedProductsButton_Click(object sender, EventArgs e)
        {
            if (productsListBox.SelectedIndex != -1) //hay un item seleccionado o mas
            {
                String ProductName=productsListBox.SelectedItem.ToString();
                Product product= _market.SearchProductByName(ProductName);
                _currentUser.cart.products.Remove(product);
                productsListBox.Items.Remove(ProductName);
                UpdateProductListBox();                
            }
            else
            {
                MessageBox.Show("Debe seleccionar uno mas productos que desee eliminar.", "Atencion!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void productsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
