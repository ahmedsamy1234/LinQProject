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
    public partial class CllientForm : Form
    {
        Linq_EntityProjectEntities4 Database;

        public CllientForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CllientForm_Load(object sender, EventArgs e)
        {
             Database = new Linq_EntityProjectEntities4();
            foreach (var client in Database.Clients)
            {
                comboBox1.Items.Add(client.Person.SSN);
            }
          //  this.reportViewer1.RefreshReport();
        }

        private void SSN_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int SSN = int.Parse(comboBox1.Text);


              Client client = Database.Clients.Find(SSN);

            if (client != null)

            {
                fax_textbox.Text = client.Person.fax;
                SSN_textBox.Text = client.Person.SSN.ToString();
                Email_textbox.Text = client.Person.Email;
                website_textbox.Text = client.Person.Website;
                phone_textbox.Text = client.Person.phone;
                NameTextbox.Text = client.Person.Name_person;
            }

        
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Client client= new Client();
            Person person=new Person();
            client.Person = person;

               client.Person.SSN = int.Parse(SSN_textBox.Text);
            client.Person.Email = Email_textbox.Text;
            client.Person.fax = fax_textbox.Text;
            client.Person.Website = website_textbox.Text;
            client.Person.phone = phone_textbox.Text;
            client.Person.Name_person = NameTextbox.Text;
            Database.People.Add(person);
            Database.Clients.Add(client);
            Database.SaveChanges();



            Email_textbox.Text = fax_textbox.Text = website_textbox.Text = phone_textbox.Text = NameTextbox.Text = SSN_textBox.Text = string.Empty;

        }

        private void delete_Click(object sender, EventArgs e)
        {
            int SSN = int.Parse(comboBox1.Text);

            Client client = Database.Clients.Find(SSN);
            Database.People.Remove(Database.People.Find(SSN));
            Database.Clients.Remove(client);
            comboBox1.Items.Remove(SSN);
            Database.SaveChanges();
            Email_textbox.Text = fax_textbox.Text = website_textbox.Text = phone_textbox.Text = NameTextbox.Text = SSN_textBox.Text = string.Empty;


        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int SSN = int.Parse(comboBox1.Text);

            Client client = Database.Clients.Find(SSN);
            client.Person.fax = fax_textbox.Text;
            client.Person.SSN = int.Parse(SSN_textBox.Text);
            client.Person.Email = Email_textbox.Text;
            client.Person.Website = website_textbox.Text;
            client.Person.phone = phone_textbox.Text;
            client.Person.Name_person = NameTextbox.Text;
            Database.SaveChanges();
        }

        private void Name_label_Click(object sender, EventArgs e)
        {

        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_Click(object sender, EventArgs e)
        {

        }

        private void phone_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void Email_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void website_Click(object sender, EventArgs e)
        {

        }

        private void website_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fax_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
