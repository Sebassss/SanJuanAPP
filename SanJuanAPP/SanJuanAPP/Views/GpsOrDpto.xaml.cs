using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SanJuanAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GpsOrDpto : ContentPage
    {
        public GpsOrDpto()
        {
            InitializeComponent();
        }

        private void Button_btnDptosList_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Views.DptosList());
        }

        private void btnListDptos()
        {
            //((NavigationPage)this.Parent).PushAsync(new Views.Ayuda());
            Navigation.PushModalAsync(new Views.DptosList());
        }

        private void btnGPS()
        {
            //((NavigationPage)this.Parent).PushAsync(new Views.Ayuda());
            Navigation.PushModalAsync(new Views.Gps());
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            try
            {

                if (sender.GetType() == typeof(Image))
                {
                    var imageSender = (Image)sender;

                    switch (imageSender.ClassId)
                    {
                        case "btnListDptos":
                            {
                                btnListDptos();
                            }
                            break;

                        case "btnGps":
                            {
                                btnGPS();
                            }
                            break;
                    }
                }
                else
                {
                    var imageSender = (Label)sender;

                    switch (imageSender.ClassId)
                    {
                        case "btnListDptos":
                            {
                                btnListDptos();
                            }
                            break;

                        case "btnGps":
                            {
                                btnGPS();
                            }
                            break;
                    }
                }


            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }

        }
    }
}
