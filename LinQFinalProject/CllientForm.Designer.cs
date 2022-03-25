namespace LinQFinalProject
{
    partial class CllientForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Edit);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.Name_label);
            this.groupBox1.Controls.Add(this.NameTextbox);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.phone_textbox);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.Email_textbox);
            this.groupBox1.Controls.Add(this.website);
            this.groupBox1.Controls.Add(this.website_textbox);
            this.groupBox1.Controls.Add(this.SSN_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fax_textbox);
            this.groupBox1.Location = new System.Drawing.Point(-1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 426);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Department";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(263, 330);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 15;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(167, 330);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 14;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(74, 330);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 13;
            this.Add.Text = "add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(39, 256);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(35, 13);
            this.Name_label.TabIndex = 12;
            this.Name_label.Text = "Name";
            this.Name_label.Click += new System.EventHandler(this.Name_label_Click);
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(104, 256);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(156, 20);
            this.NameTextbox.TabIndex = 11;
            this.NameTextbox.TextChanged += new System.EventHandler(this.NameTextbox_TextChanged);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(39, 224);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(38, 13);
            this.phone.TabIndex = 10;
            this.phone.Text = "Phone";
            this.phone.Click += new System.EventHandler(this.phone_Click);
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(104, 217);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(156, 20);
            this.phone_textbox.TabIndex = 9;
            this.phone_textbox.TextChanged += new System.EventHandler(this.phone_textbox_TextChanged);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(39, 192);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 8;
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // Email_textbox
            // 
            this.Email_textbox.Location = new System.Drawing.Point(104, 189);
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.Size = new System.Drawing.Size(156, 20);
            this.Email_textbox.TabIndex = 7;
            this.Email_textbox.TextChanged += new System.EventHandler(this.Email_textbox_TextChanged);
            // 
            // website
            // 
            this.website.AutoSize = true;
            this.website.Location = new System.Drawing.Point(39, 153);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(46, 13);
            this.website.TabIndex = 6;
            this.website.Text = "Website";
            this.website.Click += new System.EventHandler(this.website_Click);
            // 
            // website_textbox
            // 
            this.website_textbox.Location = new System.Drawing.Point(104, 146);
            this.website_textbox.Name = "website_textbox";
            this.website_textbox.Size = new System.Drawing.Size(156, 20);
            this.website_textbox.TabIndex = 5;
            this.website_textbox.TextChanged += new System.EventHandler(this.website_textbox_TextChanged);
            // 
            // SSN_textBox
            // 
            this.SSN_textBox.Location = new System.Drawing.Point(104, 79);
            this.SSN_textBox.Name = "SSN_textBox";
            this.SSN_textBox.Size = new System.Drawing.Size(156, 20);
            this.SSN_textBox.TabIndex = 1;
            this.SSN_textBox.TextChanged += new System.EventHandler(this.SSN_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fax";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SSN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fax_textbox
            // 
            this.fax_textbox.Location = new System.Drawing.Point(104, 115);
            this.fax_textbox.Name = "fax_textbox";
            this.fax_textbox.Size = new System.Drawing.Size(156, 20);
            this.fax_textbox.TabIndex = 2;
            this.fax_textbox.TextChanged += new System.EventHandler(this.fax_textbox_TextChanged);
            // 
            // CllientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 391);
            this.Controls.Add(this.groupBox1);
            this.Name = "CllientForm";
            this.Text = "CllientForm";
            this.Load += new System.EventHandler(this.CllientForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SSN_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fax_textbox;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox Email_textbox;
        private System.Windows.Forms.Label website;
        private System.Windows.Forms.TextBox website_textbox;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button Add;
    }
}