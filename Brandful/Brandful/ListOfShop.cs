using System;
using System.Collections.Generic;
using System.Text;

namespace Brandful
{
   public class ListOfShop
    {
        public List<ListShop> GetItems()
        {
            List<ListShop> ItemsShop = new List<ListShop>()
            {
                  new ListShop{ Title ="My ACCOUNT"},
                new ListShop{  Title ="SHOP"},
                new ListShop{  Title ="FAQ"},
                new ListShop{  Title ="NOTIFICATIONS",Notification="2"}

            };
            return ItemsShop;
        }
    }
}
