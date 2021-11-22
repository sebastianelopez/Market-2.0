using System;
using System.Windows.Forms;

namespace TrabajoPractico4
{
    public partial class LoginForm : Form
    {
        private Market _market { get; }

        public LoginForm(Market market)
        {
            _market = market;
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                Int64 user = Int64.Parse(userTextBox.Text);
                
                String password = passwordTextBox.Text;

                var login=_market.LogIn(user, password);

                if (login >= 0)
                {
                    User userTemp=_market.SearchUser(login);
                    // si es cliente o empresa
                    if (String.Equals(userTemp.userType, "client", StringComparison.OrdinalIgnoreCase) || String.Equals(userTemp.userType, "company", StringComparison.OrdinalIgnoreCase))
                        {
                            _market.initializeAttributes();
                            MarketForm Market = new MarketForm(_market, login);

                            Market.Show();                            
                        }
                        else //si es admin
                        {
                            _market.initializeAttributes();
                            AdminMarket AdminMarket = new AdminMarket(_market);
                            AdminMarket.Show();                            
                        }
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña que ingreso no es correcto.", "Error en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
            catch(Exception)
            {
                MessageBox.Show("El usuario no es valido, debe ingresar su cuit o cuil.", "Error en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm Register = new RegisterForm(_market); 
            Register.Show(); 
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
