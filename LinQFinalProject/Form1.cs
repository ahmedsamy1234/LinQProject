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
    public partial class Form1 : Form
    {
        Linq_EntityProjectEntities5 Database = new Linq_EntityProjectEntities5();

        public Form1()
        {
            InitializeComponent();
        }

        private void add_client_Click(object sender, EventArgs e)
        {
            CllientForm clientForm = new CllientForm();
            this.Hide();
            clientForm.Show();



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            warehouseForm warehouse = new warehouseForm();
            warehouse.Show();
                this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupplierForm supplier = new SupplierForm();
            supplier.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PermitForm permitForm = new PermitForm();
            permitForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConvertingTableForm convertingTableForm = new ConvertingTableForm();
            convertingTableForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Hide();
        }
    }
}
