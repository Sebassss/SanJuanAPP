using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SanJuanAPP.ViewModels;
namespace SanJuanAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DptosList : ContentPage
    {
        public DptosList()
        {
            InitializeComponent();
            DptosViewModel lst = new DptosViewModel();
            lst.llenarListado();
            LIST.ItemsSource = lst.List;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var imageSender = (Label)sender;
            Navigation.PushModalAsync(new Views.CapsDetail(imageSender.ClassId.ToString()));
        }
    }
}