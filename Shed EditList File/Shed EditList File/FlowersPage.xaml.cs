using Android.Opengl;
using Shed_EditList_File.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shed_EditList_File
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlowersPage : ContentPage
    {
        public ObservableCollection<Flower> Flowers { get; set; }
        public Flower SelectedFlower { get; set; }
        public string NameFlower { get; set; }
        public decimal CostFlower {  get; set; }
        bool AddFlowerIs;
        public FlowersPage()
        {
            InitializeComponent();
            BindingContext = this;
            AddForm.IsVisible = false;
            Flowers = BD.GetInstance();
            GetFlowerList();
        }
        void GetFlowerList()
        {
            Flowers = BD.GetInstance();
        }
        private void AddFlower(object sender, EventArgs e)
        {
            AddForm.IsVisible = true;
            if(AddFlowerIs)
            {
                BD Bd = new BD();
                Bd.AddFlower(NameFlower, CostFlower);
                GetFlowerList();
                AddFlowerIs = false;
            }
            
        }

        private async void DeleteFlower(object sender, EventArgs e)
        {
            if(SelectedFlower == null)
            {
                await DisplayAlert("Ошибка", "Выберите товар", "Понял. Исправлюсь. Сохранюсь.");
                return;
            }
            GetFlowerList();
        }

        private async void EditFlower(object sender, EventArgs e)
        {

            if (SelectedFlower == null)
            {
                await DisplayAlert("Ошибка", "Выберите товар", "Понял. Исправлюсь. Сохранюсь.");
                return;
            }
            GetFlowerList();
        }

        private void Save(object sender, EventArgs e)
        {
            AddForm.IsVisible = false;
            AddFlowerIs = true;
        }
    }
}