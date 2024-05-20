namespace Computer_Shop_Management_System
{
    partial class MUCorderlist
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
            this.cmbOcategory = new System.Windows.Forms.ComboBox();
            this.txtOid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOSearch = new System.Windows.Forms.Button();
            this.txtOMsearch = new System.Windows.Forms.TextBox();
            this.txtOASearch = new System.Windows.Forms.TextBox();
            this.lblOquantity = new System.Windows.Forms.Label();
            this.txtOquantity = new System.Windows.Forms.TextBox();
            this.btnShowOrder = new System.Windows.Forms.Button();
            this.lblOcategory = new System.Windows.Forms.Label();
            this.txtOproduct = new System.Windows.Forms.TextBox();
            this.lblOproduct = new System.Windows.Forms.Label();
            this.lblOid = new System.Windows.Forms.Label();
            this.btnOClear = new System.Windows.Forms.Button();
            this.btnORemove = new System.Windows.Forms.Button();
            this.btnOUpdate = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.lblOdate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(99, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 16);
            this.label3.TabIndex = 69;
            this.label3.Text = "**(Please Double Click for Update)**";
            // 
            // cmbOcategory
            // 
            this.cmbOcategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbOcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOcategory.FormattingEnabled = true;
            this.cmbOcategory.Items.AddRange(new object[] {
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
            this.cmbOcategory.Location = new System.Drawing.Point(196, 135);
            this.cmbOcategory.Name = "cmbOcategory";
            this.cmbOcategory.Size = new System.Drawing.Size(113, 24);
            this.cmbOcategory.TabIndex = 68;
            // 
            // txtOid
            // 
            this.txtOid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtOid.Location = new System.Drawing.Point(197, 71);
            this.txtOid.Name = "txtOid";
            this.txtOid.ReadOnly = true;
            this.txtOid.Size = new System.Drawing.Size(112, 22);
            this.txtOid.TabIndex = 67;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnOSearch);
            this.panel1.Controls.Add(this.txtOMsearch);
            this.panel1.Controls.Add(this.txtOASearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 451);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 90);
            this.panel1.TabIndex = 66;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(690, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "**(Search by Name)**";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(465, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "**(Search by Category)**";
            // 
            // btnOSearch
            // 
            this.btnOSearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOSearch.Location = new System.Drawing.Point(391, 15);
            this.btnOSearch.Name = "btnOSearch";
            this.btnOSearch.Size = new System.Drawing.Size(79, 29);
            this.btnOSearch.TabIndex = 4;
            this.btnOSearch.Text = "Search";
            this.btnOSearch.UseVisualStyleBackColor = false;
            // 
            // txtOMsearch
            // 
            this.txtOMsearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtOMsearch.Location = new System.Drawing.Point(489, 16);
            this.txtOMsearch.Name = "txtOMsearch";
            this.txtOMsearch.Size = new System.Drawing.Size(100, 22);
            this.txtOMsearch.TabIndex = 7;
            this.txtOMsearch.TextChanged += new System.EventHandler(this.txtOMsearch_TextChanged);
            // 
            // txtOASearch
            // 
            this.txtOASearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtOASearch.Location = new System.Drawing.Point(709, 16);
            this.txtOASearch.Name = "txtOASearch";
            this.txtOASearch.Size = new System.Drawing.Size(100, 22);
            this.txtOASearch.TabIndex = 6;
            this.txtOASearch.TextChanged += new System.EventHandler(this.txtOASearch_TextChanged);
            // 
            // lblOquantity
            // 
            this.lblOquantity.AutoSize = true;
            this.lblOquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOquantity.Location = new System.Drawing.Point(51, 186);
            this.lblOquantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOquantity.Name = "lblOquantity";
            this.lblOquantity.Size = new System.Drawing.Size(119, 20);
            this.lblOquantity.TabIndex = 65;
            this.lblOquantity.Text = "Order Quantity";
            // 
            // txtOquantity
            // 
            this.txtOquantity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtOquantity.Location = new System.Drawing.Point(196, 186);
            this.txtOquantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtOquantity.Name = "txtOquantity";
            this.txtOquantity.Size = new System.Drawing.Size(112, 22);
            this.txtOquantity.TabIndex = 64;
            // 
            // btnShowOrder
            // 
            this.btnShowOrder.BackColor = System.Drawing.Color.MediumPurple;
            this.btnShowOrder.Location = new System.Drawing.Point(49, 387);
            this.btnShowOrder.Name = "btnShowOrder";
            this.btnShowOrder.Size = new System.Drawing.Size(125, 54);
            this.btnShowOrder.TabIndex = 57;
            this.btnShowOrder.Text = "Show Order";
            this.btnShowOrder.UseVisualStyleBackColor = false;
            this.btnShowOrder.Click += new System.EventHandler(this.btnShowOrder_Click);
            // 
            // lblOcategory
            // 
            this.lblOcategory.AutoSize = true;
            this.lblOcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcategory.Location = new System.Drawing.Point(45, 139);
            this.lblOcategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOcategory.Name = "lblOcategory";
            this.lblOcategory.Size = new System.Drawing.Size(124, 20);
            this.lblOcategory.TabIndex = 61;
            this.lblOcategory.Text = "Order Category";
            // 
            // txtOproduct
            // 
            this.txtOproduct.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtOproduct.Location = new System.Drawing.Point(197, 106);
            this.txtOproduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtOproduct.Name = "txtOproduct";
            this.txtOproduct.Size = new System.Drawing.Size(112, 22);
            this.txtOproduct.TabIndex = 60;
            // 
            // lblOproduct
            // 
            this.lblOproduct.AutoSize = true;
            this.lblOproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOproduct.Location = new System.Drawing.Point(45, 107);
            this.lblOproduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOproduct.Name = "lblOproduct";
            this.lblOproduct.Size = new System.Drawing.Size(115, 20);
            this.lblOproduct.TabIndex = 59;
            this.lblOproduct.Text = "Order Product";
            // 
            // lblOid
            // 
            this.lblOid.AutoSize = true;
            this.lblOid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOid.Location = new System.Drawing.Point(51, 71);
            this.lblOid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOid.Name = "lblOid";
            this.lblOid.Size = new System.Drawing.Size(74, 20);
            this.lblOid.TabIndex = 58;
            this.lblOid.Text = "Order ID";
            // 
            // btnOClear
            // 
            this.btnOClear.BackColor = System.Drawing.Color.MediumPurple;
            this.btnOClear.Location = new System.Drawing.Point(186, 395);
            this.btnOClear.Name = "btnOClear";
            this.btnOClear.Size = new System.Drawing.Size(111, 39);
            this.btnOClear.TabIndex = 56;
            this.btnOClear.Text = "Clear All ";
            this.btnOClear.UseVisualStyleBackColor = false;
            this.btnOClear.Click += new System.EventHandler(this.btnOClear_Click);
            // 
            // btnORemove
            // 
            this.btnORemove.BackColor = System.Drawing.Color.MediumPurple;
            this.btnORemove.Location = new System.Drawing.Point(186, 350);
            this.btnORemove.Name = "btnORemove";
            this.btnORemove.Size = new System.Drawing.Size(111, 42);
            this.btnORemove.TabIndex = 55;
            this.btnORemove.Text = "Order Remove";
            this.btnORemove.UseVisualStyleBackColor = false;
            this.btnORemove.Click += new System.EventHandler(this.btnORemove_Click);
            // 
            // btnOUpdate
            // 
            this.btnOUpdate.BackColor = System.Drawing.Color.MediumPurple;
            this.btnOUpdate.Location = new System.Drawing.Point(186, 303);
            this.btnOUpdate.Name = "btnOUpdate";
            this.btnOUpdate.Size = new System.Drawing.Size(111, 41);
            this.btnOUpdate.TabIndex = 54;
            this.btnOUpdate.Text = "Order Update";
            this.btnOUpdate.UseVisualStyleBackColor = false;
            this.btnOUpdate.Click += new System.EventHandler(this.btnOUpdate_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.GridColor = System.Drawing.Color.DarkOrchid;
            this.dgvOrder.Location = new System.Drawing.Point(338, 3);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(612, 431);
            this.dgvOrder.TabIndex = 53;
            this.dgvOrder.DoubleClick += new System.EventHandler(this.dgvOrder_DoubleClick);
            // 
            // lblOdate
            // 
            this.lblOdate.AutoSize = true;
            this.lblOdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdate.Location = new System.Drawing.Point(50, 236);
            this.lblOdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdate.Name = "lblOdate";
            this.lblOdate.Size = new System.Drawing.Size(93, 20);
            this.lblOdate.TabIndex = 70;
            this.lblOdate.Text = "Order Date";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(146, 234);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(163, 22);
            this.dtpDate.TabIndex = 71;
            // 
            // MUCorderlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblOdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOcategory);
            this.Controls.Add(this.txtOid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOquantity);
            this.Controls.Add(this.txtOquantity);
            this.Controls.Add(this.btnShowOrder);
            this.Controls.Add(this.lblOcategory);
            this.Controls.Add(this.txtOproduct);
            this.Controls.Add(this.lblOproduct);
            this.Controls.Add(this.lblOid);
            this.Controls.Add(this.btnOClear);
            this.Controls.Add(this.btnORemove);
            this.Controls.Add(this.btnOUpdate);
            this.Controls.Add(this.dgvOrder);
            this.Name = "MUCorderlist";
            this.Size = new System.Drawing.Size(950, 541);
            this.Load += new System.EventHandler(this.MUCorderlist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOcategory;
        private System.Windows.Forms.TextBox txtOid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOSearch;
        private System.Windows.Forms.TextBox txtOMsearch;
        private System.Windows.Forms.TextBox txtOASearch;
        private System.Windows.Forms.Label lblOquantity;
        private System.Windows.Forms.TextBox txtOquantity;
        private System.Windows.Forms.Button btnShowOrder;
        private System.Windows.Forms.Label lblOcategory;
        private System.Windows.Forms.TextBox txtOproduct;
        private System.Windows.Forms.Label lblOproduct;
        private System.Windows.Forms.Label lblOid;
        private System.Windows.Forms.Button btnOClear;
        private System.Windows.Forms.Button btnORemove;
        private System.Windows.Forms.Button btnOUpdate;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label lblOdate;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}
