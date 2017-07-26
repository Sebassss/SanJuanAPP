using System;
using System.Collections.Generic;
using System.Text;
using SanJuanAPP.Interfaces;
using System.IO;
using Xamarin.Forms;
using SQLite.Net.Interop;

[assembly: Dependency(typeof(SanJuanAPP.iOS.Configuration))]
namespace SanJuanAPP.iOS
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
                    var dir = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    Directorio = Path.Combine(dir, "..", "Library");
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
                    Plataforma = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
                }
                return Plataforma;
            }
        }
    }
}
