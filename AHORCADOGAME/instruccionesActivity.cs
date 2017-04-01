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
    [Activity(Label = "instruccionesActivity")]
    public class instruccionesActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.instrucciones);

            var btn_aceptarinst = FindViewById<Button>(Resource.Id.btn_aceptarinst);

            var imgTitulo = FindViewById<ImageView>(Resource.Id.imgTitulo);

            btn_aceptarinst.Click += (s, e) =>
            {
                var intent = new Intent(this, typeof(menuActivity));
                StartActivity(intent);
            };
        }
    }
}