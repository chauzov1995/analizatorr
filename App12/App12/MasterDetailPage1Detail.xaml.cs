using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App12
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Detail : ContentPage
    {
        public MasterDetailPage1Detail()
        {
            InitializeComponent();
            List<categories> item = new List<categories>();
            item.Add(new categories()
            {
                summa_fakt = "title",
                komment = "subtitle",
                id = "1"

            });
            item.Add(new categories()
            {
                summa_fakt = "title",
                komment = "subtitle",
                id = "2"
            });
            item.Add(new categories()
            {
                summa_fakt = "title",
                komment = "subtitle",
                id = "3"
            });
            listView.ItemsSource = item;
        }
        private void uchet_add(object sender, EventArgs e)
        {
          //  (sender as Button).Parent. "Нажато!!!";
            uchet.Text = "Нажато!!!";
        }
    }

    public class categories
    {

        public string summa_fakt { get; set; }
        public string summa_doh { get; set; }
        public string komment { get; set; }
        public string id { get; set; }
    }
}