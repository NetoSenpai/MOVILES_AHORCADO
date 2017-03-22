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
    [Activity(Label = "CreditosActivity")]
    public class CreditosActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.creditos);

            var btn_creditos = FindViewById<Button>(Resource.Id.btn_credito);


            btn_creditos.Click += (s, e) =>
            {
                var intent = new Intent(this, typeof(menuActivity));
                StartActivity(intent);
            };
        }
    }
}