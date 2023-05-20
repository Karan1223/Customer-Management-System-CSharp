namespace FinalProject
{
    partial class AddCustomers
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.tbMInitial = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbLName = new System.Windows.Forms.Label();
            this.lbMInitial = new System.Windows.Forms.Label();
            this.lbFName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(524, 370);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(274, 370);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbLName
            // 
            this.tbLName.Location = new System.Drawing.Point(424, 284);
            this.tbLName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(175, 26);
            this.tbLName.TabIndex = 17;
            // 
            // tbMInitial
            // 
            this.tbMInitial.Location = new System.Drawing.Point(424, 216);
            this.tbMInitial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMInitial.Name = "tbMInitial";
            this.tbMInitial.Size = new System.Drawing.Size(175, 26);
            this.tbMInitial.TabIndex = 16;
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(424, 146);
            this.tbFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(175, 26);
            this.tbFName.TabIndex = 15;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(424, 79);
            this.tbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(175, 26);
            this.tbID.TabIndex = 14;
            // 
            // lbLName
            // 
            this.lbLName.AutoSize = true;
            this.lbLName.Location = new System.Drawing.Point(271, 290);
            this.lbLName.Name = "lbLName";
            this.lbLName.Size = new System.Drawing.Size(90, 20);
            this.lbLName.TabIndex = 13;
            this.lbLName.Text = "Last Name:";
            // 
            // lbMInitial
            // 
            this.lbMInitial.AutoSize = true;
            this.lbMInitial.Location = new System.Drawing.Point(271, 221);
            this.lbMInitial.Name = "lbMInitial";
            this.lbMInitial.Size = new System.Drawing.Size(100, 20);
            this.lbMInitial.TabIndex = 12;
            this.lbMInitial.Text = "Middle Initial:";
            // 
            // lbFName
            // 
            this.lbFName.AutoSize = true;
            this.lbFName.Location = new System.Drawing.Point(271, 151);
            this.lbFName.Name = "lbFName";
            this.lbFName.Size = new System.Drawing.Size(90, 20);
            this.lbFName.TabIndex = 11;
            this.lbFName.Text = "First Name:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(271, 79);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(100, 20);
            this.lbID.TabIndex = 10;
            this.lbID.Text = "Customer Id:";
            // 
            // AddCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbLName);
            this.Controls.Add(this.tbMInitial);
            this.Controls.Add(this.tbFName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lbLName);
            this.Controls.Add(this.lbMInitial);
            this.Controls.Add(this.lbFName);
            this.Controls.Add(this.lbID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddCustomers";
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.TextBox tbMInitial;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbLName;
        private System.Windows.Forms.Label lbMInitial;
        private System.Windows.Forms.Label lbFName;
        private System.Windows.Forms.Label lbID;
    }
}