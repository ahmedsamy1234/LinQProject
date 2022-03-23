namespace LinQFinalProject
{
    partial class PermitForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.IdPermition_textbox = new System.Windows.Forms.TextBox();
            this.quantity_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.supplier_combobox = new System.Windows.Forms.ComboBox();
            this.Client_textbox = new System.Windows.Forms.ComboBox();
            this.item_combobox = new System.Windows.Forms.ComboBox();
            this.warehouse_combox = new System.Windows.Forms.ComboBox();
            this.ExpiredDateofProduct = new System.Windows.Forms.DateTimePicker();
            this.Check_is_Enough_in_Store = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateOfOperation = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(481, 327);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(516, 95);
            this.listBox5.TabIndex = 41;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(481, 226);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(516, 95);
            this.listBox4.TabIndex = 40;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(481, 125);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(516, 95);
            this.listBox3.TabIndex = 39;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(481, 24);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(516, 95);
            this.listBox2.TabIndex = 38;
            // 
            // IdPermition_textbox
            // 
            this.IdPermition_textbox.Location = new System.Drawing.Point(126, 42);
            this.IdPermition_textbox.Name = "IdPermition_textbox";
            this.IdPermition_textbox.Size = new System.Drawing.Size(184, 20);
            this.IdPermition_textbox.TabIndex = 42;
            this.IdPermition_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // quantity_textbox
            // 
            this.quantity_textbox.Location = new System.Drawing.Point(126, 150);
            this.quantity_textbox.Name = "quantity_textbox";
            this.quantity_textbox.Size = new System.Drawing.Size(184, 20);
            this.quantity_textbox.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // supplier_combobox
            // 
            this.supplier_combobox.FormattingEnabled = true;
            this.supplier_combobox.Location = new System.Drawing.Point(126, 226);
            this.supplier_combobox.Name = "supplier_combobox";
            this.supplier_combobox.Size = new System.Drawing.Size(184, 21);
            this.supplier_combobox.TabIndex = 48;
            // 
            // Client_textbox
            // 
            this.Client_textbox.FormattingEnabled = true;
            this.Client_textbox.Location = new System.Drawing.Point(126, 264);
            this.Client_textbox.Name = "Client_textbox";
            this.Client_textbox.Size = new System.Drawing.Size(184, 21);
            this.Client_textbox.TabIndex = 49;
            // 
            // item_combobox
            // 
            this.item_combobox.FormattingEnabled = true;
            this.item_combobox.Location = new System.Drawing.Point(126, 77);
            this.item_combobox.Name = "item_combobox";
            this.item_combobox.Size = new System.Drawing.Size(184, 21);
            this.item_combobox.TabIndex = 50;
            // 
            // warehouse_combox
            // 
            this.warehouse_combox.FormattingEnabled = true;
            this.warehouse_combox.Location = new System.Drawing.Point(126, 114);
            this.warehouse_combox.Name = "warehouse_combox";
            this.warehouse_combox.Size = new System.Drawing.Size(184, 21);
            this.warehouse_combox.TabIndex = 51;
            // 
            // ExpiredDateofProduct
            // 
            this.ExpiredDateofProduct.Location = new System.Drawing.Point(126, 186);
            this.ExpiredDateofProduct.Name = "ExpiredDateofProduct";
            this.ExpiredDateofProduct.Size = new System.Drawing.Size(184, 20);
            this.ExpiredDateofProduct.TabIndex = 54;
            this.ExpiredDateofProduct.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Check_is_Enough_in_Store
            // 
            this.Check_is_Enough_in_Store.Location = new System.Drawing.Point(325, 148);
            this.Check_is_Enough_in_Store.Name = "Check_is_Enough_in_Store";
            this.Check_is_Enough_in_Store.Size = new System.Drawing.Size(138, 23);
            this.Check_is_Enough_in_Store.TabIndex = 55;
            this.Check_is_Enough_in_Store.Text = "Check Enough in Store";
            this.Check_is_Enough_in_Store.UseVisualStyleBackColor = true;
            this.Check_is_Enough_in_Store.Click += new System.EventHandler(this.Check_is_Enough_in_Store_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Id of permission";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Warehouse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Expired Date ";
            // 
            // DateOfOperation
            // 
            this.DateOfOperation.Location = new System.Drawing.Point(126, 301);
            this.DateOfOperation.Name = "DateOfOperation";
            this.DateOfOperation.Size = new System.Drawing.Size(184, 20);
            this.DateOfOperation.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "DateOfOperation";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 65;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PermitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DateOfOperation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Check_is_Enough_in_Store);
            this.Controls.Add(this.ExpiredDateofProduct);
            this.Controls.Add(this.warehouse_combox);
            this.Controls.Add(this.item_combobox);
            this.Controls.Add(this.Client_textbox);
            this.Controls.Add(this.supplier_combobox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quantity_textbox);
            this.Controls.Add(this.IdPermition_textbox);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "PermitForm";
            this.Text = "02";
            this.Load += new System.EventHandler(this.PermitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox IdPermition_textbox;
        private System.Windows.Forms.TextBox quantity_textbox;
        private System.Windows.Forms.Button button1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.ComboBox supplier_combobox;
        private System.Windows.Forms.ComboBox Client_textbox;
        private System.Windows.Forms.ComboBox item_combobox;
        private System.Windows.Forms.ComboBox warehouse_combox;
        private System.Windows.Forms.DateTimePicker ExpiredDateofProduct;
        private System.Windows.Forms.Button Check_is_Enough_in_Store;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateOfOperation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}