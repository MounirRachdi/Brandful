using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Brandful.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        
        public MainPage()
        {


            ListOfShop ShopList;
            InitializeComponent();
            ShopList = new ListOfShop();
            ListView1.ItemsSource = ShopList.GetItems();
        }

        private void Item_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var Item = e.SelectedItem as ListShop;
           
            if (Item.Title.Equals("My ACCOUNT"))
            {

                Detail = new  MyAccountPage();
                IsPresented = false;
            }


            else
               if (Item.Title.Equals("SHOP"))
            {
                Detail = new ShopPage();
                IsPresented = false;
            }
            else
               if (Item.Title.Equals("FAQ"))
            {
                Detail = new FAQPage();
                IsPresented = false;
            }
            else
               if (Item.Title.Equals("NOTIFICATIONS"))
            {
                Detail = new NotificationsPage();
                IsPresented = false;
            }

        }
    }
}