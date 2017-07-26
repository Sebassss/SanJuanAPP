using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SanJuanAPP.Models;
using SanJuanAPP.Classes;

namespace SanJuanAPP.ViewModels
{
    class DptosViewModel : DptosModel
    {
        private ObservableCollection<DptosModel> listado;

        public ObservableCollection<DptosModel> List
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
                ObservableCollection<DptosModel> modelo = new ObservableCollection<DptosModel>(contexto.getAll<DptosModel>().ToList());
                listado = modelo;
            }

        }
    }
}
