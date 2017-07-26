using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Interop;

namespace SanJuanAPP.Interfaces
{
    public interface IConfiguration
    {
        string directorio { get; }          //Obtengo directorio donde se encuentra la db
        ISQLitePlatform platform { get; }   //Obtengo la plataforma que ejecuta.
    }
}



