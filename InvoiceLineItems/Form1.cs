using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceLineItems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e) {

            // store all line item + invoice entries in
            // list references
            List<LineItem> lineItems = LineItemDB.GetLineItems();
            List<Invoice> invoices = InvoiceDB.GetInvoices();

            // join these into an IEnumerable before populating the ListView
            var listViewItems = 
                from item in lineItems
                join invoice in invoices
                on item.InvoiceID equals invoice.InvoiceID
                orderby invoice.InvoiceDate
                select new {
                    item.InvoiceID,
                    invoice.InvoiceDate,
                    invoice.InvoiceTotal,
                    item.ProductCode,
                    item.UnitPrice,
                    item.Quantity,
                    item.ItemTotal
                };

                // fill the listview
                foreach (var lineItem in listViewItems) {
                lvwLineItems.Items.Add(new ListViewItem(new string[] {
                    lineItem.InvoiceID.ToString(),
                    lineItem.InvoiceDate.ToShortDateString(),
                    lineItem.InvoiceTotal.ToString("c"),
                    lineItem.ProductCode,
                    lineItem.UnitPrice.ToString("c"),
                    lineItem.Quantity.ToString(),
                    lineItem.ItemTotal.ToString("c")
                }));
            }
        }
    }
}
