using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SanJuanAPP.ViewModels;
using SanJuanAPP.Models;
using SanJuanAPP.Classes;
using System.Collections;
using System.Collections.ObjectModel;

namespace SanJuanAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CapsList : ContentPage
    {
        public CapsList(string dpto)
        {
            InitializeComponent();
            //CapsViewModel lst = new CapsViewModel();
            //lst.llenarListado();
            
            //LIST.ItemsSource = lst.List;
            
            dbContext db = new dbContext();
            
            CapsModel model = new CapsModel();
            int x = Int32.Parse(dpto);

            var query = db.getAll<CapsModel>().ToList().Where(r => r.DEPTO == x); 

            

            LIST.ItemsSource = query.ToList();
        }
    }
}
