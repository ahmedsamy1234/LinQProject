using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQFinalProject
{
    public static  class helperfunction
    {

        public static List<ViewItemsWareHouse> FindQuantityOfSelectedItemInAllStores(this Item myitem ,Linq_EntityProjectEntities5 Database, int codeOfItem, DateTime from, DateTime to)
        {
            List<ViewItemsWareHouse> QuantityPerStore = new List<ViewItemsWareHouse>();
            foreach (var WH in Database.warehouses)
            {
                int totalQuantity = 0;
                foreach (Permit permit in Database.Permits)

                {

                    int afterDateFrom = DateTime.Compare((DateTime)permit.DateOFOperation, from);
                    int beforeDateTo = DateTime.Compare((DateTime)permit.DateOFOperation, to);
                    if (WH.Name_warehouse == permit.warehouse_fk && afterDateFrom > 0 && beforeDateTo < 0)

                    {
                        foreach (var item in permit.permission_item)
                        {
                            if (item.P_id_fk == permit.id && item.Code_fk == codeOfItem)
                            {
                                if (item.TypeOfPermision_fk == "in")
                                    totalQuantity = totalQuantity + int.Parse(permit.Quantity);

                                if (item.TypeOfPermision_fk == "out")
                                    totalQuantity = totalQuantity - int.Parse(permit.Quantity);


                            }
                        }
                    }




                }

                QuantityPerStore.Add(new ViewItemsWareHouse(totalQuantity, Database.Items.Find(codeOfItem).Name_item, WH.Name_warehouse));




            }
            return QuantityPerStore;
        }
    
    public static bool Check_is_Enough_in_StoreBasedOnDate(this Ware_to_from_Item selectedWH, Linq_EntityProjectEntities5 Database)
        {
            int totalQuantity = 0;
            foreach (Permit permit in Database.Permits)

            {

              //  int afterDateFrom = DateTime.Compare((DateTime)permit.DateOFOperation, from);
                int IsbeforeThisDate= DateTime.Compare(  (DateTime)permit.DateOFOperation, (DateTime)selectedWH.DateOfoperation);

                if (selectedWH.WhhouseFrom == permit.warehouse_fk && IsbeforeThisDate < 0)

                {


                    // System.Windows.Forms.MessageBox.Show("dsfdsf");
                    foreach (var item in permit.permission_item)
                    {
                        if (item.P_id_fk == permit.id && item.Code_fk == selectedWH.item_fk)
                        {
                            if (item.TypeOfPermision_fk == "in")
                                totalQuantity = totalQuantity + int.Parse(permit.Quantity);

                            if (item.TypeOfPermision_fk == "out")
                                totalQuantity = totalQuantity - int.Parse(permit.Quantity);


                        }
                    }
                }


            }
            if (totalQuantity - selectedWH.Quantity > 0)
            {
                return true;

            }
            else
                return false;
        }
        public static bool Check_is_Enough_in_StoreBasedOnDate(this Permit selectedPermit, Linq_EntityProjectEntities5 Database, int code, DateTime from,DateTime to)
        {
            int totalQuantity = 0;
            foreach (Permit permit in Database.Permits)

            {

                int afterDateFrom = DateTime.Compare((DateTime)permit.DateOFOperation, from);
                int beforeDateTo = DateTime.Compare((DateTime)permit.DateOFOperation, to);
        
                    if (selectedPermit.warehouse_fk == permit.warehouse_fk && afterDateFrom > 0 && beforeDateTo < 0)

                {


                    // System.Windows.Forms.MessageBox.Show("dsfdsf");
                    foreach (var item in permit.permission_item)
                    {
                        if (item.P_id_fk == permit.id && item.Code_fk == code)
                        {
                            if (item.TypeOfPermision_fk == "in")
                                totalQuantity = totalQuantity + int.Parse(permit.Quantity);

                            if (item.TypeOfPermision_fk == "out")
                                totalQuantity = totalQuantity - int.Parse(permit.Quantity);


                        }
                    }
                }


            }
            if (totalQuantity - int.Parse(selectedPermit.Quantity) > 0)
            {
                return true;

            }
            else
                return false;
        }
        public static bool Check_is_Enough_in_Store(this Permit selectedPermit ,Linq_EntityProjectEntities5 Database, int code)
        {
            int totalQuantity = 0;
            foreach (Permit permit in Database.Permits)

            {
                if (selectedPermit.warehouse_fk == permit.warehouse_fk)

                {
                    // System.Windows.Forms.MessageBox.Show("dsfdsf");
                    foreach (var item in permit.permission_item)
                    {
                        if (item.P_id_fk == permit.id && item.Code_fk == code)
                        {
                            if (item.TypeOfPermision_fk == "in")
                                totalQuantity = totalQuantity + int.Parse(permit.Quantity);

                            if (item.TypeOfPermision_fk == "out")
                                totalQuantity = totalQuantity - int.Parse(permit.Quantity);


                        }
                    }
                }


            }
            if (totalQuantity - int.Parse(selectedPermit.Quantity) > 0)
            {
                return true;

            }
            else
                return false;
        }



        public static List<(int, string)> FindQuantityOfEachItemInStrore(Linq_EntityProjectEntities5 Database, string nameOfWareWouse, DateTime from, DateTime to)
        {
            List<(int, string)> myitems = new List<(int, string)>();

            foreach (var nameofitem in Database.Items)
            {
                int totalQuantity = 0;
                foreach (Permit permit in Database.Permits)

                {

                    int afterDateFrom = DateTime.Compare((DateTime)permit.DateOFOperation, from);
                    int beforeDateTo = DateTime.Compare((DateTime)permit.DateOFOperation, to);
                    if (nameOfWareWouse == permit.warehouse_fk && afterDateFrom > 0 && beforeDateTo < 0)

                    {




                        // System.Windows.Forms.MessageBox.Show("dsfdsf");
                        foreach (var item in permit.permission_item)
                        {
                            if (item.P_id_fk == permit.id && item.Code_fk == nameofitem.Code)
                            {
                                if (item.TypeOfPermision_fk == "in")
                                    totalQuantity = totalQuantity + int.Parse(permit.Quantity);

                                if (item.TypeOfPermision_fk == "out")
                                    totalQuantity = totalQuantity - int.Parse(permit.Quantity);


                            }
                        }
                    }




                }

                myitems.Add((totalQuantity, nameofitem.Name_item));




            }
            return myitems;
        }

    
    }
}
