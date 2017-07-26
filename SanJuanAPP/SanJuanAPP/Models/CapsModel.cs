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
        private DateTime update;
        private string latitud;
        private string longitud;
        private string nombre;
        private string direccion;
        private string telefono;
        private int depto;
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

        //Latitud
        public string LATITUD
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

        //Longitud
        public string LONGITUD
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

        //Update
        public DateTime UPDATE
        {
            get
            {
                return update;
            }
            set
            {
                if (update != value)
                {
                    update = value;
                    OnPropertyChanged("update");
                }
            }
        }

        //Dpto
        public int DEPTO
        {
            get
            {
                return depto;
            }
            set
            {
                if (depto != value)
                {
                    depto = value;
                    OnPropertyChanged("depto");
                }
            }
        }

        //ImageUrl
        public string IMGURL
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
