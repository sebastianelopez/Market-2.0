
namespace TrabajoPractico4
{
    partial class MarketForm
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.productOrderButton = new System.Windows.Forms.Button();
            this.PriceOrderButton = new System.Windows.Forms.Button();
            this.CartButton = new System.Windows.Forms.Button();
            this.cartLabel = new System.Windows.Forms.Label();
            this.categoriesListBox = new System.Windows.Forms.ListBox();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(441, 105);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(159, 23);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(608, 103);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(117, 27);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Buscar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Location = new System.Drawing.Point(224, 51);
            this.OrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(74, 15);
            this.OrderLabel.TabIndex = 3;
            this.OrderLabel.Text = "Ordenar por:";
            // 
            // productOrderButton
            // 
            this.productOrderButton.Location = new System.Drawing.Point(308, 29);
            this.productOrderButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productOrderButton.Name = "productOrderButton";
            this.productOrderButton.Size = new System.Drawing.Size(88, 27);
            this.productOrderButton.TabIndex = 4;
            this.productOrderButton.Text = "Producto";
            this.productOrderButton.UseVisualStyleBackColor = true;
            this.productOrderButton.Click += new System.EventHandler(this.productOrderButton_Click);
            // 
            // PriceOrderButton
            // 
            this.PriceOrderButton.Location = new System.Drawing.Point(308, 63);
            this.PriceOrderButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PriceOrderButton.Name = "PriceOrderButton";
            this.PriceOrderButton.Size = new System.Drawing.Size(88, 27);
            this.PriceOrderButton.TabIndex = 5;
            this.PriceOrderButton.Text = "Precio";
            this.PriceOrderButton.UseVisualStyleBackColor = true;
            this.PriceOrderButton.Click += new System.EventHandler(this.PriceOrderButton_Click);
            // 
            // CartButton
            // 
            this.CartButton.Location = new System.Drawing.Point(803, 14);
            this.CartButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CartButton.Name = "CartButton";
            this.CartButton.Size = new System.Drawing.Size(64, 45);
            this.CartButton.TabIndex = 6;
            this.CartButton.Text = "Carro";
            this.CartButton.UseVisualStyleBackColor = true;
            this.CartButton.Click += new System.EventHandler(this.CartButton_Click);
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Location = new System.Drawing.Point(874, 29);
            this.cartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(21, 15);
            this.cartLabel.TabIndex = 7;
            this.cartLabel.Text = "(0)";
            // 
            // categoriesListBox
            // 
            this.categoriesListBox.FormattingEnabled = true;
            this.categoriesListBox.ItemHeight = 15;
            this.categoriesListBox.Location = new System.Drawing.Point(19, 138);
            this.categoriesListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.categoriesListBox.Name = "categoriesListBox";
            this.categoriesListBox.Size = new System.Drawing.Size(185, 364);
            this.categoriesListBox.TabIndex = 8;
            this.categoriesListBox.SelectedIndexChanged += new System.EventHandler(this.categoriesListBox_SelectedIndexChanged);
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Location = new System.Drawing.Point(15, 114);
            this.categoriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(63, 15);
            this.categoriesLabel.TabIndex = 9;
            this.categoriesLabel.Text = "Categorias";
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(784, 105);
            this.addToCartButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(135, 27);
            this.addToCartButton.TabIndex = 10;
            this.addToCartButton.Text = "Agregar al carro";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(244, 138);
            this.productsDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 51;
            this.productsDataGridView.Size = new System.Drawing.Size(676, 365);
            this.productsDataGridView.TabIndex = 11;
            this.productsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellContentClick);
            this.productsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellDoubleClick);
            // 
            // MarketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.categoriesLabel);
            this.Controls.Add(this.categoriesListBox);
            this.Controls.Add(this.cartLabel);
            this.Controls.Add(this.CartButton);
            this.Controls.Add(this.PriceOrderButton);
            this.Controls.Add(this.productOrderButton);
            this.Controls.Add(this.OrderLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MarketForm";
            this.Text = "Market";
            this.Load += new System.EventHandler(this.MarketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Button productOrderButton;
        private System.Windows.Forms.Button PriceOrderButton;
        private System.Windows.Forms.Button CartButton;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.ListBox categoriesListBox;
        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.DataGridView productsDataGridView;
    }
}