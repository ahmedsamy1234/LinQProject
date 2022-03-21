namespace LinQFinalProject
{
    partial class warehouseForm
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
            this.unit = new System.Windows.Forms.Label();
            this.supervisor_textbox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(242, 233);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 44;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(146, 233);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 43;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(53, 233);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 42;
            this.Add.Text = "add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Location = new System.Drawing.Point(50, 182);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(55, 13);
            this.unit.TabIndex = 40;
            this.unit.Text = "supervisor";
            // 
            // supervisor_textbox
            // 
            this.supervisor_textbox.Location = new System.Drawing.Point(115, 175);
            this.supervisor_textbox.Name = "supervisor_textbox";
            this.supervisor_textbox.Size = new System.Drawing.Size(156, 20);
            this.supervisor_textbox.TabIndex = 39;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(115, 105);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(156, 20);
            this.name_textBox.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Address";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Name";
            // 
            // address_textbox
            // 
            this.address_textbox.Location = new System.Drawing.Point(115, 140);
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(156, 20);
            this.address_textbox.TabIndex = 36;
            // 
            // warehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.supervisor_textbox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.address_textbox);
            this.Name = "warehouseForm";
            this.Text = "warehouseForm";
            this.Load += new System.EventHandler(this.warehouseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label unit;
        private System.Windows.Forms.TextBox supervisor_textbox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox address_textbox;
    }
}