namespace Computer_Shop_Management_System
{
    partial class UserCustomer
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
            this.dgvcus = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAutosearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcus
            // 
            this.dgvcus.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.dgvcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvcus.GridColor = System.Drawing.Color.BlueViolet;
            this.dgvcus.Location = new System.Drawing.Point(0, 95);
            this.dgvcus.Name = "dgvcus";
            this.dgvcus.RowHeadersWidth = 51;
            this.dgvcus.RowTemplate.Height = 24;
            this.dgvcus.Size = new System.Drawing.Size(988, 517);
            this.dgvcus.TabIndex = 20;
            this.dgvcus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpro_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 25);
            this.label10.TabIndex = 38;
            this.label10.Text = "CUSTOMER LIST";
            // 
            // txtAutosearch
            // 
            this.txtAutosearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAutosearch.Location = new System.Drawing.Point(277, 13);
            this.txtAutosearch.Name = "txtAutosearch";
            this.txtAutosearch.Size = new System.Drawing.Size(248, 22);
            this.txtAutosearch.TabIndex = 39;
            this.txtAutosearch.TextChanged += new System.EventHandler(this.txtAutosearch_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(542, 8);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(85, 35);
            this.btnsearch.TabIndex = 40;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(337, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "**(Search by Name)**";
            // 
            // UserCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtAutosearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvcus);
            this.Name = "UserCustomer";
            this.Size = new System.Drawing.Size(988, 612);
            this.Load += new System.EventHandler(this.UserProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvcus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAutosearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label2;
    }
}
