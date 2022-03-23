using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQFinalProject
{
    public class ViewItemsWareHouse
    {
        public int Quantity;
        public string nameOfItem;
        public string NameOfWarehouse;

        public ViewItemsWareHouse(int quantity, string nameOfItem, string nameOfWarehouse)
        {
            Quantity = quantity;
            this.nameOfItem = nameOfItem;
            NameOfWarehouse = nameOfWarehouse;
        }
    }
}
