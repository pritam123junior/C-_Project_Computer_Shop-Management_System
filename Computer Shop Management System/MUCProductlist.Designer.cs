namespace Computer_Shop_Management_System
{
    partial class MUCProductlist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPcategory = new System.Windows.Forms.ComboBox();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMsearch = new System.Windows.Forms.TextBox();
            this.txtASearch = new System.Windows.Forms.TextBox();
            this.lblPquantity = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btnShowproduct = new System.Windows.Forms.Button();
            this.lblPprice = new System.Windows.Forms.Label();
            this.lblPcategory = new System.Windows.Forms.Label();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.lblPname = new System.Windows.Forms.Label();
            this.lblPid = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FloralWhite;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(375, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "**(Please Double Click for Update)**";
            // 
            // cmbPcategory
            // 
            this.cmbPcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPcategory.FormattingEnabled = true;
            this.cmbPcategory.Items.AddRange(new object[] {
            "Laptop",
            "Monitor",
            "Tablet",
            "Mouse",
            "Keyboard",
            "Ram",
            "Ssd",
            "Hdd",
            "Processor",
            "Gpu",
            "Speaker",
            "Motherboard",
            "Powersupply",
            "Casing"});
            this.cmbPcategory.Location = new System.Drawing.Point(154, 178);
            this.cmbPcategory.Name = "cmbPcategory";
            this.cmbPcategory.Size = new System.Drawing.Size(113, 24);
            this.cmbPcategory.TabIndex = 51;
            // 
            // txtPid
            // 
            this.txtPid.Location = new System.Drawing.Point(155, 114);
            this.txtPid.Name = "txtPid";
            this.txtPid.ReadOnly = true;
            this.txtPid.Size = new System.Drawing.Size(112, 22);
            this.txtPid.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtMsearch);
            this.panel1.Controls.Add(this.txtASearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 101);
            this.panel1.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(513, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "**(Search by Name)**";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(288, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "**(Search by Category)**";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnSearch.Location = new System.Drawing.Point(214, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 29);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMsearch
            // 
            this.txtMsearch.Location = new System.Drawing.Point(312, 16);
            this.txtMsearch.Name = "txtMsearch";
            this.txtMsearch.Size = new System.Drawing.Size(100, 22);
            this.txtMsearch.TabIndex = 7;
            // 
            // txtASearch
            // 
            this.txtASearch.Location = new System.Drawing.Point(532, 16);
            this.txtASearch.Name = "txtASearch";
            this.txtASearch.Size = new System.Drawing.Size(100, 22);
            this.txtASearch.TabIndex = 6;
            this.txtASearch.TextChanged += new System.EventHandler(this.txtASearch_TextChanged);
            // 
            // lblPquantity
            // 
            this.lblPquantity.AutoSize = true;
            this.lblPquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPquantity.Location = new System.Drawing.Point(6, 253);
            this.lblPquantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPquantity.Name = "lblPquantity";
            this.lblPquantity.Size = new System.Drawing.Size(134, 20);
            this.lblPquantity.TabIndex = 48;
            this.lblPquantity.Text = "Product Quantity";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(155, 251);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(112, 22);
            this.txtquantity.TabIndex = 47;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(155, 213);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(112, 22);
            this.txtprice.TabIndex = 46;
            // 
            // btnShowproduct
            // 
            this.btnShowproduct.BackColor = System.Drawing.Color.MediumPurple;
            this.btnShowproduct.Location = new System.Drawing.Point(1, 393);
            this.btnShowproduct.Name = "btnShowproduct";
            this.btnShowproduct.Size = new System.Drawing.Size(125, 41);
            this.btnShowproduct.TabIndex = 40;
            this.btnShowproduct.Text = "Show Product";
            this.btnShowproduct.UseVisualStyleBackColor = false;
            this.btnShowproduct.Click += new System.EventHandler(this.btnShowproduct_Click);
            // 
            // lblPprice
            // 
            this.lblPprice.AutoSize = true;
            this.lblPprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPprice.Location = new System.Drawing.Point(6, 215);
            this.lblPprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPprice.Name = "lblPprice";
            this.lblPprice.Size = new System.Drawing.Size(111, 20);
            this.lblPprice.TabIndex = 45;
            this.lblPprice.Text = "Product Price";
            // 
            // lblPcategory
            // 
            this.lblPcategory.AutoSize = true;
            this.lblPcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPcategory.Location = new System.Drawing.Point(6, 182);
            this.lblPcategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPcategory.Name = "lblPcategory";
            this.lblPcategory.Size = new System.Drawing.Size(139, 20);
            this.lblPcategory.TabIndex = 44;
            this.lblPcategory.Text = "Product Category";
            // 
            // txtPname
            // 
            this.txtPname.Location = new System.Drawing.Point(155, 149);
            this.txtPname.Margin = new System.Windows.Forms.Padding(4);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(112, 22);
            this.txtPname.TabIndex = 43;
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPname.Location = new System.Drawing.Point(6, 150);
            this.lblPname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(116, 20);
            this.lblPname.TabIndex = 42;
            this.lblPname.Text = "Product Name";
            // 
            // lblPid
            // 
            this.lblPid.AutoSize = true;
            this.lblPid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPid.Location = new System.Drawing.Point(7, 117);
            this.lblPid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPid.Name = "lblPid";
            this.lblPid.Size = new System.Drawing.Size(89, 20);
            this.lblPid.TabIndex = 41;
            this.lblPid.Text = "Product ID";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MediumPurple;
            this.btnClear.Location = new System.Drawing.Point(174, 408);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 26);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDelete.Location = new System.Drawing.Point(174, 372);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumPurple;
            this.btnUpdate.Location = new System.Drawing.Point(174, 329);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 28);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(274, 16);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(653, 418);
            this.dgvProduct.TabIndex = 36;
            this.dgvProduct.DoubleClick += new System.EventHandler(this.dgvProduct_DoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 25);
            this.label10.TabIndex = 53;
            this.label10.Text = "PRODUCT LIST";
            // 
            // MUCProductlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPcategory);
            this.Controls.Add(this.txtPid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPquantity);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.btnShowproduct);
            this.Controls.Add(this.lblPprice);
            this.Controls.Add(this.lblPcategory);
            this.Controls.Add(this.txtPname);
            this.Controls.Add(this.lblPname);
            this.Controls.Add(this.lblPid);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvProduct);
            this.Name = "MUCProductlist";
            this.Size = new System.Drawing.Size(930, 541);
            this.Load += new System.EventHandler(this.MUCProductlist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPcategory;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMsearch;
        private System.Windows.Forms.TextBox txtASearch;
        private System.Windows.Forms.Label lblPquantity;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button btnShowproduct;
        private System.Windows.Forms.Label lblPprice;
        private System.Windows.Forms.Label lblPcategory;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.Label lblPname;
        private System.Windows.Forms.Label lblPid;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label label10;
    }
}
