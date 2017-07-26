using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using Xamarin.Forms;
using System.IO;
using SanJuanAPP.Models;
using SanJuanAPP.Interfaces;

namespace SanJuanAPP.Classes
{
    public class dbContext : IDisposable
    {
        private SQLiteConnection conn;


        public dbContext()
        {
            var configuration = DependencyService.Get<IConfiguration>();
            conn = new SQLiteConnection(configuration.platform, Path.Combine(configuration.directorio, "SanJuanAPP.db3"));
            conn.CreateTable<CapsModel>();
            conn.CreateTable<DptosModel>();
        }
        public void Dispose()
        {
            conn.Dispose();
        }

        public void add<T>(T model)
        {
            try
            {
                conn.Insert(model);
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        #region metodos ABM
        public void update<T>(T model)
        {
            conn.Update(model);
        }

        public void delete<T>(T model)
        {
            conn.Delete(model);
        }

        public T getItem<T>(int id) where T : class, new()
        {
            var map = conn.GetMapping(typeof(T));
            return conn.Query<T>(map.GetByPrimaryKeySql, id).First();
        }


        public T[] getAll<T>() where T : new()
        {
            return new TableQuery<T>(conn.Platform, conn).ToArray();
        }
        #endregion
    }
}
