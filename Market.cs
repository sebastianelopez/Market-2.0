using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace TrabajoPractico4
{
    public class Market
    {
             
        private MyContext context;
        private DbSet<User> users;
        private DbSet<Category> categories;
        private DbSet<Product> products;        
        private DbSet<Purchase> purchases;
        private List<Cart> carts;


        public Market()
        {
            carts = new List<Cart>();            
            initializeAttributes();            
        }

        public void initializeAttributes()
        {
            try
            {
                //creo un contexto
                context = new MyContext();

                //cargo las entidades
                context.users.Load();
                users = context.users;

                context.Products.Load();
                products = context.Products;

                context.Categories.Load();
                categories = context.Categories;

                context.Carts.Load();
                carts = context.Carts;

                context.Purchases.Load();
                purchases = context.Purchases;

                User user = users.Where(u => u.userId == 1).FirstOrDefault();
                //Genero usuario admin para poder ingresar a los ABM
                if (user == null) AddUser(45452154154,"Admin", "admin@gmail.com","sda", 20386224235, "123456", "admin");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public bool AddProduct(String name, double price, String description, int ammount, int categoryId)
        {
            try
            {
                Category category = categories.Where(c => c.id == categoryId).FirstOrDefault();

                if (category == null ) return false;

                Product newProd = new Product(name, price, description, ammount, categoryId);                
                products.Add(newProd);
                products.Update(newProd);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool ModifyProduct(Product product)
        {
            try
            {
                
                if (product != null)
                {                    
                    products.Update(product);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }            

        public void UpdatePurchasesOnSystem()
        {
          /*  string connectionString = Properties.Resources.ConnectionString;

            string queryPurchasesString = "SELECT * from [dbo].[Purchase];";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryPurchasesString, connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    Purchase aux;

                    while (reader.Read())
                    {
                        List<Product> products = getProductsByPurchase(reader.GetInt32(0), connectionString);
                        Console.WriteLine(products);
                        aux = new Purchase(reader.GetInt32(0), reader.GetDouble(1), SearchUser(reader.GetInt32(2)), products);
                        purchases.Add(aux);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }*/
        }        

       private void UpdateProductsOnSystem()
        {
           /* products.Clear();

            string connectionString = Properties.Resources.ConnectionString;
            //Cargar Productos                        
            string queryProductsString = "SELECT * from [dbo].[Product];";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryProductsString, connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    Product aux;

                    while (reader.Read())
                    {
                        Category auxcategory = SearchCategory(reader.GetInt32(5));
                        aux = new Product(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetString(3), reader.GetInt32(4), auxcategory);
                        products.Add(aux);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }*/
        }

        public void ModifyStockOfProduct(Product product)
        {
           /* try
            {
                string connectionString = Properties.Resources.ConnectionString;
                string queryString = "UPDATE [dbo].[Product] SET ammount=@ammount WHERE productId=@productId;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);

                    command.Parameters.Add(new SqlParameter("@ammount", SqlDbType.Int));
                    command.Parameters.Add(new SqlParameter("@productId", SqlDbType.Int));
                                        
                    command.Parameters["@productId"].Value = product.id;
                    Product productOnSystem = SearchProduct(product.id);
                    productOnSystem.ammount -=1;
                    command.Parameters["@ammount"].Value = productOnSystem.ammount;
                    

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        products.Remove(product);
                        products.Add(productOnSystem);
                        UpdateProductsOnSystem();
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);                        
                    }
                    
                } 

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
               
            }*/

        }

        private List<Product> getProductsByPurchase(int purchaseId, String connectionString)
        {
           /* string queryProductsByPurchaseString = "SELECT p.* from dbo.Product p INNER JOIN Purchase_Product pp ON p.productId = pp.productId WHERE pp.purchaseId = @purchaseId;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryProductsByPurchaseString, connection);

                command.Parameters.Add(new SqlParameter("@purchaseId", SqlDbType.Int));                

                command.Parameters["@purchaseId"].Value = purchaseId;

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    List<Product> auxProducts= new List<Product>();

                    while (reader.Read())
                    {
                        Category auxcategory = SearchCategory(reader.GetInt32(5));                        
                        Product aux = new Product(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetString(3), reader.GetInt32(4), auxcategory);
                        auxProducts.Add(aux);
                    }
                    reader.Close();

                    return auxProducts;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }*/
        }

        public bool DeleteProduct(int productId)
        {
            try
            {
                Product prod = SearchProduct(productId);
                if (prod != null)
                {
                    products.Remove(prod);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }            

        public List<Product> SearchProducts() 
        {
            try
            {          
                return products;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public List<Cart> SearchCarts()
        {
            try
            {                
                return carts;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }
        public Product SearchProduct(Int64 productId)
        {
            try
            {
                //buscamos dentro de la lista el obj que contenga el mismo id 
                Product matchingProduct = products.Where(product => product.id == productId).First();
                
                return matchingProduct;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public Product SearchProductByName(String productName)
        {
            try
            {
                //buscamos dentro de la lista el obj que contenga el mismo id 
                Product matchingProduct = products.Where(product => product.name == productName).First();

                return matchingProduct;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
                
        public User SearchUser(Int64 userId) 
        {
            try
            {
                //buscamos dentro de la lista el obj que contenga el mismo id 
                User User = users.Where(user => user.id == userId).First();
                return User;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        

        public User SearchUserByCUIT(Int64 userCUITCUIL)
        {
            try
            {
                //buscamos dentro de la lista el obj que contenga el mismo CUITCUIL 
                User User = users.Where(user => user.CUITCUIL == userCUITCUIL).First();
                return User;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public User SearchUserByDni(Int64 userDni)
        {
            try
            {
                //buscamos dentro de la lista el obj que contenga el mismo CUITCUIL 
                User User = users.Where(user => user.dni == userDni).First();
                return User;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public List<User> SearchUsers()
        {
            List<User> listUsers = new List<User>();
            foreach (User user in users)
            {
                listUsers.Add(user);
            }
            return listUsers;
        }
        public bool AddCategory(String name)
        {

            try
            {
                Category newCat = new Category(name );
                categories.Add(newCat);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
            
        public bool ModifyCategory(Category category) 
        {
            try
            {                
                if (category != null)
                {                    
                    categories.Update(category);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool DeleteCategory(int categoryId)
        {
            try
            {
                Category cat = SearchCategory(categoryId);

                if (cat != null)
                {                    
                    categories.Remove(cat);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public Category SearchCategory(int categoryId)
        {
            try
            {
                //buscamos dentro de la lista el obj que contenga el mismo id 
                Category Category = categories.Where(category => category.id == categoryId).First();
                return Category;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        
        public Category SearchCategoryByName(String categoryName)
        {
            try
            {
                //buscamos dentro de la lista el obj que contenga el mismo id 
                Category Category = categories.Where(category => category.name.Equals(categoryName)).First();
                return Category;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public List<Category> SearchCategories()
        {

            List<Category> listCategories = new List<Category>();
            foreach (Category category in categories)
            {
                listCategories.Add(category);
            }
            return listCategories;
        }

        public Cart SearchCart(Int64 cartId)
        {
            try
            {
                //buscamos dentro de la lista el obj que contenga el mismo id 
                Cart Cart = carts.Where(cart => cart.id == cartId).First();
                return Cart;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public bool AddToCart(String productId, int amount, Int64 userId)
        {
            return true;
        }

        public void RemoveFromCart(Int64 productId)
        {
            Product matchingProduct = products.Where(product => product.id == productId).First();
            products.Remove(matchingProduct);
        }
                

        public bool AddPurchase(double total, int userId, List<Product> products)
        {
            try
            {
                List<CartProduct> cartProducts = SearchCartProduct(cart);

                if (cartProducts == null) return false;

                Purchase purchase = new Purchase();
                purchases.Add(purchase);
                context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }


        public bool DeletePurchase(int purchaseId)
        {
            try
            {
                Purchase prch = SearchPurchase(purchaseId);

                if (prch != null)
                {
                    purchases.Remove(prch);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public Purchase SearchPurchase(Int64 purchaseId)
        {
            try
            {
                //buscamos dentro de la lista el obj que contenga el mismo id 
                Purchase Purchase = purchases.Where(purchase => purchase.id == purchaseId).First();
                return Purchase;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public List<Purchase> SearchPurchases()
        {
            List<Purchase> listPurchases = new List<Purchase>();
            foreach (Purchase purchase in purchases)
            {
                listPurchases.Add(purchase);
            }
            return listPurchases;
        }

        public List<Purchase> SearchCartProduct()
        {
            List<Purchase> listPurchases = new List<Purchase>();
            foreach (Purchase purchase in purchases)
            {
                listPurchases.Add(purchase);
            }
            return listPurchases;
        }

        public void AddUser(Int64 dni,String name,String lastName,String email,Int64 CUITCUIL,String password,String userType)
        {
    try
    {
        // Valido que no exista un usuario con ese DNI o CUIT_CUIL ya que deberian ser unicos para cada usuario
        bool newUser = users.Where(u => u.dni == dni || u.CUITCUIL == CUITCUIL).FirstOrDefault() != null;
        if (!newUser)
        {
            // Los administradores no tienen Carro de compras
            if (userType == "admin")
            {
                User admin = new User
                (                    
                    name,
                    email,
                    CUITCUIL,
                    password,
                    userType
                );

                users.Add(admin);
                context.SaveChanges();
                
            }
            else if(userType == "client")
            {
                Cart cart = new Cart(dni, new List<Product>);
                User user = new User(dni, name, lastName, email, CUITCUIL, password, userType, cart);                
                users.Add(user);
                carts.Add(cart);
                context.SaveChanges();
                
            }else if (userType == "company")
            {
                Cart cart = new Cart();
                User user = new User(name, email, CUITCUIL, password, userType, cart);
                users.Add(user);
                carts.Add(cart);
                context.SaveChanges();
            }
        }
        
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);        
    }
                  
            
        }

        
        public Int64 LogIn(Int64 CUITCUIL, String password)
        {

            User user = SearchUserByCUIT(CUITCUIL);

            if (user != null) { 
                if(user.password == password)
                {
                    Console.WriteLine(string.Format("{0} {1}", CUITCUIL, password));
                    return user.id;
                }
            }
            return -1;
        }
    }
}