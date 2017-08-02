using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SanJuanAPP.Classes;
using SanJuanAPP.Models;
using SanJuanAPP.ViewModels;
using System.Net.Http;

using SanJuanAPP.Interfaces;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using CarouselView;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace SanJuanAPP
{
    public partial class MainPage : ContentPage
    {

       

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Waiting some time
            await Task.Delay(2000);

            // Start animation
            await Task.WhenAll(
                SplashGrid.FadeTo(0, 2000),
                Logo.ScaleTo(10, 2000)
                );

            await Navigation.PushModalAsync(new Views.Home());

        }

        public MainPage()
        {
            InitializeComponent();
        

        }





       

    }
}
