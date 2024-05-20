namespace Computer_Shop_Management_System
{
    partial class UserControlEmployee
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbcate = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dgvemployee = new System.Windows.Forms.DataGridView();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.btncleiear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.dtpem = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkOrchid;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(848, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Search";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 25);
            this.label10.TabIndex = 43;
            this.label10.Text = "EMPLOYEE LIST";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 222);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Employee Position";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "    Employee ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Joining Date";
            // 
            // cmbcate
            // 
            this.cmbcate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbcate.ForeColor = System.Drawing.Color.Black;
            this.cmbcate.FormattingEnabled = true;
            this.cmbcate.Items.AddRange(new object[] {
            "Manager",
            "Salesman"});
            this.cmbcate.Location = new System.Drawing.Point(229, 218);
            this.cmbcate.Name = "cmbcate";
            this.cmbcate.Size = new System.Drawing.Size(150, 24);
            this.cmbcate.TabIndex = 38;
            this.cmbcate.SelectedIndexChanged += new System.EventHandler(this.cmbcate_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtName.Location = new System.Drawing.Point(180, 153);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 22);
            this.txtName.TabIndex = 36;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtId.Location = new System.Drawing.Point(180, 110);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(202, 22);
            this.txtId.TabIndex = 35;
            // 
            // dgvemployee
            // 
            this.dgvemployee.AllowUserToAddRows = false;
            this.dgvemployee.AllowUserToDeleteRows = false;
            this.dgvemployee.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.dgvemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemployee.GridColor = System.Drawing.Color.MediumPurple;
            this.dgvemployee.Location = new System.Drawing.Point(419, 77);
            this.dgvemployee.Name = "dgvemployee";
            this.dgvemployee.ReadOnly = true;
            this.dgvemployee.RowHeadersWidth = 51;
            this.dgvemployee.RowTemplate.Height = 24;
            this.dgvemployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvemployee.Size = new System.Drawing.Size(678, 400);
            this.dgvemployee.TabIndex = 34;
            this.dgvemployee.DoubleClick += new System.EventHandler(this.dgvemployee_DoubleClick);
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAutoSearch.Location = new System.Drawing.Point(524, 34);
            this.txtAutoSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(303, 22);
            this.txtAutoSearch.TabIndex = 31;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // btncleiear
            // 
            this.btncleiear.BackColor = System.Drawing.Color.DarkOrchid;
            this.btncleiear.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btncleiear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncleiear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncleiear.ForeColor = System.Drawing.Color.White;
            this.btncleiear.Location = new System.Drawing.Point(165, 425);
            this.btncleiear.Name = "btncleiear";
            this.btncleiear.Size = new System.Drawing.Size(100, 45);
            this.btncleiear.TabIndex = 29;
            this.btncleiear.Text = "Clear";
            this.btncleiear.UseVisualStyleBackColor = false;
            this.btncleiear.Click += new System.EventHandler(this.btncleiear_Click_1);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(38, 425);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 45);
            this.btnsave.TabIndex = 28;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 324);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSalary.Location = new System.Drawing.Point(180, 324);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(202, 22);
            this.txtSalary.TabIndex = 25;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.DarkOrchid;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(294, 425);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 45);
            this.btndelete.TabIndex = 46;
            this.btndelete.Text = "Remove";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // dtpem
            // 
            this.dtpem.CustomFormat = "yyyy-MM-dd";
            this.dtpem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpem.Location = new System.Drawing.Point(190, 277);
            this.dtpem.Margin = new System.Windows.Forms.Padding(4);
            this.dtpem.Name = "dtpem";
            this.dtpem.Size = new System.Drawing.Size(163, 22);
            this.dtpem.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(577, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "**(Search by Name)**";
            // 
            // UserControlEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpem);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbcate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvemployee);
            this.Controls.Add(this.txtAutoSearch);
            this.Controls.Add(this.btncleiear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalary);
            this.Name = "UserControlEmployee";
            this.Size = new System.Drawing.Size(1107, 498);
            this.Load += new System.EventHandler(this.UserControlEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvemployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbcate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgvemployee;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Button btncleiear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DateTimePicker dtpem;
        private System.Windows.Forms.Label label3;
    }
}
