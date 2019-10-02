using ObjetosOne.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ObjetosOne.Views
{
	public class HeroeView : ContentPage
	{
		public HeroeView ()
		{
            label = new Label()
            {
                Text = "Defendiendo tu amor",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            lblMensaje = new Label()
            {
                HorizontalOptions = LayoutOptions.Center
        };
        EntryNombre = new Entry()
            {
                Placeholder = "Ingrese su nombre"
            };
            EntryMarca = new Entry()
            {
                Placeholder = "Ingrese el numero de muertes"
            };
            EntryVillano = new Entry()
            {
                Placeholder = "Ingrese su villano"
            };
            EntryNumeroMuertes = new Entry()
            {
                Placeholder = "Ingrese su marca"
            };
            
            BtnRegistrar = new Button()
            {
                Text = "Registrar"
            };
           

            BtnRegistrar.Clicked += BtnRegistrar_Clicked;

            Content = new StackLayout {
				Children = {
                    label,
					EntryNombre,
                    EntryVillano,
                    EntryMarca,
                    EntryNumeroMuertes,
                    BtnRegistrar,
                    lblMensaje
				}
			};
		}
        
        public void BtnRegistrar_Clicked(object sender, EventArgs e)
        {
            int muertes = Convert.ToInt32(EntryNumeroMuertes);
            HeroeModel hero = new HeroeModel();
            hero.Nombre = EntryNombre.Text;
            hero.Villano = EntryVillano.Text;
            hero.Marca = EntryMarca.Text;
            hero.NumeroMuertes = muertes;

            hero.SalvarCiudad();
            string r = hero.Nombre + hero.SerIncognito();
            lblMensaje.Text = r;
           
            
        }
        Label label, lblMensaje;
        Button BtnRegistrar;
        Entry EntryNombre, EntryVillano, EntryMarca, EntryNumeroMuertes;
    }
}