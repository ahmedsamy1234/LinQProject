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
        public Form1()
        {
            InitializeComponent();
        }

        private void add_client_Click(object sender, EventArgs e)
        {
            Linq_EntityProjectEntities5 Database = new Linq_EntityProjectEntities5();
            foreach(Person person in  Database.People)
            {

                listBox1.Items.Add($"{person.Name_person}  {person.fax}   {person.Email}");
            }



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
