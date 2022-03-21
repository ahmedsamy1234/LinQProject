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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Check_is_Enough_in_Store = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 40);
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
            this.IdPermition_textbox.Location = new System.Drawing.Point(126, 87);
            this.IdPermition_textbox.Name = "IdPermition_textbox";
            this.IdPermition_textbox.Size = new System.Drawing.Size(184, 20);
            this.IdPermition_textbox.TabIndex = 42;
            this.IdPermition_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // quantity_textbox
            // 
            this.quantity_textbox.Location = new System.Drawing.Point(126, 167);
            this.quantity_textbox.Name = "quantity_textbox";
            this.quantity_textbox.Size = new System.Drawing.Size(184, 20);
            this.quantity_textbox.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 387);
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
            this.supplier_combobox.Location = new System.Drawing.Point(126, 211);
            this.supplier_combobox.Name = "supplier_combobox";
            this.supplier_combobox.Size = new System.Drawing.Size(184, 21);
            this.supplier_combobox.TabIndex = 48;
            // 
            // Client_textbox
            // 
            this.Client_textbox.FormattingEnabled = true;
            this.Client_textbox.Location = new System.Drawing.Point(126, 258);
            this.Client_textbox.Name = "Client_textbox";
            this.Client_textbox.Size = new System.Drawing.Size(184, 21);
            this.Client_textbox.TabIndex = 49;
            // 
            // item_combobox
            // 
            this.item_combobox.FormattingEnabled = true;
            this.item_combobox.Location = new System.Drawing.Point(126, 125);
            this.item_combobox.Name = "item_combobox";
            this.item_combobox.Size = new System.Drawing.Size(184, 21);
            this.item_combobox.TabIndex = 50;
            // 
            // warehouse_combox
            // 
            this.warehouse_combox.FormattingEnabled = true;
            this.warehouse_combox.Location = new System.Drawing.Point(126, 300);
            this.warehouse_combox.Name = "warehouse_combox";
            this.warehouse_combox.Size = new System.Drawing.Size(184, 21);
            this.warehouse_combox.TabIndex = 51;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 346);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker1.TabIndex = 54;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Check_is_Enough_in_Store
            // 
            this.Check_is_Enough_in_Store.Location = new System.Drawing.Point(328, 164);
            this.Check_is_Enough_in_Store.Name = "Check_is_Enough_in_Store";
            this.Check_is_Enough_in_Store.Size = new System.Drawing.Size(138, 23);
            this.Check_is_Enough_in_Store.TabIndex = 55;
            this.Check_is_Enough_in_Store.Text = "Check Enough in Store";
            this.Check_is_Enough_in_Store.UseVisualStyleBackColor = true;
            this.Check_is_Enough_in_Store.Click += new System.EventHandler(this.Check_is_Enough_in_Store_Click);
            // 
            // PermitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.Check_is_Enough_in_Store);
            this.Controls.Add(this.dateTimePicker1);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Check_is_Enough_in_Store;
    }
}