using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace Vertshoplibrary
{
    public static class utility

    {
        public static int AddedQuantity(int remainingquntity, int newquantity)
        {
           
            int totalquntity = remainingquntity + newquantity;
            return totalquntity;
        }

        public static int Stock(int remainingquntity, int newquantity)
        {

            int totalquntity = remainingquntity - newquantity;
            return totalquntity;
        }
    }
}
