using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQFinalProject
{
    class ItemPerWareHouse
    {

      public int CodeOfOItem;
      public String NameOfitem;
        public int  Quantity;

        public ItemPerWareHouse(int codeOfOItem, string nameOfitem, int quantity)
        {
            CodeOfOItem = codeOfOItem;
            NameOfitem = nameOfitem;
            Quantity = quantity;
        }
    }
}
