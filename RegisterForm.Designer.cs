
namespace TrabajoPractico4
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.registerTitleLabel = new System.Windows.Forms.Label();
            this.dniLabel = new System.Windows.Forms.Label();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cuitCuilLabel = new System.Windows.Forms.Label();
            this.cuitCuilTextBox = new System.Windows.Forms.TextBox();
            this.clientCheckBox = new System.Windows.Forms.CheckBox();
            this.companyCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // registerTitleLabel
            // 
            this.registerTitleLabel.AutoSize = true;
            this.registerTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerTitleLabel.Location = new System.Drawing.Point(178, 35);
            this.registerTitleLabel.Name = "registerTitleLabel";
            this.registerTitleLabel.Size = new System.Drawing.Size(408, 39);
            this.registerTitleLabel.TabIndex = 0;
            this.registerTitleLabel.Text = "Registrar nuevo usuario";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniLabel.Location = new System.Drawing.Point(410, 197);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(155, 13);
            this.dniLabel.TabIndex = 1;
            this.dniLabel.Text = "Ingrese su numero de DNI";
            // 
            // dniTextBox
            // 
            this.dniTextBox.Location = new System.Drawing.Point(413, 226);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(173, 20);
            this.dniTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese una contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(208, 285);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(169, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(209, 387);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(173, 23);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Registrarse";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(413, 387);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(173, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Volver";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(206, 132);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(111, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Ingrese su nombre";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(208, 159);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(410, 132);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(114, 13);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "Ingrese su apellido";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(413, 158);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(173, 20);
            this.lastNameTextBox.TabIndex = 10;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(205, 197);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(99, 13);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "Ingrese su email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(209, 226);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(168, 20);
            this.emailTextBox.TabIndex = 12;
            // 
            // cuitCuilLabel
            // 
            this.cuitCuilLabel.AutoSize = true;
            this.cuitCuilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuitCuilLabel.Location = new System.Drawing.Point(206, 315);
            this.cuitCuilLabel.Name = "cuitCuilLabel";
            this.cuitCuilLabel.Size = new System.Drawing.Size(98, 13);
            this.cuitCuilLabel.TabIndex = 13;
            this.cuitCuilLabel.Text = "Ingrese su CUIL";
            // 
            // cuitCuilTextBox
            // 
            this.cuitCuilTextBox.Location = new System.Drawing.Point(208, 341);
            this.cuitCuilTextBox.Name = "cuitCuilTextBox";
            this.cuitCuilTextBox.Size = new System.Drawing.Size(168, 20);
            this.cuitCuilTextBox.TabIndex = 14;
            // 
            // clientCheckBox
            // 
            this.clientCheckBox.AutoSize = true;
            this.clientCheckBox.Location = new System.Drawing.Point(318, 102);
            this.clientCheckBox.Name = "clientCheckBox";
            this.clientCheckBox.Size = new System.Drawing.Size(58, 17);
            this.clientCheckBox.TabIndex = 15;
            this.clientCheckBox.Text = "Cliente";
            this.clientCheckBox.UseVisualStyleBackColor = true;
            this.clientCheckBox.CheckedChanged += new System.EventHandler(this.clientCheckBox_CheckedChanged);
            // 
            // companyCheckbox
            // 
            this.companyCheckbox.AutoSize = true;
            this.companyCheckbox.Location = new System.Drawing.Point(449, 102);
            this.companyCheckbox.Name = "companyCheckbox";
            this.companyCheckbox.Size = new System.Drawing.Size(67, 17);
            this.companyCheckbox.TabIndex = 16;
            this.companyCheckbox.Text = "Empresa";
            this.companyCheckbox.UseVisualStyleBackColor = true;
            this.companyCheckbox.CheckedChanged += new System.EventHandler(this.companyCheckbox_CheckedChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.companyCheckbox);
            this.Controls.Add(this.clientCheckBox);
            this.Controls.Add(this.cuitCuilTextBox);
            this.Controls.Add(this.cuitCuilLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dniTextBox);
            this.Controls.Add(this.dniLabel);
            this.Controls.Add(this.registerTitleLabel);
            this.Name = "RegisterForm";
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerTitleLabel;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label cuitCuilLabel;
        private System.Windows.Forms.TextBox cuitCuilTextBox;
        private System.Windows.Forms.CheckBox clientCheckBox;
        private System.Windows.Forms.CheckBox companyCheckbox;
    }
}