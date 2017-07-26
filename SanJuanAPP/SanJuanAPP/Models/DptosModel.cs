using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using SQLite.Net.Attributes;

namespace SanJuanAPP.Models
{
    public class DptosModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }


        private int Id;
        private string Nombre;

        [PrimaryKey, AutoIncrement]
        public int ID
        {
            get
            {
                return Id;
            }
            set
            {
                if (Id != value)
                {
                    Id = value;
                    OnPropertyChanged("Id");
                }
            }
        }

        //Nombre
        public string NOMBRE
        {
            get
            {
                return Nombre;
            }
            set
            {
                if (Nombre != value)
                {
                    Nombre = value;
                    OnPropertyChanged("Nombre");
                }
            }
        }
    }
}
