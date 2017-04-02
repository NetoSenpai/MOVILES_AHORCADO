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



namespace AHORCADOGAME
{
    [Activity(Label = "menuActivity")]
    public class menuActivity : Activity
    {
        public static readonly string LLAVE_NOMBRE = "";



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MENU);

            var btn_jugar = FindViewById<Button>(Resource.Id.btn_jugar);
            var btn_instrucciones = FindViewById<Button>(Resource.Id.btn_instrucciones);
            var btn_palaras = FindViewById<Button>(Resource.Id.btn_palabras);
            var btn_creditos = FindViewById<Button>(Resource.Id.btn_creditos);


            var lbl_nombre = FindViewById<TextView>(Resource.Id.lblNombre);

            var nombre = Intent.GetStringExtra(LLAVE_NOMBRE);
         //   lbl_nombre.Text = nombre;

            btn_jugar.Click += (s, e) =>
            {
                var intent = new Intent(this, typeof(juegoActivity));
                intent.PutExtra(juegoActivity.LLAVE_NOMBRE,nombre);
                StartActivity(intent);
            };
            btn_instrucciones.Click += (s, e) =>
            {
                var intent = new Intent(this, typeof(instruccionesActivity));
                StartActivity(intent);
            };

            btn_palaras.Click += (s, e) =>
            {
                var intent = new Intent(this, typeof(palabrasActivity));
                StartActivity(intent);
            };

            btn_creditos.Click += (s, e) =>
            {
                var intent = new Intent(this, typeof(CreditosActivity));
                StartActivity(intent);
            };
        }
    }
}