using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SanJuanAPP.Classes;
using SanJuanAPP.Models;
using SanJuanAPP.ViewModels;
using System.Net.Http;

using SanJuanAPP.Interfaces;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using CarouselView;

namespace SanJuanAPP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            /*
             * Creo la bd por primera y unica vez.
             * Consulto la API verifico update de datos de caps
             * Cargo Los departamentos en la bd por unica vez. 
             */

            var names = new List<string> {

                "Seba", "Maria paz", "Sebita", "Laura"
            };



            //HttpClient cliente = new HttpClient();
            //cliente.BaseAddress = new Uri("http://sanjuan.gov.ar");
            //cliente.BaseAddress = new Uri("http://192.168.100.24");
            //cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //var token = System.Net.WebUtility.UrlEncode(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            

            //var respuesta = cliente.GetStringAsync("/gen/gobierno/app/noticias/salud/c/index.json").Result;


            //var dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(respuesta);
            //var postalCode = dict["nf"];

            //Array is also possible
            //string[] result = dict.Select(kv => kv.Value.ToString()).ToArray();
            //carousel.ItemsSource = www_caps;

            //FileDownload fd = new FileDownload();
            //fd.Donwload("imagen.jpg", "http://sites.psu.edu/isa108/wp-content/uploads/sites/13037/2014/06/3461205-871812-sleeping-emoticon.jpg");

            AgregarDptos();
            //SincronizarDatos();

        }

        

        public void SincronizarDatos()
        {
            
            /*
            try
            {
                int j = 0;
                DateTime fecha = DateTime.Now;
                HttpClient cliente = new HttpClient();
                //cliente.BaseAddress = new Uri("http://10.64.64.218:1941");
                cliente.BaseAddress = new Uri("http://192.168.100.24");
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var token = System.Net.WebUtility.UrlEncode(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                var respuesta = cliente.GetStringAsync("/api/ubicaciones?fecha=" + token).Result;
                
                
                //var www_caps = JsonConvert.DeserializeObject<List<CapsModel>>(respuesta);
                var www_caps =  //JsonConvert.DeserializeObject<List<CapsModel>>(respuesta);

                CapsViewModel vm_caps = new CapsViewModel();
                CapsModel local_caps = new CapsModel();
                dbContext db_caps = new dbContext();

                //FileDownload fd = new FileDownload();
                //fd.Donwload("imagen.jpg", "http://sites.psu.edu/isa108/wp-content/uploads/sites/13037/2014/06/3461205-871812-sleeping-emoticon.jpg");

                vm_caps.llenarListado();
                if (vm_caps.List.Count == 0)
                {
                    for(int i=0; i<www_caps.Count;i++)
                    {
                        local_caps.UPDATE = fecha;
                        local_caps.DEPTO = www_caps[i].DEPTO;
                        local_caps.DIRECCION = www_caps[i].DIRECCION;
                        local_caps.LATITUD = www_caps[i].LATITUD;
                        local_caps.LONGITUD = www_caps[i].LONGITUD;
                        local_caps.NOMBRE = www_caps[i].NOMBRE;
                        local_caps.TELEFONO = www_caps[i].TELEFONO;
                        local_caps.IMGURL = www_caps[i].IMGURL;
                        db_caps.add(local_caps);

                        
                    }
                }
                else
                {
                    

                    for (int i = 0; i < www_caps.Count; i++)
                    {

                        j= j+1;
                        //local_caps.ID = vm_caps.ID;
                        local_caps.ID = j;
                        local_caps.UPDATE = fecha;
                        local_caps.DEPTO = www_caps[i].DEPTO;
                        local_caps.DIRECCION = www_caps[i].DIRECCION;
                        local_caps.LATITUD = www_caps[i].LATITUD;
                        local_caps.LONGITUD = www_caps[i].LONGITUD;
                        local_caps.NOMBRE = www_caps[i].NOMBRE;
                        local_caps.TELEFONO = www_caps[i].TELEFONO;
                        local_caps.IMGURL = www_caps[i].IMGURL;
                        db_caps.update(local_caps);
                      
                    }
                }
                db_caps.Dispose();
                


                //if (respuesta.IsSuccessStatusCode)
                //{

                //var x = JsonConvert.DeserializeObject<List<TodoItem>>(respuesta.Content.ReadAsStringAsync());//respuesta.Content.rea<List<TodoItem>>().Result;
                //throw new NotImplementedException();
                //}
                //return null;
            }
            catch (Exception es)
            {
                return;
            }
            */
        }

        
        private void AgregarDptos()
        {

            DptosViewModel listDptos = new DptosViewModel();

            var x = listDptos.List.Count();

            if (x == 0)
            {
                dbContext db = new dbContext();
                DptosModel model = new DptosModel();

                #region dptos_add
                model.NOMBRE = "CALINGASTA";
                db.add(model);

                model.NOMBRE = "25 DE MAYO";
                db.add(model);

                model.NOMBRE = "9 DE JULIO";
                db.add(model);

                model.NOMBRE = "ALBARDON";
                db.add(model);

                model.NOMBRE = "ANGACO";
                db.add(model);

                model.NOMBRE = "CAPITAL";
                db.add(model);

                model.NOMBRE = "CAUCETE";
                db.add(model);

                model.NOMBRE = "CHIMBAS";
                db.add(model);

                model.NOMBRE = "IGLESIA";
                db.add(model);

                model.NOMBRE = "JACHAL";
                db.add(model);

                model.NOMBRE = "POCITO";
                db.add(model);

                model.NOMBRE = "RAWSON";
                db.add(model);

                model.NOMBRE = "RIVADAVIA";
                db.add(model);

                model.NOMBRE = "SAN MARTIN";
                db.add(model);

                model.NOMBRE = "SANTA LUCIA";
                db.add(model);

                model.NOMBRE = "SARMIENTO";
                db.add(model);

                model.NOMBRE = "ULLUM";
                db.add(model);

                model.NOMBRE = "VALLE FERTIL";
                db.add(model);

                model.NOMBRE = "ZONDA";
                db.add(model);
                #endregion dptos_add

            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            try
            {

                if (sender.GetType() == typeof(Image))
                {
                    var imageSender = (Image)sender;

                    switch (imageSender.ClassId)
                    {
                        case "btnEncontrarCs":
                            {
                                btnEncontrar();
                            }
                            break;

                        case "btnProtur":
                            {
                                btnProtur();
                            }
                            break;

                        case "btnAyuda":
                            {
                                btnAyuda();
                            }
                            break;
                    }
                }
                else
                {
                    var imageSender = (Label)sender;

                    switch (imageSender.ClassId)
                    {
                        case "btnEncontrarCs":
                            {
                                btnEncontrar();
                            }
                            break;

                        case "btnProtur":
                            {
                                btnProtur();
                            }
                            break;

                        case "btnAyuda":
                            {
                                btnAyuda();
                            }
                            break;
                    }
                }

                
            }
            catch(Exception ex)
            {
                throw new NotImplementedException();
            }

        }


        private void btnAyuda()
        {
            //((NavigationPage)this.Parent).PushAsync(new Views.Ayuda());
            Navigation.PushModalAsync(new Views.Ayuda());
        }

        private void btnProtur()
        {
            //((NavigationPage)this.Parent).PushAsync(new Views.Protur());
            Navigation.PushModalAsync(new Views.Protur());
        }
        public void btnEncontrar()
        {
            Navigation.PushModalAsync(new Views.GpsOrDpto());
            //((NavigationPage)this.Parent).PushAsync(new Views.GpsOrDpto());
        }

        private void Button_btnEncontrar_Clicked(object sender, EventArgs e)
        {
            btnEncontrar();
        }

        private void Button_btnProtur_Clicked(object sender, EventArgs e)
        {
            btnProtur();
        }

        private void Button_btnAyuda_Clicked(object sender, EventArgs e)
        {
            btnAyuda();
        }
    }
}
