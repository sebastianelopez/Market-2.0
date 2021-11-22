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
    public partial class AdminMarket : Form
    {

        private Market _market { get; }

        private DataTable dt;
        private DataTable dt2;
        private DataTable dt3;
        private Product _productActual;
        private Category _categoryActual;
        private Category _categoryActualForProduct;
        public AdminMarket(Market market)
        {
            
            InitializeComponent();

            _market = market;

            dt = new DataTable();
            dt2 = new DataTable();
            dt3 = new DataTable();            
            dt.Columns.Add("ID producto");
            dt.Columns.Add("Nombre del producto");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Categoria");

            dt2.Columns.Add("ID categoria");
            dt2.Columns.Add("Nombre de la categoria");

            dt3.Columns.Add("Id Compra");
            dt3.Columns.Add("Cliente");
            dt3.Columns.Add("Productos");
            dt3.Columns.Add("Importe Total");


            productsDataGridView.DataSource = dt;
            categoriesDataGridView.DataSource = dt2;
            purchasesDataGridView.DataSource = dt3;
        }

        private void ProductTab_Click(object sender, EventArgs e)
        {
            ProductNameTextBox.Text="";
            ProductPriceTextBox.Text="";
            ProductDescriptionTextBox.Text = "";
            ProductAmmountTextBox.Text="";
            CategoryListBox.ClearSelected();
            AddProductButton.Enabled = true;
            ModifyProductButton.Enabled = false;
            RemoveProductButton.Enabled = false;
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                double myNumDouble = 0.0;
                Int64 myNumInt = 0;
                if (!Double.TryParse(ProductPriceTextBox.Text, out myNumDouble))
                {
                    MessageBox.Show("El precio debe ser un valor numerico.", "Error en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Int64.TryParse(ProductAmmountTextBox.Text, out myNumInt))
                {
                    MessageBox.Show("La cantidad debe ser un valor numerico.", "Error en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else if (CategoryListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una categoria para el producto.", "Error en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    String ProductName = ProductNameTextBox.Text;
                    double ProductPrice = double.Parse(ProductPriceTextBox.Text);
                    String ProductDescription = ProductDescriptionTextBox.Text;
                    int ProductAmmount = int.Parse(ProductAmmountTextBox.Text);
                    String CategoryName = CategoryListBox.SelectedItem.ToString();

                    if (ProductName == string.Empty || ProductPrice == 0.0 || ProductPrice == null || ProductDescription == string.Empty || ProductAmmount == null || CategoryName == string.Empty || CategoryName == null)
                    {
                        MessageBox.Show("Falta ingresar datos.", "Error en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Category Category = new Category(CategoryName);
                                                

                        _market.AddProduct(ProductName, ProductPrice, ProductDescription, ProductAmmount, Category.id);

                        UpdateProductsOnForm();
                        CleanProductTextBoxs();
                    }
                }
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc);
            }

        }

        private void AdminMarket_Load(object sender, EventArgs e)
        {
            //Cargar productos
            List<Category> categories = _market.SearchCategories();
            List<Product> products = _market.SearchProducts();
            List<Purchase> purchases = _market.SearchPurchases();

            if (products != null)
            {
                foreach (Product product in products)
                {
                    Int64 ID = product.id;
                    String name = product.name;
                    String price = product.price.ToString();
                    String description = product.description;
                    String ammount = product.ammount.ToString();
                    String category = product.category.name;

                    DataRow row = dt.NewRow();

                    row["ID producto"] = ID;
                    row["Nombre del producto"] = name;
                    row["Precio"] = price;
                    row["Descripcion"] = description;
                    row["Cantidad"] = ammount;
                    row["Categoria"] = category;

                    dt.Rows.Add(row);
                }
            }

            if (categories != null)
            {

                foreach (Category category in categories)
                {
                    String id = category.id.ToString();
                    String name = category.name;

                    if (category.name != "Todos")
                    {
                        DataRow row = dt2.NewRow();

                    row["ID categoria"] = id;
                    row["Nombre de la categoria"] = name;

                    dt2.Rows.Add(row);
                    
                        //Cargar categorias en ListBox
                        CategoryListBox.Items.Add(category.name);
                    }

                }
            }
            if (purchases != null)
            {

                foreach (Purchase purchase in purchases)
                {
                    Int64 id = purchase.id;
                    Double total = purchase.total;
                    String productsOfPurchase = Purchase.parseProductsOfPurchaseToString(purchase.products);
                    String client = purchase.buyer.name;

                    DataRow row = dt3.NewRow();
                    row["Id Compra"] = id;
                    row["Cliente"] = client;
                    row["Productos"] = productsOfPurchase;
                    row["Importe Total"] = total;

                    dt3.Rows.Add(row);
                }
            }
            
            
            RemoveProductButton.Enabled = false;
            ModifyProductButton.Enabled = false;            
            ModifyCategoryButton.Enabled = false;
            RemoveCategoryButton.Enabled = false;
        }

        private void UpdateProductsOnForm()
        {

            dt.Rows.Clear();

            List<Product> products = _market.SearchProducts();

            foreach (Product product in products)
            {
                String id = product.id.ToString();
                String name = product.name;
                String price = product.price.ToString();
                String description = product.description;
                String ammount = product.ammount.ToString();
                String category = product.category.name;

                DataRow row = dt.NewRow();

                row["ID producto"] = id;
                row["Nombre del producto"] = name;
                row["Precio"] = price;
                row["Descripcion"] = description;
                row["Cantidad"] = ammount;
                row["Categoria"] = category;

                dt.Rows.Add(row);
            }
        }

        private void UpdateProductsOnFormAtModify()
        {
            List<Product> products = _market.SearchProducts();

            dt.Rows.Clear();

            foreach (Product product in products)
            {
                String id = product.id.ToString();
                String name = product.name;
                String price = product.price.ToString();
                String description = product.description;
                String ammount = product.ammount.ToString();
                String category = product.category.name;

                DataRow row = dt.NewRow();

                row["ID producto"] = id;
                row["Nombre del producto"] = name;
                row["Precio"] = price;
                row["Descripcion"] = description;
                row["Cantidad"] = ammount;
                row["Categoria"] = category;

                dt.Rows.Add(row);
            }           

        }

        private void UpdateCategoriesOnForm()
        {
            List<Category> categories = _market.SearchCategories();

            dt2.Rows.Clear();

            foreach (Category category in categories)
            {
                String id = category.id.ToString();
                String name = category.name;

                if (category.name != "Todos")
                {
                    DataRow row = dt2.NewRow();

                    row["ID categoria"] = id;
                    row["Nombre de la categoria"] = name;


                    dt2.Rows.Add(row);
                }
            }
            
        }

        private void UpdateCategoriesOnFormAtModify()
        {
            List<Category> categories = _market.SearchCategories();

            dt2.Rows.Clear();

            foreach (Category category in categories)
            {
                String id = category.id.ToString();
                String name = category.name;

                if (category.name != "Todos")
                {
                    DataRow row = dt2.NewRow();

                row["ID categoria"] = id;
                row["Nombre de la categoria"] = name;

                
                    dt2.Rows.Add(row);
                }
            }
            
        }

        private void CleanProductTextBoxs()
        {
            ProductNameTextBox.Text = "";
            ProductPriceTextBox.Text= "";
            ProductDescriptionTextBox.Text = "";
            ProductAmmountTextBox.Text = "";
            CategoryListBox.ClearSelected();
        }

        private void CleanCategoryTextBox()
        {
            CategoryNameTextBox.Text = "";            
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                    _market.DeleteProduct(_productActual.id);

                    UpdateProductsOnFormAtModify();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                String CategoryName = CategoryNameTextBox.Text;

                if (CategoryName == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos", "Error en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {                    
                    _market.AddCategory(CategoryName);
                    UpdateCategoriesOnForm();                    
                    CleanCategoryTextBox();
                    UpdateCategoryOnProductsFormAtModify(); 
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }

        private void UpdateCategoryOnProductsFormAtModify()
        {
            CategoryListBox.Items.Clear();
            List<Category> categories = _market.SearchCategories();
            foreach (Category category in categories)
            {
                CategoryListBox.Items.Add(category.name);
            }            
        }


        private void productsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ModifyProductButton.Enabled = true;
                AddProductButton.Enabled = false;
                RemoveProductButton.Enabled = true;

                Int64 productId = Int64.Parse(productsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

                _productActual = _market.SearchProduct(productId);
                _categoryActualForProduct = _market.SearchCategory(_productActual.category.id);


                String name = _productActual.name;
                String price = _productActual.price.ToString();
                String description = _productActual.description;
                String ammount = _productActual.ammount.ToString();
                String category = _productActual.category.name;

                ProductNameTextBox.Text = name;
                ProductPriceTextBox.Text = price;
                ProductDescriptionTextBox.Text = description;
                ProductAmmountTextBox.Text = ammount;
                CategoryListBox.SelectedItem = category;
            }           
            
        }

        private void ModifyProductButton_Click(object sender, EventArgs e)
        {

            try
            {
                int ProductId = _productActual.id;
                String ProductName = ProductNameTextBox.Text;
                double ProductPrice = double.Parse(ProductPriceTextBox.Text);
                String ProductDescription = ProductDescriptionTextBox.Text;
                int ProductAmmount = int.Parse(ProductAmmountTextBox.Text);
                String CategoryName = CategoryListBox.SelectedItem.ToString();

                if (ProductName == string.Empty || ProductPrice == 0.0 || ProductPrice == null || ProductDescription == string.Empty || ProductAmmount == 0 || ProductAmmount == null || CategoryName == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos", "Error en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Category Category = new Category(CategoryName);

                    Product product = new Product( ProductName, ProductPrice, ProductDescription, ProductAmmount, Category);

                    _market.ModifyProduct(product);

                    UpdateProductsOnFormAtModify();                    
                }

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }

        }

        private void RemoveCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                _market.DeleteCategory(_categoryActual.id);

                UpdateCategoriesOnFormAtModify();
                UpdateProductsOnFormAtModify();
                UpdateCategoryOnProductsFormAtModify();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }

        private void ModifyCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                String CategoryName = CategoryNameTextBox.Text;                

                if (CategoryName == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos", "Error en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Category Category = new Category(CategoryName);                    

                    _market.ModifyCategory(Category);

                    UpdateCategoriesOnFormAtModify();
                    UpdateProductsOnFormAtModify();
                    UpdateCategoryOnProductsFormAtModify();
                }

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }

        private void categoriesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                AddCategoryButton.Enabled = false;
                ModifyCategoryButton.Enabled = true;
                RemoveCategoryButton.Enabled = true;

                int categoryId = int.Parse(categoriesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

                _categoryActual = _market.SearchCategory(categoryId);

                String name = _categoryActual.name;

                CategoryNameTextBox.Text = name;
            }
        }

        private void AdminMarket_Click(object sender, EventArgs e)
        {
            CategoryNameTextBox.Text = "";
            AddCategoryButton.Enabled = true;
            ModifyCategoryButton.Enabled = false;
            RemoveCategoryButton.Enabled = false;
        }

        private void CategoryTab_Click(object sender, EventArgs e)
        {
            CategoryNameTextBox.Text = "";
            AddCategoryButton.Enabled = true;
            ModifyCategoryButton.Enabled = false;
            RemoveCategoryButton.Enabled = false;
        }
    }
}
