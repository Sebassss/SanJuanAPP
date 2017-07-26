using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SanJuanAPP.Interfaces;
using Xamarin.Forms;
using System.IO;

namespace SanJuanAPP.Classes
{
    
    public class FileDownload 
    {
        
        public void Donwload(string filename, string url)
        {
            var configuration = DependencyService.Get<IFileUtility>();
            configuration.SaveFile(filename, url);
            
        }
    }
}

