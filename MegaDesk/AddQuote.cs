using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk2
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)this.Tag).Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var desk = new Desk
            {
                Width = (int)numWidth.Value,
                Depth = (int)numDepth.Value,
                NumberOfDrawers = (int)numberOfDrawers.Value,
                DesktopMaterial = (DesktopMaterial)comboMaterial.SelectedValue

            };

            var deskQuote = new DeskQuote
            {
                desk = desk,
                CustomerName = textCustomerName.Text,
                QuoteDate = DateTime.Now,
                DeliveryType = (Delivery)comboDelivery.SelectedValue

            };

            var price = deskQuote.GetQuotePrice();

            



        }
    }
}
