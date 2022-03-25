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
    public partial class PermitForm : Form
    {
        Linq_EntityProjectEntities5 Database;
        Permit permit = new Permit();
        public PermitForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("in");
            comboBox1.Items.Add("out");
            Database = new Linq_EntityProjectEntities5();
            Client_textbox.Visible = false;
            supplier_combobox.Visible = false;
          
            foreach (var WH in Database.warehouses)
            {

                listBox2.Items.Add($"Name :{WH.Name_warehouse},address :{WH.Address},supervisor:{WH.supervisor}");
                warehouse_combox.Items.Add(WH.Name_warehouse);
            }

            foreach (var client in Database.Clients)
            {
                listBox3.Items.Add($"SSN :{client.Person.SSN},Client Name :{client.Person.Name_person}");
                Client_textbox.Items.Add(client.SSN_Client);


            }

            foreach (var supplier in Database.Suppliers)
            {
                listBox4.Items.Add($"SSN :{supplier.Person.SSN},supplier Name :{supplier.Person.Name_person}");
                supplier_combobox.Items.Add(supplier.SSN_supplier);
            }


            foreach (var item in Database.Items)
            {
                listBox5.Items.Add($"code :{item.Code},item Name :{item.Name_item}");
                item_combobox.Items.Add(item.Code);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "in")
            {
                supplier_combobox.Visible = true;
                Client_textbox.Visible = false;
            }
            else
            {
                Client_textbox.Visible = true;
                supplier_combobox.Visible = false;
            }



        }

        private void PermitForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            permit.id = int.Parse(IdPermition_textbox.Text);
            permit.TypeOfPermision = comboBox1.Text;
            permit.Quantity = quantity_textbox.Text;
            permit.warehouse_fk = warehouse_combox.Text;
            permit.DateOFOperation = DateOfOperation.Value;
            if (comboBox1.Text == "in")
                permit.SSN_supplier = int.Parse(supplier_combobox.Text);
            else
                permit.SSN_Client = int.Parse(Client_textbox.Text);
            permission_item per_item = new permission_item();
            per_item.P_id_fk = permit.id;
            per_item.TypeOfPermision_fk = permit.TypeOfPermision;
            per_item.Code_fk = int.Parse(item_combobox.Text);
            per_item.Duration = -(int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse(ExpiredDateofProduct.Value.ToString("yyyy")));
            per_item.ExpiredDate = ExpiredDateofProduct.Value;
            permit.permission_item.Add(per_item);

            Database.Permits.Add(permit);
            Database.SaveChanges();
        }

        private void warehourse_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void expiredDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Check_is_Enough_in_Store_Click(object sender, EventArgs e)
        {
            //permit.id = int.Parse(IdPermition_textbox.Text);
            permit.TypeOfPermision = comboBox1.Text;
            permit.Quantity = quantity_textbox.Text;
            permit.warehouse_fk = warehouse_combox.Text;

         
                MessageBox.Show(permit.Check_is_Enough_in_Store(new Linq_EntityProjectEntities5(), int.Parse(item_combobox.Text)).ToString());


        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
    
