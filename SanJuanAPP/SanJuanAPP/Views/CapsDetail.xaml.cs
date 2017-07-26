using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SanJuanAPP.ViewModels;
using SanJuanAPP.Classes;
using SanJuanAPP.Models;

namespace SanJuanAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CapsDetail : ContentPage
    {

        public CapsDetail(string csId)
        {
            InitializeComponent();
            lbl_nombre.Text = csId;
        }


        public void Detalle(string csId)
        {
            dbContext db = new dbContext();
            CapsModel model = new CapsModel();
            int x = Int32.Parse(csId);

            var query = db.getAll<CapsModel>().ToList().Where(r => r.DEPTO == x);

            
            lbl_nombre.Text = model.NOMBRE;
            lbl_direccion.Text = model.DIRECCION;
            lbl_latitud.Text = model.LATITUD;
            lbl_longitud.Text = model.LONGITUD;
            lbl_telefono.Text = model.TELEFONO;


        }
    }
}