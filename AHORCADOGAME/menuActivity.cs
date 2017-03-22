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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MENU);

            var btn_jugar = FindViewById<Button>(Resource.Id.btn_jugar);
            var btn_instrucciones = FindViewById<Button>(Resource.Id.btn_instrucciones);
            var btn_palaras = FindViewById<Button>(Resource.Id.btn_palabras);
            var btn_creditos = FindViewById<Button>(Resource.Id.btn_creditos);

            btn_jugar.Click += (s, e) =>
            {
                var intent = new Intent(this, typeof(juegoActivity));
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