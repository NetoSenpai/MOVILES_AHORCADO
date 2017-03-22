using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace AHORCADOGAME
{
    [Activity(Label = "AHORCADOGAME", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
            SetContentView(Resource.Layout.Main);

          //  var btn_caaptura = FindViewById<Button>(Resource.Id.btn_captura);
            var btn_empezar = FindViewById<Button>(Resource.Id.btn_empezar);
            var btn_salir = FindViewById<Button>(Resource.Id.btn_salir);


            btn_empezar.Click += (s, e) =>
            {
                var intent = new Intent(this, typeof(menuActivity));
                StartActivity(intent);


            };
            btn_salir.Click += (s, e) =>
            {
                Finish();
                
            };
        }
    }
}

