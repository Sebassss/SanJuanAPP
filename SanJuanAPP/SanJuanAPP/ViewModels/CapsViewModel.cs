using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SanJuanAPP.Models;
using SanJuanAPP.Classes;
using System.Collections.ObjectModel;

namespace SanJuanAPP.ViewModels
{
    class CapsViewModel : CapsModel
    {
        private ObservableCollection<CapsModel> listado;

        public ObservableCollection<CapsModel> List
        {
            get
            {
                if (listado == null)
                {
                    llenarListado();
                }
                return listado;

            }
            set
            {
                listado = value;
            }
        }

        public void llenarListado()
        {
            using (var contexto = new dbContext())
            {
                ObservableCollection<CapsModel> modelo = new ObservableCollection<CapsModel>(contexto.getAll<CapsModel>().ToList());
                listado = modelo;
            }

        }
    }
}
