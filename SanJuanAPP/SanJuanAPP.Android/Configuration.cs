using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SanJuanAPP.Interfaces;
using Xamarin.Forms;
using SQLite.Net.Interop;

[assembly: Dependency(typeof(SanJuanAPP.Droid.Configuration))]
namespace SanJuanAPP.Droid
{
    public class Configuration : IConfiguration
    {
        private string Directorio;
        private ISQLitePlatform Plataforma;

        public string directorio
        {
            get
            {
                if (string.IsNullOrEmpty(Directorio))
                {
                    Directorio = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                }
                return Directorio;
            }
        }

        public ISQLitePlatform platform
        {
            get
            {
                if (Plataforma == null)
                {
                    Plataforma = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroidN();
                }
                return Plataforma;
            }
        }
    }
}