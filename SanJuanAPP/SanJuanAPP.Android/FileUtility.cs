using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SanJuanAPP.Interfaces;
using Xamarin.Forms;
using System.IO;
using System.Net;

[assembly: Dependency(typeof(SanJuanAPP.Droid.FileUtility))]
namespace SanJuanAPP.Droid
{
    public class FileUtility : IFileUtility
    {
        public string SaveFile(string fileName, string imageurl)
        {
            string path = null;
            WebClient webClient = new WebClient();
            webClient.Headers.Add("user-agent", "ASP.NET WebClient");
            byte [] size = webClient.DownloadData(imageurl); // File.ReadAllBytes(fileName);
            string imageFolderPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "SanJuanAPP");

            //Check if the folder exist or not
            if (!System.IO.Directory.Exists(imageFolderPath))
            {
                System.IO.Directory.CreateDirectory(imageFolderPath);
            }
            string imagefilePath = System.IO.Path.Combine(imageFolderPath, fileName);

            //Try to write the file bytes to the specified location.
            try
            {
                System.IO.File.WriteAllBytes(imagefilePath, size);
                path = imagefilePath;
            }
            catch (System.Exception e)
            {
                throw e;
            }
            return path;
        }

        public void DeleteDirectory()
        {
            string imageFolderPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "ProductImages");
            if (System.IO.Directory.Exists(imageFolderPath))
            {
                System.IO.Directory.Delete(imageFolderPath, true);
            }
        }
    }
}