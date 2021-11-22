
namespace TrabajoPractico4
{
    partial class AdminMarket
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
            this.AdminMarketTabs = new System.Windows.Forms.TabControl();
            this.ProductTab = new System.Windows.Forms.TabPage();
            this.ModifyProductButton = new System.Windows.Forms.Button();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ProductDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.RemoveProductButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ProductCategoryLabel = new System.Windows.Forms.Label();
            this.ProductAmmountTextBox = new System.Windows.Forms.TextBox();
            this.ProductAmmountLabel = new System.Windows.Forms.Label();
            this.ProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.CategoryTab = new System.Windows.Forms.TabPage();
            this.ModifyCategoryButton = new System.Windows.Forms.Button();
            this.categoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.RemoveCategoryButton = new System.Windows.Forms.Button();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            this.PurchasesTab = new System.Windows.Forms.TabPage();
            this.purchasesDataGridView = new System.Windows.Forms.DataGridView();
            this.AdminMarketTabs.SuspendLayout();
            this.ProductTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.CategoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).BeginInit();
            this.PurchasesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminMarketTabs
            // 
            this.AdminMarketTabs.Controls.Add(this.ProductTab);
            this.AdminMarketTabs.Controls.Add(this.CategoryTab);
            this.AdminMarketTabs.Controls.Add(this.PurchasesTab);
            this.AdminMarketTabs.Location = new System.Drawing.Point(13, 13);
            this.AdminMarketTabs.Name = "AdminMarketTabs";
            this.AdminMarketTabs.SelectedIndex = 0;
            this.AdminMarketTabs.Size = new System.Drawing.Size(775, 425);
            this.AdminMarketTabs.TabIndex = 0;
            // 
            // ProductTab
            // 
            this.ProductTab.BackColor = System.Drawing.Color.LightGray;
            this.ProductTab.Controls.Add(this.ModifyProductButton);
            this.ProductTab.Controls.Add(this.CategoryListBox);
            this.ProductTab.Controls.Add(this.productsDataGridView);
            this.ProductTab.Controls.Add(this.DescriptionLabel);
            this.ProductTab.Controls.Add(this.ProductDescriptionTextBox);
            this.ProductTab.Controls.Add(this.RemoveProductButton);
            this.ProductTab.Controls.Add(this.AddProductButton);
            this.ProductTab.Controls.Add(this.ProductCategoryLabel);
            this.ProductTab.Controls.Add(this.ProductAmmountTextBox);
            this.ProductTab.Controls.Add(this.ProductAmmountLabel);
            this.ProductTab.Controls.Add(this.ProductPriceTextBox);
            this.ProductTab.Controls.Add(this.ProductPriceLabel);
            this.ProductTab.Controls.Add(this.ProductNameTextBox);
            this.ProductTab.Controls.Add(this.ProductNameLabel);
            this.ProductTab.Location = new System.Drawing.Point(4, 22);
            this.ProductTab.Name = "ProductTab";
            this.ProductTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductTab.Size = new System.Drawing.Size(767, 399);
            this.ProductTab.TabIndex = 0;
            this.ProductTab.Text = "Productos";
            this.ProductTab.Click += new System.EventHandler(this.ProductTab_Click);
            // 
            // ModifyProductButton
            // 
            this.ModifyProductButton.Location = new System.Drawing.Point(649, 81);
            this.ModifyProductButton.Name = "ModifyProductButton";
            this.ModifyProductButton.Size = new System.Drawing.Size(103, 23);
            this.ModifyProductButton.TabIndex = 15;
            this.ModifyProductButton.Text = "Modificar";
            this.ModifyProductButton.UseVisualStyleBackColor = true;
            this.ModifyProductButton.Click += new System.EventHandler(this.ModifyProductButton_Click);
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.Location = new System.Drawing.Point(471, 24);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(105, 69);
            this.CategoryListBox.TabIndex = 14;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.AllowUserToResizeColumns = false;
            this.productsDataGridView.AllowUserToResizeRows = false;
            this.productsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.productsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(13, 119);
            this.productsDataGridView.MultiSelect = false;
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.Size = new System.Drawing.Size(739, 274);
            this.productsDataGridView.TabIndex = 13;
            this.productsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellClick);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(10, 51);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(125, 13);
            this.DescriptionLabel.TabIndex = 11;
            this.DescriptionLabel.Text = "Descripcion del producto";
            // 
            // ProductDescriptionTextBox
            // 
            this.ProductDescriptionTextBox.Location = new System.Drawing.Point(10, 70);
            this.ProductDescriptionTextBox.Name = "ProductDescriptionTextBox";
            this.ProductDescriptionTextBox.Size = new System.Drawing.Size(414, 20);
            this.ProductDescriptionTextBox.TabIndex = 10;
            // 
            // RemoveProductButton
            // 
            this.RemoveProductButton.Location = new System.Drawing.Point(649, 51);
            this.RemoveProductButton.Name = "RemoveProductButton";
            this.RemoveProductButton.Size = new System.Drawing.Size(103, 23);
            this.RemoveProductButton.TabIndex = 9;
            this.RemoveProductButton.Text = "Remover";
            this.RemoveProductButton.UseVisualStyleBackColor = true;
            this.RemoveProductButton.Click += new System.EventHandler(this.RemoveProductButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(649, 21);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(103, 23);
            this.AddProductButton.TabIndex = 8;
            this.AddProductButton.Text = "Agregar";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ProductCategoryLabel
            // 
            this.ProductCategoryLabel.AutoSize = true;
            this.ProductCategoryLabel.Location = new System.Drawing.Point(468, 7);
            this.ProductCategoryLabel.Name = "ProductCategoryLabel";
            this.ProductCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.ProductCategoryLabel.TabIndex = 7;
            this.ProductCategoryLabel.Text = "Categoria";
            // 
            // ProductAmmountTextBox
            // 
            this.ProductAmmountTextBox.Location = new System.Drawing.Point(324, 24);
            this.ProductAmmountTextBox.Name = "ProductAmmountTextBox";
            this.ProductAmmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductAmmountTextBox.TabIndex = 6;
            // 
            // ProductAmmountLabel
            // 
            this.ProductAmmountLabel.AutoSize = true;
            this.ProductAmmountLabel.Location = new System.Drawing.Point(321, 7);
            this.ProductAmmountLabel.Name = "ProductAmmountLabel";
            this.ProductAmmountLabel.Size = new System.Drawing.Size(49, 13);
            this.ProductAmmountLabel.TabIndex = 5;
            this.ProductAmmountLabel.Text = "Cantidad";
            // 
            // ProductPriceTextBox
            // 
            this.ProductPriceTextBox.Location = new System.Drawing.Point(190, 24);
            this.ProductPriceTextBox.Name = "ProductPriceTextBox";
            this.ProductPriceTextBox.Size = new System.Drawing.Size(108, 20);
            this.ProductPriceTextBox.TabIndex = 4;
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Location = new System.Drawing.Point(187, 7);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(37, 13);
            this.ProductPriceLabel.TabIndex = 3;
            this.ProductPriceLabel.Text = "Precio";
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(10, 24);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(148, 20);
            this.ProductNameTextBox.TabIndex = 2;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(7, 7);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(106, 13);
            this.ProductNameLabel.TabIndex = 1;
            this.ProductNameLabel.Text = "Nombre del producto";
            // 
            // CategoryTab
            // 
            this.CategoryTab.BackColor = System.Drawing.Color.LightGray;
            this.CategoryTab.Controls.Add(this.ModifyCategoryButton);
            this.CategoryTab.Controls.Add(this.categoriesDataGridView);
            this.CategoryTab.Controls.Add(this.RemoveCategoryButton);
            this.CategoryTab.Controls.Add(this.AddCategoryButton);
            this.CategoryTab.Controls.Add(this.CategoryNameTextBox);
            this.CategoryTab.Controls.Add(this.CategoryNameLabel);
            this.CategoryTab.Location = new System.Drawing.Point(4, 22);
            this.CategoryTab.Name = "CategoryTab";
            this.CategoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.CategoryTab.Size = new System.Drawing.Size(767, 399);
            this.CategoryTab.TabIndex = 1;
            this.CategoryTab.Text = "Categorias";
            this.CategoryTab.Click += new System.EventHandler(this.CategoryTab_Click);
            // 
            // ModifyCategoryButton
            // 
            this.ModifyCategoryButton.Location = new System.Drawing.Point(447, 24);
            this.ModifyCategoryButton.Name = "ModifyCategoryButton";
            this.ModifyCategoryButton.Size = new System.Drawing.Size(103, 23);
            this.ModifyCategoryButton.TabIndex = 6;
            this.ModifyCategoryButton.Text = "Modificar";
            this.ModifyCategoryButton.UseVisualStyleBackColor = true;
            this.ModifyCategoryButton.Click += new System.EventHandler(this.ModifyCategoryButton_Click);
            // 
            // categoriesDataGridView
            // 
            this.categoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesDataGridView.Location = new System.Drawing.Point(10, 51);
            this.categoriesDataGridView.Name = "categoriesDataGridView";
            this.categoriesDataGridView.Size = new System.Drawing.Size(751, 342);
            this.categoriesDataGridView.TabIndex = 5;
            this.categoriesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriesDataGridView_CellClick);
            // 
            // RemoveCategoryButton
            // 
            this.RemoveCategoryButton.Location = new System.Drawing.Point(318, 24);
            this.RemoveCategoryButton.Name = "RemoveCategoryButton";
            this.RemoveCategoryButton.Size = new System.Drawing.Size(107, 23);
            this.RemoveCategoryButton.TabIndex = 4;
            this.RemoveCategoryButton.Text = "Remover";
            this.RemoveCategoryButton.UseVisualStyleBackColor = true;
            this.RemoveCategoryButton.Click += new System.EventHandler(this.RemoveCategoryButton_Click);
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Location = new System.Drawing.Point(197, 24);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(100, 23);
            this.AddCategoryButton.TabIndex = 3;
            this.AddCategoryButton.Text = "Agregar";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(10, 24);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(132, 20);
            this.CategoryNameTextBox.TabIndex = 1;
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.AutoSize = true;
            this.CategoryNameLabel.Location = new System.Drawing.Point(7, 7);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryNameLabel.TabIndex = 0;
            this.CategoryNameLabel.Text = "Categoria";
            // 
            // PurchasesTab
            // 
            this.PurchasesTab.Controls.Add(this.purchasesDataGridView);
            this.PurchasesTab.Location = new System.Drawing.Point(4, 22);
            this.PurchasesTab.Name = "PurchasesTab";
            this.PurchasesTab.Padding = new System.Windows.Forms.Padding(3);
            this.PurchasesTab.Size = new System.Drawing.Size(767, 399);
            this.PurchasesTab.TabIndex = 2;
            this.PurchasesTab.Text = "Compras";
            this.PurchasesTab.UseVisualStyleBackColor = true;
            // 
            // purchasesDataGridView
            // 
            this.purchasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasesDataGridView.Location = new System.Drawing.Point(7, 20);
            this.purchasesDataGridView.Name = "purchasesDataGridView";
            this.purchasesDataGridView.Size = new System.Drawing.Size(754, 373);
            this.purchasesDataGridView.TabIndex = 0;
            // 
            // AdminMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminMarketTabs);
            this.Name = "AdminMarket";
            this.Text = "Admin Market";
            this.Load += new System.EventHandler(this.AdminMarket_Load);
            this.Click += new System.EventHandler(this.AdminMarket_Click);
            this.AdminMarketTabs.ResumeLayout(false);
            this.ProductTab.ResumeLayout(false);
            this.ProductTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.CategoryTab.ResumeLayout(false);
            this.CategoryTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).EndInit();
            this.PurchasesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AdminMarketTabs;
        private System.Windows.Forms.TabPage ProductTab;
        private System.Windows.Forms.TabPage CategoryTab;
        private System.Windows.Forms.Label ProductCategoryLabel;
        private System.Windows.Forms.TextBox ProductAmmountTextBox;
        private System.Windows.Forms.Label ProductAmmountLabel;
        private System.Windows.Forms.TextBox ProductPriceTextBox;
        private System.Windows.Forms.Label ProductPriceLabel;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.Label CategoryNameLabel;
        private System.Windows.Forms.Button RemoveProductButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button RemoveCategoryButton;
        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox ProductDescriptionTextBox;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridView categoriesDataGridView;
        private System.Windows.Forms.ListBox CategoryListBox;
        private System.Windows.Forms.TabPage PurchasesTab;
        private System.Windows.Forms.DataGridView purchasesDataGridView;
        private System.Windows.Forms.Button ModifyProductButton;
        private System.Windows.Forms.Button ModifyCategoryButton;
    }
}