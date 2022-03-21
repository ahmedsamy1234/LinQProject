namespace LinQFinalProject
{
    partial class SupplierForm
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
            this.Edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Name_label = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Email_textbox = new System.Windows.Forms.TextBox();
            this.website = new System.Windows.Forms.Label();
            this.website_textbox = new System.Windows.Forms.TextBox();
            this.SSN_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fax_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(259, 335);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 31;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(163, 335);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 30;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(70, 335);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 29;
            this.Add.Text = "add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(35, 261);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(35, 13);
            this.Name_label.TabIndex = 28;
            this.Name_label.Text = "Name";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(100, 254);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(156, 20);
            this.NameTextbox.TabIndex = 27;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(35, 229);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(38, 13);
            this.phone.TabIndex = 26;
            this.phone.Text = "Phone";
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(100, 222);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(156, 20);
            this.phone_textbox.TabIndex = 25;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(35, 197);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 24;
            this.Email.Text = "Email";
            // 
            // Email_textbox
            // 
            this.Email_textbox.Location = new System.Drawing.Point(100, 194);
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.Size = new System.Drawing.Size(156, 20);
            this.Email_textbox.TabIndex = 23;
            // 
            // website
            // 
            this.website.AutoSize = true;
            this.website.Location = new System.Drawing.Point(35, 158);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(46, 13);
            this.website.TabIndex = 22;
            this.website.Text = "Website";
            // 
            // website_textbox
            // 
            this.website_textbox.Location = new System.Drawing.Point(100, 151);
            this.website_textbox.Name = "website_textbox";
            this.website_textbox.Size = new System.Drawing.Size(156, 20);
            this.website_textbox.TabIndex = 21;
            // 
            // SSN_textBox
            // 
            this.SSN_textBox.Location = new System.Drawing.Point(100, 84);
            this.SSN_textBox.Name = "SSN_textBox";
            this.SSN_textBox.Size = new System.Drawing.Size(156, 20);
            this.SSN_textBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fax";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "SSN";
            // 
            // fax_textbox
            // 
            this.fax_textbox.Location = new System.Drawing.Point(100, 120);
            this.fax_textbox.Name = "fax_textbox";
            this.fax_textbox.Size = new System.Drawing.Size(156, 20);
            this.fax_textbox.TabIndex = 18;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Email_textbox);
            this.Controls.Add(this.website);
            this.Controls.Add(this.website_textbox);
            this.Controls.Add(this.SSN_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fax_textbox);
            this.Name = "SupplierForm";
            this.Text = "_ٍSupplier";
            this.Load += new System.EventHandler(this._ٍSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox Email_textbox;
        private System.Windows.Forms.Label website;
        private System.Windows.Forms.TextBox website_textbox;
        private System.Windows.Forms.TextBox SSN_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fax_textbox;
    }
}