namespace Computer_Shop_Management_System
{
    partial class MUserControlNoti
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
            this.dgvNoti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNoti
            // 
            this.dgvNoti.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.dgvNoti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoti.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNoti.Location = new System.Drawing.Point(0, 140);
            this.dgvNoti.Name = "dgvNoti";
            this.dgvNoti.RowHeadersWidth = 51;
            this.dgvNoti.RowTemplate.Height = 24;
            this.dgvNoti.Size = new System.Drawing.Size(526, 306);
            this.dgvNoti.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOTIFICATION";
            // 
            // MUserControlNoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvNoti);
            this.Controls.Add(this.label1);
            this.Name = "MUserControlNoti";
            this.Size = new System.Drawing.Size(526, 446);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNoti;
        private System.Windows.Forms.Label label1;
    }
}
