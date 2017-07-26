using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanJuanAPP.Interfaces
{
    public interface IFileUtility
    {
        /// <summary>
        /// Use to save file in device specific folders
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="fileStream"></param>
        /// <returns></returns>
        string SaveFile(string fileName,string url);

        /// <summary>
        /// Used to delete the existing file directory, before syncing the file again.
        /// </summary>
        void DeleteDirectory();
    }

}
