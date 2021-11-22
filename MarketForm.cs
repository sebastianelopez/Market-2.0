using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico4
{
    public partial class MarketForm : Form
    {

        private Market _market { get; }
        private Int64 _userId { get; }
        private User _currentUser { get; }
        private List<Product> _products { get; }
        private List<Category> _categories { get; }
        private Cart _cart { get; }

        private DataTable dt;
        public MarketForm(Market market, Int64 userId)
        {
            InitializeComponent();

            _market = market;            
            _userId = userId;
            _currentUser = _market.SearchUser(_userId);            
            _cart = _currentUser.cart; 
            _categories = market.SearchCategories();
            _products = market.SearchProducts();
            
            dt = new DataTable();
                        
            dt.Columns.Add("ID");
            dt.Columns.Add("Nombre del producto");
            dt.Columns.Add("Precio");

            productsDataGridView.DataSource = dt;
            
        }
        
        private void productsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int64 productId = Int64.Parse(productsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            Console.WriteLine(productId);
            DetailProductForm DetailForm = new DetailProductForm(_market, productId);
            DetailForm.Show();
        }

        private void MarketForm_Load(object sender, EventArgs e)
        {
            //Cargar productos 

            if (_products != null)
            {
                foreach (Product product in _products)
                {
                    Int64 ID = product.id;
                    String name = product.name;
                    String price = product.price.ToString();
                    Int64 ammount = product.ammount;

                    if (ammount > 0)
                    {
                        DataRow row = dt.NewRow();

                        row["ID"] = ID;
                        row["Nombre del producto"] = name;
                        row["Precio"] = price;

                        dt.Rows.Add(row);
                    }
                }
            }

            if (_categories != null)
            {
                foreach (Category category in _categories)
                {

                    String name = category.name;

                    //Cargar categorias en ListBox
                    categoriesListBox.Items.Add(category.name);
                }
            }
            
            productsDataGridView.Sort(productsDataGridView.Columns["ID"], ListSortDirection.Ascending);

        }

        private void categoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (categoriesListBox.SelectedItem.ToString().Equals("Todos"))
            {
                dt.Rows.Clear();
                foreach (Product product in _products)
                {
                    Int64 ID = product.id;
                    String name = product.name;
                    String price = product.price.ToString();
                    Int64 ammount = product.ammount;

                    if (ammount > 0)
                    {
                        DataRow row = dt.NewRow();

                        row["ID"] = ID;
                        row["Nombre del producto"] = name;
                        row["Precio"] = price;

                        dt.Rows.Add(row);
                    }                   
                    
                }
            }
            else
            {
                dt.Rows.Clear();
                foreach (Product product in _products)
                {                    
                    if (product.category.name.Equals(categoriesListBox.SelectedItem.ToString()))
                    {
                        Int64 ID = product.id;
                        String name = product.name;
                        String price = product.price.ToString();
                        Int64 ammount = product.ammount;

                        if (ammount > 0)
                        {
                            DataRow row = dt.NewRow();

                            row["ID"] = ID;
                            row["Nombre del producto"] = name;
                            row["Precio"] = price;

                            dt.Rows.Add(row);
                        }
                    }                    
                }
            }
            productsDataGridView.Sort(productsDataGridView.Columns["ID"], ListSortDirection.Ascending);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text != "")
            {
                dt.Rows.Clear();
                foreach (Product product in _products)
                {
                    if (product.name.StartsWith(searchTextBox.Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        Int64 ID = product.id;
                        String name = product.name;
                        String price = product.price.ToString();
                        Int64 ammount = product.ammount;

                        if (ammount > 0)
                        {

                            DataRow row = dt.NewRow();

                            row["ID"] = ID;
                            row["Nombre del producto"] = name;
                            row["Precio"] = price;

                            dt.Rows.Add(row);
                        }
                    }
                }
            }
            productsDataGridView.Sort(productsDataGridView.Columns["ID"], ListSortDirection.Ascending);
        }

        private void productOrderButton_Click(object sender, EventArgs e)
        {
            productsDataGridView.Sort(productsDataGridView.Columns["Nombre del producto"], ListSortDirection.Ascending);
        }

        private void PriceOrderButton_Click(object sender, EventArgs e)
        {
            productsDataGridView.Sort(productsDataGridView.Columns["Precio"], ListSortDirection.Ascending);
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {

            Int64 id = Int64.Parse(productsDataGridView.CurrentRow.Cells[0].Value.ToString());
            Product product = _market.SearchProduct(id);

            _cart.AddNewProduct(product);

            changeNumberOfCart();
            productsDataGridView.Sort(productsDataGridView.Columns["ID"], ListSortDirection.Ascending);
        }

        public void changeNumberOfCart()
        {
            cartLabel.Text = "("+_currentUser.cart.products.Count.ToString()+")";
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm(_market, _currentUser);
            cartForm.FormClosing += CartForm_FormClosing;
            cartForm.VisibleChanged += CartForm_VisibleChanged;
            cartForm.Show();
            
        }

        private void CartForm_FormClosing(object sender, EventArgs e)
        {
            _currentUser.cart.products.Clear();
            changeNumberOfCart();
        }

        private void CartForm_VisibleChanged(object sender, EventArgs e)
        {
                changeNumberOfCart();            
        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
