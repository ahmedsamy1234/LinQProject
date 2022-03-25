namespace LinQFinalProject
{
    partial class ConvertingTableForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.DateOfOperation = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Check_is_Enough_in_Store = new System.Windows.Forms.Button();
            this.fromWareHouse = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.QuantityFromToComboBox = new System.Windows.Forms.TextBox();
            this.ItemFromtoItem = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TowareHouse = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "DateOfOperation";
            // 
            // DateOfOperation
            // 
            this.DateOfOperation.Location = new System.Drawing.Point(303, 144);
            this.DateOfOperation.Name = "DateOfOperation";
            this.DateOfOperation.Size = new System.Drawing.Size(184, 20);
            this.DateOfOperation.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "WareHouseFrom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Item";
            // 
            // Check_is_Enough_in_Store
            // 
            this.Check_is_Enough_in_Store.Location = new System.Drawing.Point(559, 201);
            this.Check_is_Enough_in_Store.Name = "Check_is_Enough_in_Store";
            this.Check_is_Enough_in_Store.Size = new System.Drawing.Size(138, 23);
            this.Check_is_Enough_in_Store.TabIndex = 74;
            this.Check_is_Enough_in_Store.Text = "Check Enough in Store";
            this.Check_is_Enough_in_Store.UseVisualStyleBackColor = true;
            this.Check_is_Enough_in_Store.Click += new System.EventHandler(this.Check_is_Enough_in_Store_Click);
            // 
            // fromWareHouse
            // 
            this.fromWareHouse.FormattingEnabled = true;
            this.fromWareHouse.Location = new System.Drawing.Point(135, 26);
            this.fromWareHouse.Name = "fromWareHouse";
            this.fromWareHouse.Size = new System.Drawing.Size(184, 21);
            this.fromWareHouse.TabIndex = 72;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuantityFromToComboBox
            // 
            this.QuantityFromToComboBox.Location = new System.Drawing.Point(303, 112);
            this.QuantityFromToComboBox.Name = "QuantityFromToComboBox";
            this.QuantityFromToComboBox.Size = new System.Drawing.Size(184, 20);
            this.QuantityFromToComboBox.TabIndex = 66;
            // 
            // ItemFromtoItem
            // 
            this.ItemFromtoItem.FormattingEnabled = true;
            this.ItemFromtoItem.Location = new System.Drawing.Point(303, 73);
            this.ItemFromtoItem.Name = "ItemFromtoItem";
            this.ItemFromtoItem.Size = new System.Drawing.Size(184, 21);
            this.ItemFromtoItem.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "Warehouse";
            // 
            // TowareHouse
            // 
            this.TowareHouse.FormattingEnabled = true;
            this.TowareHouse.Location = new System.Drawing.Point(485, 26);
            this.TowareHouse.Name = "TowareHouse";
            this.TowareHouse.Size = new System.Drawing.Size(184, 21);
            this.TowareHouse.TabIndex = 84;
            // 
            // ConvertingTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TowareHouse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DateOfOperation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Check_is_Enough_in_Store);
            this.Controls.Add(this.fromWareHouse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QuantityFromToComboBox);
            this.Controls.Add(this.ItemFromtoItem);
            this.Name = "ConvertingTableForm";
            this.Text = "ConvertingTableForm";
            this.Load += new System.EventHandler(this.ConvertingTableForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DateOfOperation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Check_is_Enough_in_Store;
        private System.Windows.Forms.ComboBox fromWareHouse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox QuantityFromToComboBox;
        private System.Windows.Forms.ComboBox ItemFromtoItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox TowareHouse;
    }
}