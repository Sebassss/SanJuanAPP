using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using SQLite.Net.Attributes;

namespace SanJuanAPP.Models
{
    public class CapsModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }

        //private apkSalud.Class.dbContext db;
        private int Id;
        private string latitud;
        private string longitud;
        private string nombre;
        private string direccion;
        private string telefono;
        private int dpto;
        private string ImgUrl;



        /// <summary>
        /// Definicion de Modelo
        /// </summary>


        //Id
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

        //Latitud
        public string LAT
        {
            get
            {
                return latitud;
            }
            set
            {
                if (latitud != value)
                {
                    latitud = value;
                    OnPropertyChanged("latitud");
                }
            }
        }

        //Dpto
        public int DPTO
        {
            get
            {
                return dpto;
            }
            set
            {
                if (dpto != value)
                {
                    dpto = value;
                    OnPropertyChanged("dpto");
                }
            }
        }

        //ImageUrl
        public string IMAGE
        {
            get
            {
                return ImgUrl;
            }
            set
            {
                if (ImgUrl != value)
                {
                    ImgUrl = value;
                    OnPropertyChanged("ImgUrl");
                }
            }
        }

        //Longitud
        public string LNG
        {
            get
            {
                return longitud;
            }
            set
            {
                if (longitud != value)
                {
                    longitud = value;
                    OnPropertyChanged("longitud");
                }
            }
        }

        //Nombre
        public string NOMBRE
        {
            get
            {
                return nombre;
            }
            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    OnPropertyChanged("nombre");
                }
            }
        }

        //Direccion
        public string DIRECCION
        {
            get
            {
                return direccion;
            }
            set
            {
                if (direccion != value)
                {
                    direccion = value;
                    OnPropertyChanged("direccion");
                }
            }
        }

        //Telefono
        public string TELEFONO
        {
            get
            {
                return telefono;
            }
            set
            {
                if (telefono != value)
                {
                    telefono = value;
                    OnPropertyChanged("telefono");
                }
            }
        }





    }
}
