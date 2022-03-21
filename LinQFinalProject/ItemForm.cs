using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace LinQFinalProject
{
    public partial class ItemForm : Form
    {
        Linq_EntityProjectEntities4 Database;
        public ItemForm()
        {
            InitializeComponent();
            Database= new Linq_EntityProjectEntities4();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void website_textbox_Enter(object sender, EventArgs e)
        {

        }

        private void website_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBox1.Items.Add(unit_textbox.Text);
                     unit_textbox.Text = string.Empty;
                MessageBox.Show("Enter pressed");
            }
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {

            foreach (var item in Database.Items)
            {
                comboBox1.Items.Add(item.Code);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = Database.Items.Find(int.Parse(comboBox1.Text));

            if (item != null)

            {
                Code_textBox.Text = item.Code.ToString();
                Name_textbox.Text = item.Name_item.ToString();
                listBox1.Items.Clear();

                foreach (var item_unit in item.item_unit)
                    listBox1.Items.Add((string)item_unit.unit);
              
            }

        }

        private void Code_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Code_textBox_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Clear();
            Code_textBox.Text = string.Empty;
            Name_textbox.Text = string.Empty;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Item item = new Item();

            item.Code = int.Parse(Code_textBox.Text);
            item.Name_item = Name_textbox.Text;
            foreach (string myunit in listBox1.Items)
            {
                item_unit item_unit = new item_unit();
                item_unit.unit = myunit;
                item_unit.Code_fk = int.Parse(Code_textBox.Text);
                item.item_unit.Add(item_unit);
            }
            Database.Items.Add(item);


            Database.SaveChanges();
            MessageBox.Show("fdsf");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int code = int.Parse(comboBox1.Text);

            Item item = Database.Items.Find(code);
            Database.Items.Remove(item);
            comboBox1.Items.Remove(code);
            Database.SaveChanges();
            Code_textBox.Text = Name_textbox.Text = string.Empty;
            listBox1.Items.Clear();

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int code = int.Parse(comboBox1.Text);
            Item item = Database.Items.Find(code);

            item.Code = int.Parse(Code_textBox.Text);
            item.Name_item = Name_textbox.Text;
            foreach (string myunit in listBox1.Items)
            {
                item.item_unit.Clear();
                item_unit item_unit = new item_unit();
                item_unit.unit = myunit;
                item_unit.Code_fk = int.Parse(Code_textBox.Text);
                item.item_unit.Add(item_unit);
            }


            Database.SaveChanges();
            Code_textBox.Text = Name_textbox.Text = string.Empty;
            listBox1.Items.Clear();
        }
    }
}
