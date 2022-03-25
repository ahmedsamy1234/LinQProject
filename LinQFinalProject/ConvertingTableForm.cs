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
    public partial class ConvertingTableForm : Form
    {
        Linq_EntityProjectEntities5 Database;
        Ware_to_from_Item form_to_items;
        public ConvertingTableForm()
        {
            InitializeComponent();
             form_to_items=new Ware_to_from_Item(); 
            Database = new Linq_EntityProjectEntities5();
                foreach (var WH in Database.warehouses)
                {

                   // listBox2.Items.Add($"Name :{WH.Name_warehouse},address :{WH.Address},supervisor:{WH.supervisor}");
                    fromWareHouse.Items.Add(WH.Name_warehouse);
                    TowareHouse.Items.Add(WH.Name_warehouse);
                 }


            foreach (var item in Database.Items)
            {
                ItemFromtoItem.Items.Add(item.Code);
            }
        }

        private void ConvertingTableForm_Load(object sender, EventArgs e)
        {

        }

        private void Check_is_Enough_in_Store_Click(object sender, EventArgs e)
        {
            form_to_items.WhhouseFrom = fromWareHouse.Text;
            form_to_items.WhhouseTo = TowareHouse.Text;

            form_to_items.DateOfoperation = DateOfOperation.Value;

            form_to_items.Quantity = int.Parse(QuantityFromToComboBox.Text);
            form_to_items.item_fk = int.Parse(ItemFromtoItem.Text);
            MessageBox.Show((form_to_items.Check_is_Enough_in_StoreBasedOnDate(Database).ToString()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_to_items.WhhouseFrom = fromWareHouse.Text;
            form_to_items.WhhouseTo = TowareHouse.Text;

            form_to_items.DateOfoperation = DateOfOperation.Value;

            form_to_items.Quantity = int.Parse(QuantityFromToComboBox
                .Text);
            form_to_items.item_fk = int.Parse(ItemFromtoItem.Text);

            if (form_to_items.Check_is_Enough_in_StoreBasedOnDate(Database))
            {
                //Database.SaveChanges();
                MessageBox.Show("Value inserted Succefully");
                

            }else

            {

                MessageBox.Show("Quantity of this item is not Enough");
            }

        }
    }
}
