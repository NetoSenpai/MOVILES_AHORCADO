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
    [Activity(Label = "palabrasActivity")]
    public class palabrasActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.palabras);








            var _ListView1 = FindViewById<ListView>(Resource.Id.listView1);
            var _spnCategorias = FindViewById<Spinner>(Resource.Id.spnCategorias);







            var adapter_spnCategorias = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerDropDownItem, ListasDePalabras.ItemSpinner);
            _spnCategorias.Adapter = adapter_spnCategorias;

            _spnCategorias.ItemSelected += (s, e) =>
            {
               // string cadena = "";

                var itemposition = e.Position;
                var itemvalue = _spnCategorias.GetItemAtPosition(itemposition);




                switch (itemposition)
                {
                    case 1:

                        var adapter_LV1 = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, ListasDePalabras.ListaEdosMexico);
                        _ListView1.Adapter = adapter_LV1;

                        break;
                    case 2:

                        var adapter_LV2 = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, ListasDePalabras.ListaCiudadesEU);
                        _ListView1.Adapter = adapter_LV2;
                        break;




                    default:
                        var adapter_LV3 = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, ListasDePalabras.ListaVacia);
                        _ListView1.Adapter = adapter_LV3;
                        break;
                }


            };





























        }
    }
}