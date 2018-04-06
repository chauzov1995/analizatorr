using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace App12
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Detail : ContentPage
    {
      
        public MasterDetailPage1Detail()
        {
            InitializeComponent();
           
           
        }
      
    

        protected override void OnAppearing()
        {
            friendsList.ItemsSource = App.Database.GetItems();









            base.OnAppearing();
        }
        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Friend selectedFriend = (Friend)e.SelectedItem;
            FriendPage friendPage = new FriendPage();
            friendPage.BindingContext = selectedFriend;
            await Navigation.PushAsync(friendPage);
        }
        // обработка нажатия кнопки добавления
        private async void CreateFriend(object sender, EventArgs e)
        {
            Friend friend = new Friend();
            FriendPage friendPage = new FriendPage();
            friendPage.BindingContext = friend;
            await Navigation.PushAsync(friendPage);
        }



    }





    [Table("categories")]
    public class categories
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int id { get; set; }

        public int summa_fakt { get; set; }
        public int summa_doh { get; set; }
        public string komment { get; set; }
    }
}