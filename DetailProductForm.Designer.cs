
namespace TrabajoPractico4
{
    partial class DetailProductForm
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
            this.titleProductLabel = new System.Windows.Forms.Label();
            this.descProductLabel = new System.Windows.Forms.Label();
            this.priceProductLabel = new System.Windows.Forms.Label();
            this.coinLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleProductLabel
            // 
            this.titleProductLabel.AutoSize = true;
            this.titleProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleProductLabel.Location = new System.Drawing.Point(90, 27);
            this.titleProductLabel.Name = "titleProductLabel";
            this.titleProductLabel.Size = new System.Drawing.Size(146, 55);
            this.titleProductLabel.TabIndex = 0;
            this.titleProductLabel.Text = "Titulo";
            // 
            // descProductLabel
            // 
            this.descProductLabel.AutoSize = true;
            this.descProductLabel.Location = new System.Drawing.Point(13, 109);
            this.descProductLabel.Name = "descProductLabel";
            this.descProductLabel.Size = new System.Drawing.Size(125, 13);
            this.descProductLabel.TabIndex = 1;
            this.descProductLabel.Text = "Descripcion del producto";
            // 
            // priceProductLabel
            // 
            this.priceProductLabel.AutoSize = true;
            this.priceProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceProductLabel.Location = new System.Drawing.Point(102, 350);
            this.priceProductLabel.Name = "priceProductLabel";
            this.priceProductLabel.Size = new System.Drawing.Size(113, 37);
            this.priceProductLabel.TabIndex = 2;
            this.priceProductLabel.Text = "Precio";
            // 
            // coinLabel
            // 
            this.coinLabel.AutoSize = true;
            this.coinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinLabel.Location = new System.Drawing.Point(59, 350);
            this.coinLabel.Name = "coinLabel";
            this.coinLabel.Size = new System.Drawing.Size(37, 39);
            this.coinLabel.TabIndex = 3;
            this.coinLabel.Text = "$";
            // 
            // DetailProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(348, 450);
            this.Controls.Add(this.coinLabel);
            this.Controls.Add(this.priceProductLabel);
            this.Controls.Add(this.descProductLabel);
            this.Controls.Add(this.titleProductLabel);
            this.Name = "DetailProductForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DetailProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleProductLabel;
        private System.Windows.Forms.Label descProductLabel;
        private System.Windows.Forms.Label priceProductLabel;
        private System.Windows.Forms.Label coinLabel;
    }
}