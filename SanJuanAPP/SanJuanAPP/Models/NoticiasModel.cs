using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using System.ComponentModel;

/*
 
     "nid":"4239",
     "nf":"recursos/C0E2C2CA1A31D5D231CFB340E0B73979.jpeg",
     "no":"MIN. DE SALUD ",
     "oid":"10",
     "nr":"<p>LICITACION PUBLICA NÂ°17, ART 68Â° LEY DE CONTABILIDAD DE LA PROVINCIA DE SAN JUAN, AUTORIZADA POR RESOLUCION NÂº 0922-H.P.D.G.R.17, DEL 10 DE JULIO DEL &nbsp;2.017.&nbsp;EXPEDIENTE NÂº: 802-0455-2.017.-</p>",
     "nf":"18/07/2017 16:28:02"
*/
namespace SanJuanAPP.Models
{
    public class NoticiasModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }

        private int nid;
        private string nf;
        private string no;
        private int oid;
        private string nr;
        //private string nfecha;

        public int NID
        {
            get
            {
                return nid;
            }
            set
            {
                if (nid != value)
                {
                    nid = value;
                    OnPropertyChanged("nid");
                }
            }
        }
        public string NF
        {
            get
            {
                return nf;
            }
            set
            {
                if (nf != value)
                {
                    nf = value;
                    OnPropertyChanged("nf");
                }
            }
        }
        public string NO   
        {
            get
            {
                return no;
            }
            set
            {
                if (no != value)
                {
                    no = value;
                    OnPropertyChanged("no");
                }
            }
        }
        public int OID
        {
            get
            {
                return oid;
            }
            set
            {
                if (oid != value)
                {
                    oid = value;
                    OnPropertyChanged("oid");
                }
            }
        }
        public string NR
        {
            get
            {
                return nr;
            }
            set
            {
                if (nr != value)
                {
                    nr = value;
                    OnPropertyChanged("nr");
                }
            }
        }
        /*
        public string NFECHA
        {
            get
            {
                return nf;
            }
            set
            {
                if (nf != value)
                {
                    nf = value;
                    OnPropertyChanged("nf");
                }
            }
        }
        */
    }
}
