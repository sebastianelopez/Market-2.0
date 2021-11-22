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
    public partial class RegisterForm : Form
    {
        private Market _market { get; }

        public RegisterForm(Market market)
        {
            _market = market;
            InitializeComponent();
            clientCheckBox.Checked = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (clientCheckBox.Checked == true)
            {
                companyCheckbox.Checked = false;
                lastNameTextBox.Visible = true;
                lastNameLabel.Visible = true;
                dniLabel.Visible = true;
                dniTextBox.Visible = true;
                cuitCuilLabel.Text = "Ingrese su CUIL";

            }
        }

        private void companyCheckbox_CheckedChanged(object sender, EventArgs e)
        {

            if (companyCheckbox.Checked == true) { 
                clientCheckBox.Checked = false;
                lastNameTextBox.Visible = false;
                lastNameLabel.Visible = false;
                dniLabel.Visible = false;
                dniTextBox.Visible = false;
                cuitCuilLabel.Text = "Ingrese su CUIT";
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try 
            {
                if (clientCheckBox.Checked == true)
                {
                    String name = nameTextBox.Text;
                    String lastName = lastNameTextBox.Text;
                    String email = emailTextBox.Text;
                    Int64 CUITCUIL = Int64.Parse(cuitCuilTextBox.Text);
                    String password = passwordTextBox.Text;
                    String userType = "client";
                    Int64 dni = Int64.Parse(dniTextBox.Text);

                    if (_market.SearchUserByCUIT(CUITCUIL)==null && _market.SearchUserByDni(dni)== null)
                    {
                        _market.RegisterClient(dni, name, lastName, email, CUITCUIL, password, userType);
                        MessageBox.Show("Usuario creado exitosamente!", "Genial!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ese usuario ya existe!", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }   
                    
                }
                else
                {
                    String name = nameTextBox.Text;
                    String email = emailTextBox.Text;
                    Int64 CUITCUIL = Int64.Parse(cuitCuilTextBox.Text);
                    String password = passwordTextBox.Text;
                    String userType = "company";

                    if (_market.SearchUserByCUIT(CUITCUIL) == null)
                    {
                        _market.RegisterCompany(name, email, CUITCUIL, password, userType);
                        MessageBox.Show("Usuario creado exitosamente!", "Genial!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ese usuario ya existe!", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("Uno o mas datos que ingreso no son correctos.", "Error en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Int64 createUserId()
        {
            List<User> users = _market.SearchUsers();


            Int64 id = 1;

            foreach (User user in users)
            {
                if (user.id == id)
                {
                    id++;
                }
            }

            return id;
        }

    }
}
