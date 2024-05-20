namespace Computer_Shop_Management_System
{
    partial class UserControlnotify
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblmessage = new System.Windows.Forms.Label();
            this.btnsend = new System.Windows.Forms.Button();
            this.lbln = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMessage.Location = new System.Drawing.Point(134, 200);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(442, 123);
            this.txtMessage.TabIndex = 0;
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.Location = new System.Drawing.Point(25, 196);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(93, 25);
            this.lblmessage.TabIndex = 1;
            this.lblmessage.Text = "Message";
            this.lblmessage.Click += new System.EventHandler(this.lblmessage_Click);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(442, 159);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(134, 35);
            this.btnsend.TabIndex = 2;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // lbln
            // 
            this.lbln.AutoSize = true;
            this.lbln.Location = new System.Drawing.Point(146, 170);
            this.lbln.Name = "lbln";
            this.lbln.Size = new System.Drawing.Size(20, 16);
            this.lbln.TabIndex = 3;
            this.lbln.Text = "{!}";
            // 
            // UserControlnotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbln);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.txtMessage);
            this.Name = "UserControlnotify";
            this.Size = new System.Drawing.Size(757, 524);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label lbln;
    }
}
