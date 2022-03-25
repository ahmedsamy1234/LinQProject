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
    public partial class SupplierForm : Form
    {
        Linq_EntityProjectEntities5 Database;
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            Person person = new Person();
            supplier.Person = person;

            supplier.Person.SSN = int.Parse(SSN_textBox.Text);
            supplier.Person.Email = Email_textbox.Text;
            supplier.Person.fax = fax_textbox.Text;
            supplier.Person.Website = website_textbox.Text;
            supplier.Person.phone = phone_textbox.Text;
            supplier.Person.Name_person = NameTextbox.Text;
            Database.People.Add(person);
            Database.Suppliers.Add(supplier);
            Database.SaveChanges();



            Email_textbox.Text = fax_textbox.Text = website_textbox.Text = phone_textbox.Text = NameTextbox.Text = SSN_textBox.Text = string.Empty;

        }

        private void _ٍSupplier_Load(object sender, EventArgs e)
        {
            Database = new Linq_EntityProjectEntities5();
            foreach (var supplier in Database.Suppliers)
            {
                comboBox1.Items.Add(supplier.Person.SSN);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int SSN = int.Parse(comboBox1.Text);

            Supplier supplier = Database.Suppliers.Find(SSN);
            Database.People.Remove(Database.People.Find(SSN));
            Database.Suppliers.Remove(supplier);
            comboBox1.Items.Remove(SSN);
            Database.SaveChanges();
            Email_textbox.Text = fax_textbox.Text = website_textbox.Text = phone_textbox.Text = NameTextbox.Text = SSN_textBox.Text = string.Empty;

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int SSN = int.Parse(comboBox1.Text);

            Supplier supplier = Database.Suppliers.Find(SSN);
            supplier.Person.fax = fax_textbox.Text;
            supplier.Person.SSN = int.Parse(SSN_textBox.Text);
            supplier.Person.Email = Email_textbox.Text;
            supplier.Person.Website = website_textbox.Text;
            supplier.Person.phone = phone_textbox.Text;
            supplier.Person.Name_person = NameTextbox.Text;
            Database.SaveChanges();

            comboBox1.Items.Add(SSN);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier supplier = Database.Suppliers.Find(int.Parse(comboBox1.Text));

            if (supplier != null)

            {
                fax_textbox.Text = supplier.Person.fax;
                SSN_textBox.Text = supplier.Person.SSN.ToString();
                Email_textbox.Text = supplier.Person.Email;
                website_textbox.Text = supplier.Person.Website;
                phone_textbox.Text = supplier.Person.phone;
                NameTextbox.Text = supplier.Person.Name_person;
            }

        }
    }
}
