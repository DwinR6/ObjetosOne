using ObjetosOne.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjetosOne.Model
{
    public class HeroeModel: IHeroe
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Villano { get; set; }
        public int NumeroMuertes { get; set; }

        public void SalvarCiudad()
        {
            App.Current.MainPage.DisplayAlert("Mensaje", "Defendiendo", "ok");
        }

        public string SerIncognito()
        {
            return "No mas informacion. Es clasificado";
        }
    }
}
