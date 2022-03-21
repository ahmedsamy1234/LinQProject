namespace LinQFinalProject
{
    partial class ItemForm
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
            this.unit = new System.Windows.Forms.Label();
            this.unit_textbox = new System.Windows.Forms.TextBox();
            this.Code_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Location = new System.Drawing.Point(37, 173);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(24, 13);
            this.unit.TabIndex = 29;
            this.unit.Text = "unit";
            // 
            // unit_textbox
            // 
            this.unit_textbox.Location = new System.Drawing.Point(102, 166);
            this.unit_textbox.Name = "unit_textbox";
            this.unit_textbox.Size = new System.Drawing.Size(156, 20);
            this.unit_textbox.TabIndex = 28;
            this.unit_textbox.Enter += new System.EventHandler(this.website_textbox_Enter);
            this.unit_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.website_textbox_KeyDown);
            // 
            // Code_textBox
            // 
            this.Code_textBox.Location = new System.Drawing.Point(102, 99);
            this.Code_textBox.Name = "Code_textBox";
            this.Code_textBox.Size = new System.Drawing.Size(156, 20);
            this.Code_textBox.TabIndex = 24;
            this.Code_textBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Code_textBox_MouseClick);
            this.Code_textBox.TextChanged += new System.EventHandler(this.Code_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Code";
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(102, 135);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(156, 20);
            this.Name_textbox.TabIndex = 25;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(102, 202);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 56);
            this.listBox1.TabIndex = 30;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(267, 311);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 33;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(171, 311);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 32;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(78, 311);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 31;
            this.Add.Text = "add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 450);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.unit_textbox);
            this.Controls.Add(this.Code_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name_textbox);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label unit;
        private System.Windows.Forms.TextBox unit_textbox;
        private System.Windows.Forms.TextBox Code_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button Add;
    }
}