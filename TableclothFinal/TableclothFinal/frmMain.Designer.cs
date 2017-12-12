namespace TableclothFinal
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.cmbChooseBrrwr = new System.Windows.Forms.ComboBox();
            this.tableclothDataSet = new TableclothFinal.TableclothDataSet();
            this.tableclothDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borrowersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borrowersTableAdapter = new TableclothFinal.TableclothDataSetTableAdapters.BorrowersTableAdapter();
            this.borrowersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblBorrower = new System.Windows.Forms.Label();
            this.lstInvoiceId = new System.Windows.Forms.ListBox();
            this.borrowersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesTableAdapter = new TableclothFinal.TableclothDataSetTableAdapters.InvoicesTableAdapter();
            this.invoicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblBorrowerId = new System.Windows.Forms.Label();
            this.lblInvoiceId = new System.Windows.Forms.Label();
            this.lstDate = new System.Windows.Forms.ListBox();
            this.lstQuantity = new System.Windows.Forms.ListBox();
            this.lstProductId = new System.Windows.Forms.ListBox();
            this.lstBorrowerId = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableclothDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableclothDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbChooseBrrwr
            // 
            this.cmbChooseBrrwr.FormattingEnabled = true;
            this.cmbChooseBrrwr.Location = new System.Drawing.Point(27, 32);
            this.cmbChooseBrrwr.Name = "cmbChooseBrrwr";
            this.cmbChooseBrrwr.Size = new System.Drawing.Size(160, 24);
            this.cmbChooseBrrwr.TabIndex = 0;
            this.cmbChooseBrrwr.SelectedIndexChanged += new System.EventHandler(this.cmbChooseBrrwr_SelectedIndexChanged);
            // 
            // tableclothDataSet
            // 
            this.tableclothDataSet.DataSetName = "TableclothDataSet";
            this.tableclothDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableclothDataSetBindingSource
            // 
            this.tableclothDataSetBindingSource.DataSource = this.tableclothDataSet;
            this.tableclothDataSetBindingSource.Position = 0;
            // 
            // borrowersBindingSource
            // 
            this.borrowersBindingSource.DataMember = "Borrowers";
            this.borrowersBindingSource.DataSource = this.tableclothDataSet;
            // 
            // borrowersTableAdapter
            // 
            this.borrowersTableAdapter.ClearBeforeFill = true;
            // 
            // borrowersBindingSource1
            // 
            this.borrowersBindingSource1.DataMember = "Borrowers";
            this.borrowersBindingSource1.DataSource = this.tableclothDataSetBindingSource;
            // 
            // lblBorrower
            // 
            this.lblBorrower.AutoSize = true;
            this.lblBorrower.Location = new System.Drawing.Point(39, 9);
            this.lblBorrower.Name = "lblBorrower";
            this.lblBorrower.Size = new System.Drawing.Size(129, 17);
            this.lblBorrower.TabIndex = 1;
            this.lblBorrower.Text = "Choose a Borrower";
            // 
            // lstInvoiceId
            // 
            this.lstInvoiceId.FormattingEnabled = true;
            this.lstInvoiceId.ItemHeight = 16;
            this.lstInvoiceId.Location = new System.Drawing.Point(0, 44);
            this.lstInvoiceId.Name = "lstInvoiceId";
            this.lstInvoiceId.Size = new System.Drawing.Size(84, 180);
            this.lstInvoiceId.TabIndex = 2;
            this.lstInvoiceId.SelectedIndexChanged += new System.EventHandler(this.lstInvoiceId_SelectedIndexChanged);
            // 
            // borrowersBindingSource2
            // 
            this.borrowersBindingSource2.DataMember = "Borrowers";
            this.borrowersBindingSource2.DataSource = this.tableclothDataSetBindingSource;
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Location = new System.Drawing.Point(82, 310);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(105, 35);
            this.btnAddInvoice.TabIndex = 5;
            this.btnAddInvoice.Text = "Add Invoice";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Location = new System.Drawing.Point(373, 307);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(105, 40);
            this.btnDeleteInvoice.TabIndex = 6;
            this.btnDeleteInvoice.Text = "Delete Invoice";
            this.btnDeleteInvoice.UseVisualStyleBackColor = true;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.tableclothDataSetBindingSource;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // invoicesBindingSource1
            // 
            this.invoicesBindingSource1.DataMember = "Invoices";
            this.invoicesBindingSource1.DataSource = this.tableclothDataSetBindingSource;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInvoiceDate);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.lblProductId);
            this.groupBox1.Controls.Add(this.lblBorrowerId);
            this.groupBox1.Controls.Add(this.lblInvoiceId);
            this.groupBox1.Controls.Add(this.lstDate);
            this.groupBox1.Controls.Add(this.lstQuantity);
            this.groupBox1.Controls.Add(this.lstProductId);
            this.groupBox1.Controls.Add(this.lstBorrowerId);
            this.groupBox1.Controls.Add(this.lstInvoiceId);
            this.groupBox1.Location = new System.Drawing.Point(27, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 230);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Borrowers Invoices";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(391, 24);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(82, 17);
            this.lblInvoiceDate.TabIndex = 11;
            this.lblInvoiceDate.Text = "InvoiceDate";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(282, 23);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(187, 23);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(68, 17);
            this.lblProductId.TabIndex = 9;
            this.lblProductId.Text = "ProductId";
            // 
            // lblBorrowerId
            // 
            this.lblBorrowerId.AutoSize = true;
            this.lblBorrowerId.Location = new System.Drawing.Point(93, 24);
            this.lblBorrowerId.Name = "lblBorrowerId";
            this.lblBorrowerId.Size = new System.Drawing.Size(76, 17);
            this.lblBorrowerId.TabIndex = 8;
            this.lblBorrowerId.Text = "BorrowerId";
            // 
            // lblInvoiceId
            // 
            this.lblInvoiceId.AutoSize = true;
            this.lblInvoiceId.Location = new System.Drawing.Point(6, 24);
            this.lblInvoiceId.Name = "lblInvoiceId";
            this.lblInvoiceId.Size = new System.Drawing.Size(63, 17);
            this.lblInvoiceId.TabIndex = 7;
            this.lblInvoiceId.Text = "InvoiceId";
            // 
            // lstDate
            // 
            this.lstDate.FormattingEnabled = true;
            this.lstDate.ItemHeight = 16;
            this.lstDate.Location = new System.Drawing.Point(368, 44);
            this.lstDate.Name = "lstDate";
            this.lstDate.Size = new System.Drawing.Size(147, 180);
            this.lstDate.TabIndex = 6;
            // 
            // lstQuantity
            // 
            this.lstQuantity.FormattingEnabled = true;
            this.lstQuantity.ItemHeight = 16;
            this.lstQuantity.Location = new System.Drawing.Point(270, 44);
            this.lstQuantity.Name = "lstQuantity";
            this.lstQuantity.Size = new System.Drawing.Size(92, 180);
            this.lstQuantity.TabIndex = 5;
            // 
            // lstProductId
            // 
            this.lstProductId.FormattingEnabled = true;
            this.lstProductId.ItemHeight = 16;
            this.lstProductId.Location = new System.Drawing.Point(180, 44);
            this.lstProductId.Name = "lstProductId";
            this.lstProductId.Size = new System.Drawing.Size(84, 180);
            this.lstProductId.TabIndex = 4;
            // 
            // lstBorrowerId
            // 
            this.lstBorrowerId.FormattingEnabled = true;
            this.lstBorrowerId.ItemHeight = 16;
            this.lstBorrowerId.Location = new System.Drawing.Point(90, 44);
            this.lstBorrowerId.Name = "lstBorrowerId";
            this.lstBorrowerId.Size = new System.Drawing.Size(84, 180);
            this.lstBorrowerId.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteInvoice);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.lblBorrower);
            this.Controls.Add(this.cmbChooseBrrwr);
            this.Name = "frmMain";
            this.Text = "Tablecloth Borrowing Application";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableclothDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableclothDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChooseBrrwr;
        private System.Windows.Forms.BindingSource tableclothDataSetBindingSource;
        private TableclothDataSet tableclothDataSet;
        private System.Windows.Forms.BindingSource borrowersBindingSource;
        private TableclothDataSetTableAdapters.BorrowersTableAdapter borrowersTableAdapter;
        private System.Windows.Forms.BindingSource borrowersBindingSource1;
        private System.Windows.Forms.Label lblBorrower;
        private System.Windows.Forms.ListBox lstInvoiceId;
        private System.Windows.Forms.BindingSource borrowersBindingSource2;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private TableclothDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.BindingSource invoicesBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstBorrowerId;
        private System.Windows.Forms.ListBox lstDate;
        private System.Windows.Forms.ListBox lstQuantity;
        private System.Windows.Forms.ListBox lstProductId;
        private System.Windows.Forms.Label lblInvoiceId;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblBorrowerId;
    }
}

