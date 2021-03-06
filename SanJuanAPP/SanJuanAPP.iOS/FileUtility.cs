﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using SanJuanAPP.Interfaces;
using Xamarin.Forms;
using System.IO;
[assembly: Dependency(typeof(SanJuanAPP.iOS.FileUtility))]
namespace SanJuanAPP.iOS
{
    public class FileUtility : IFileUtility
    {
        public string SaveFile(string fileName)
        {
            string path = null;
            byte[] size = File.ReadAllBytes(fileName);
            string imageFolderPath = System.IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), "SanJuanAPP_img");

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
            string imageFolderPath = System.IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ProductImages");
            if (System.IO.Directory.Exists(imageFolderPath))
            {
                System.IO.Directory.Delete(imageFolderPath, true);
            }
        }
    }
}