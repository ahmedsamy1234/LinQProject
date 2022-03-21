using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQFinalProject
{
    public partial class warehouseForm : Form
    {
        Linq_EntityProjectEntities4 Database;

        public warehouseForm()
        {
            InitializeComponent();
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            warehouse WH = Database.warehouses.Find(comboBox1.Text);

            if (WH != null)

            {
                name_textBox.Text = WH.Name_warehouse;
                address_textbox.Text = WH.Address;
                supervisor_textbox.Text = WH.supervisor;
              
            }
        }

        private void warehouseForm_Load(object sender, EventArgs e)
        {
            Database = new Linq_EntityProjectEntities4();
            foreach (var warehouse in Database.warehouses)
            {
                comboBox1.Items.Add(warehouse.Name_warehouse);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            warehouse WH = new warehouse();


            WH.Name_warehouse = name_textBox.Text;
            WH.Address = address_textbox.Text;
            WH.supervisor = supervisor_textbox.Text;
      
            Database.warehouses.Add(WH);
            Database.SaveChanges();
            address_textbox.Text = name_textBox.Text = supervisor_textbox.Text = string.Empty;
            comboBox1.Items.Add(WH.Name_warehouse);

        }

        private void delete_Click(object sender, EventArgs e)
        {
            string name  = (comboBox1.Text);

            warehouse WH = Database.warehouses.Find(name);
            Database.warehouses.Remove(WH);
            
            comboBox1.Items.Remove(WH.Name_warehouse);
            Database.SaveChanges();
            address_textbox.Text = name_textBox.Text = supervisor_textbox.Text = string.Empty;
        }
    }
}
