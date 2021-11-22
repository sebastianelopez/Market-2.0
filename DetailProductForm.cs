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
    public partial class DetailProductForm : Form
    {

        private Market _market { get; }

        private Int64 _productId { get; }
        public DetailProductForm(Market market, Int64 productId)
        {
            _market = market;
            _productId = productId;
            
            InitializeComponent();
        }

        private void DetailProductForm_Load(object sender, EventArgs e)
        {
            Product product= _market.SearchProduct(_productId);

            titleProductLabel.Text = product.name;
            descProductLabel.Text = product.description;
            priceProductLabel.Text = product.price.ToString();
        }
    }
}
