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
        DataTable DataTableReport3;

          Linq_EntityProjectEntities5 Database;
        public Reports()
        {
            InitializeComponent();
          

            DataTableReport1 = new DataTable();
            Database = new Linq_EntityProjectEntities5();
            DataTableReport1.Columns.Add(new DataColumn("Name_Of_Item"));
            DataTableReport1.Columns.Add(new DataColumn("Quantity"));
            dataGridView1.DataSource = DataTableReport1;
            
            foreach (var warehouse in Database.warehouses)
            {
                wareHouses.Items.Add(warehouse.Name_warehouse);
            }



            DataTableReport3= new DataTable();
            Database = new Linq_EntityProjectEntities5();
            DataTableReport3.Columns.Add(new DataColumn("Name_ofStore"));
            DataTableReport3.Columns.Add(new DataColumn("Quantity"));
            dataGridView2.DataSource = DataTableReport2;







            DataTableReport3 = new DataTable();
            Database = new Linq_EntityProjectEntities5();
            DataTableReport3.Columns.Add(new DataColumn("nameOfItem"));
            DataTableReport3.Columns.Add(new DataColumn("CodeofItem"));
            DataTableReport3.Columns.Add(new DataColumn("permission_id"));
            DataTableReport3.Columns.Add(new DataColumn("dataofOperation"));
            dataGridViewReport3.DataSource = DataTableReport3;


      
            foreach (var item in Database.Items)
            {
                SelectedItem.Items.Add(item.Code);
            }


            foreach (var item in Database.Items)
            {
                ItemsComboBox.Items.Add(item.Code);
            }


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void SelectedItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTableReport2.Rows.Clear();

            foreach (ViewItemsWareHouse tuple in new Item().FindQuantityOfSelectedItemInAllStores(Database,int.Parse(SelectedItem.Text),fromDateOfSelectedItem.Value,toDateOfSelectedItem.Value))
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

            foreach (var tuple in helperfunction.FindQuantityOfEachItemInStrore(Database, wareHouses.Text, FromDatePicker.Value, toDatePicker.Value))
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void ItemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var res = from item in Database.Items.AsEnumerable()
                      join permissionitem in Database.permission_item.AsEnumerable()
                      on item.Code equals permissionitem.Code_fk


                      join permission in Database.Permits.AsEnumerable()
                      on permissionitem.P_id_fk equals permission.id
                      where
                                  (DateTime.Compare((DateTime)permission.DateOFOperation, timeReport3from.Value) > 0) &&
                                      (DateTime.Compare((DateTime)permission.DateOFOperation, timeReport3To.Value) < 0) && item.Code == int.Parse(ItemsComboBox.Text)


                      select new
                      {
                          nameOfItem = item.Name_item.ToString(),
                          CodeofItem = item.Code.ToString(),
                          permission_id = permission.id.ToString(),
                          dataofOperation = permission.DateOFOperation.ToString()

                      };

            DataTableReport3.Rows.Clear();



            res.ToList().ForEach(item =>
            {
               

                    DataRow drToAdd = DataTableReport3.NewRow();
                    drToAdd["nameOfItem"] = item.nameOfItem;
                    drToAdd["CodeofItem"] = item.CodeofItem;
                    drToAdd["permission_id"] = item.permission_id;
                    drToAdd["dataofOperation"] = item.dataofOperation;

                    DataTableReport3.Rows.Add(drToAdd);
                
                DataTableReport3.AcceptChanges();
                dataGridView1.DataSource = DataTableReport3;
            });
            
            
            





        }
    }
}
