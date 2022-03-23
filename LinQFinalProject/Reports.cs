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
    public partial class Reports : Form
    {
       DataTable DataTableReport1;

        DataTable DataTableReport2;

        Linq_EntityProjectEntities4 Database;
        public Reports()
        {
            InitializeComponent();
          

            DataTableReport1 = new DataTable();
            Database = new Linq_EntityProjectEntities4();
            DataTableReport1.Columns.Add(new DataColumn("Name_Of_Item"));
            DataTableReport1.Columns.Add(new DataColumn("Quantity"));
            dataGridView1.DataSource = DataTableReport1;
            
            foreach (var warehouse in Database.warehouses)
            {
                wareHouses.Items.Add(warehouse.Name_warehouse);
            }



            DataTableReport2= new DataTable();
            Database = new Linq_EntityProjectEntities4();
            DataTableReport2.Columns.Add(new DataColumn("Name_ofStore"));
            DataTableReport2.Columns.Add(new DataColumn("Quantity"));
            dataGridView2.DataSource = DataTableReport2;

            foreach (var item in Database.Items)
            {
                SelectedItem.Items.Add(item.Code);
            }




        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void SelectedItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTableReport2.Rows.Clear();

            foreach (ViewItemsWareHouse tuple in Item.FindQuantityOfSelectedItemInAllStores(Database,int.Parse(SelectedItem.Text),fromDateOfSelectedItem.Value,toDateOfSelectedItem.Value))
                {


                DataRow drToAdd = DataTableReport2.NewRow();
                drToAdd["Name_ofStore"] = tuple.NameOfWarehouse;
                drToAdd["Quantity"] = tuple.Quantity;

                DataTableReport2.Rows.Add(drToAdd);
            }
            DataTableReport2.AcceptChanges();
            dataGridView1.DataSource = DataTableReport2;
        }

        private void wareHouses_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTableReport1.Rows.Clear();

            foreach (var tuple in warehouse.FindQuantityOfEachItemInStrore(Database, wareHouses.Text, FromDatePicker.Value, toDatePicker.Value))
            {


                DataRow drToAdd = DataTableReport1.NewRow();
                drToAdd["Name_Of_Item"] = tuple.Item2;
                drToAdd["Quantity"] = tuple.Item1;

                DataTableReport1.Rows.Add(drToAdd);
            }
            DataTableReport1.AcceptChanges();
            dataGridView1.DataSource = DataTableReport1;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
