namespace FinalProject
{
    partial class UpdateCustomer
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbMinital = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbCid = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblMinitial = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(526, 374);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(320, 374);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // tbLname
            // 
            this.tbLname.Location = new System.Drawing.Point(464, 282);
            this.tbLname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(139, 26);
            this.tbLname.TabIndex = 17;
            // 
            // tbMinital
            // 
            this.tbMinital.Location = new System.Drawing.Point(464, 211);
            this.tbMinital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMinital.Name = "tbMinital";
            this.tbMinital.Size = new System.Drawing.Size(139, 26);
            this.tbMinital.TabIndex = 16;
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(464, 144);
            this.tbFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(139, 26);
            this.tbFname.TabIndex = 15;
            // 
            // tbCid
            // 
            this.tbCid.Location = new System.Drawing.Point(464, 70);
            this.tbCid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCid.Name = "tbCid";
            this.tbCid.Size = new System.Drawing.Size(139, 26);
            this.tbCid.TabIndex = 14;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(316, 289);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(90, 20);
            this.lblLname.TabIndex = 13;
            this.lblLname.Text = "Last Name:";
            // 
            // lblMinitial
            // 
            this.lblMinitial.AutoSize = true;
            this.lblMinitial.Location = new System.Drawing.Point(316, 218);
            this.lblMinitial.Name = "lblMinitial";
            this.lblMinitial.Size = new System.Drawing.Size(100, 20);
            this.lblMinitial.TabIndex = 12;
            this.lblMinitial.Text = "Middle Initial:";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(316, 149);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(90, 20);
            this.lblFname.TabIndex = 11;
            this.lblFname.Text = "First Name:";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Location = new System.Drawing.Point(316, 76);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(103, 20);
            this.lblCid.TabIndex = 10;
            this.lblCid.Text = "Customer ID:";
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.tbMinital);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.tbCid);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblMinitial);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lblCid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateCustomer";
            this.Text = "Update Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbMinital;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbCid;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblMinitial;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblCid;
    }
}