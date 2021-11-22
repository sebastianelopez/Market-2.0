
namespace TrabajoPractico4
{
    partial class CartForm
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
            this.tittleCartLabel = new System.Windows.Forms.Label();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.cartProductsLabel = new System.Windows.Forms.Label();
            this.deleteSelectedProductsButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tittleCartLabel
            // 
            this.tittleCartLabel.AutoSize = true;
            this.tittleCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tittleCartLabel.Location = new System.Drawing.Point(170, 35);
            this.tittleCartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tittleCartLabel.Name = "tittleCartLabel";
            this.tittleCartLabel.Size = new System.Drawing.Size(103, 37);
            this.tittleCartLabel.TabIndex = 0;
            this.tittleCartLabel.Text = "Carro";
            // 
            // productsListBox
            // 
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.ItemHeight = 15;
            this.productsListBox.Location = new System.Drawing.Point(57, 127);
            this.productsListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(345, 229);
            this.productsListBox.TabIndex = 1;
            this.productsListBox.SelectedIndexChanged += new System.EventHandler(this.productsListBox_SelectedIndexChanged);
            // 
            // cartProductsLabel
            // 
            this.cartProductsLabel.AutoSize = true;
            this.cartProductsLabel.Location = new System.Drawing.Point(57, 105);
            this.cartProductsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cartProductsLabel.Name = "cartProductsLabel";
            this.cartProductsLabel.Size = new System.Drawing.Size(107, 15);
            this.cartProductsLabel.TabIndex = 2;
            this.cartProductsLabel.Text = "Productos en carro";
            // 
            // deleteSelectedProductsButton
            // 
            this.deleteSelectedProductsButton.Location = new System.Drawing.Point(219, 365);
            this.deleteSelectedProductsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteSelectedProductsButton.Name = "deleteSelectedProductsButton";
            this.deleteSelectedProductsButton.Size = new System.Drawing.Size(183, 42);
            this.deleteSelectedProductsButton.TabIndex = 3;
            this.deleteSelectedProductsButton.Text = "Eliminar productos seleccionados";
            this.deleteSelectedProductsButton.UseVisualStyleBackColor = true;
            this.deleteSelectedProductsButton.Click += new System.EventHandler(this.deleteSelectedProductsButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(227, 459);
            this.buyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(160, 46);
            this.buyButton.TabIndex = 4;
            this.buyButton.Text = "Comprar";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(61, 459);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(160, 46);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Volver";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.Location = new System.Drawing.Point(57, 378);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(133, 39);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "TOTAL";
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(468, 519);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.deleteSelectedProductsButton);
            this.Controls.Add(this.cartProductsLabel);
            this.Controls.Add(this.productsListBox);
            this.Controls.Add(this.tittleCartLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CartForm";
            this.Text = "Carro";
            this.Load += new System.EventHandler(this.CartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittleCartLabel;
        private System.Windows.Forms.ListBox productsListBox;
        private System.Windows.Forms.Label cartProductsLabel;
        private System.Windows.Forms.Button deleteSelectedProductsButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label totalLabel;

    }
}