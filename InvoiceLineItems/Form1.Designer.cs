namespace InvoiceLineItems
{
    partial class Form1
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
            this.lvwLineItems = new System.Windows.Forms.ListView();
            this.chdInvoiceID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdInvoiceDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdInvoiceTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdProductCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdUnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdItemTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvwLineItems
            // 
            this.lvwLineItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdInvoiceID,
            this.chdInvoiceDate,
            this.chdInvoiceTotal,
            this.chdProductCode,
            this.chdUnitPrice,
            this.chdQuantity,
            this.chdItemTotal});
            this.lvwLineItems.HideSelection = false;
            this.lvwLineItems.Location = new System.Drawing.Point(13, 13);
            this.lvwLineItems.Name = "lvwLineItems";
            this.lvwLineItems.Size = new System.Drawing.Size(622, 490);
            this.lvwLineItems.TabIndex = 0;
            this.lvwLineItems.UseCompatibleStateImageBehavior = false;
            this.lvwLineItems.View = System.Windows.Forms.View.Details;
            // 
            // chdInvoiceID
            // 
            this.chdInvoiceID.Text = "InvoiceID";
            this.chdInvoiceID.Width = 90;
            // 
            // chdInvoiceDate
            // 
            this.chdInvoiceDate.Text = "InvoiceDate";
            this.chdInvoiceDate.Width = 90;
            // 
            // chdInvoiceTotal
            // 
            this.chdInvoiceTotal.Text = "InvoiceTotal";
            this.chdInvoiceTotal.Width = 90;
            // 
            // chdProductCode
            // 
            this.chdProductCode.Text = "Product Code";
            this.chdProductCode.Width = 90;
            // 
            // chdUnitPrice
            // 
            this.chdUnitPrice.Text = "Unit Price";
            this.chdUnitPrice.Width = 84;
            // 
            // chdQuantity
            // 
            this.chdQuantity.Text = "Quantity";
            this.chdQuantity.Width = 55;
            // 
            // chdItemTotal
            // 
            this.chdItemTotal.Text = "Item Total";
            this.chdItemTotal.Width = 95;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 515);
            this.Controls.Add(this.lvwLineItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Line Items by Invoice Date";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwLineItems;
        private System.Windows.Forms.ColumnHeader chdInvoiceID;
        private System.Windows.Forms.ColumnHeader chdProductCode;
        private System.Windows.Forms.ColumnHeader chdUnitPrice;
        private System.Windows.Forms.ColumnHeader chdQuantity;
        private System.Windows.Forms.ColumnHeader chdItemTotal;
        private System.Windows.Forms.ColumnHeader chdInvoiceDate;
        private System.Windows.Forms.ColumnHeader chdInvoiceTotal;
    }
}

