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
using System.Text.RegularExpressions;


namespace AHORCADOGAME
{
    [Activity(Label = "juegoActivity")]
    public class juegoActivity : Activity
    {

        string Palabra = "";

        int NumFallas = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            string buscar = "[A-Za-z]";
            string reemplazo = "_ ";
            string PalabraOculta2 = "" ;

            






            base.OnCreate(savedInstanceState);
            
            SetContentView(Resource.Layout.juego);
                  
            var _Table1 = FindViewById<TableLayout>(Resource.Id.tableLayout1);
            var _imgTitulo = FindViewById<ImageView>(Resource.Id.imgTitulo);
            var lbl_PalabraOculta = FindViewById<TextView>(Resource.Id.lblPalabraOculta);
            var _cronometro = FindViewById<Chronometer>(Resource.Id.cronometro);
            var _btnStart = FindViewById<Button>(Resource.Id.btnStart);


            var A = FindViewById<Button>(Resource.Id.btnA);
            var B = FindViewById<Button>(Resource.Id.btnB);
            var C = FindViewById<Button>(Resource.Id.btnC);
            var D = FindViewById<Button>(Resource.Id.btnD);
            var E = FindViewById<Button>(Resource.Id.btnE);
            var F = FindViewById<Button>(Resource.Id.btnF);
            var G = FindViewById<Button>(Resource.Id.btnG);
            var H = FindViewById<Button>(Resource.Id.btnH);
            var I = FindViewById<Button>(Resource.Id.btnI);
            var J = FindViewById<Button>(Resource.Id.btnJ);
            var K = FindViewById<Button>(Resource.Id.btnK);
            var L = FindViewById<Button>(Resource.Id.btnL);
            var M = FindViewById<Button>(Resource.Id.btnM);
            var N = FindViewById<Button>(Resource.Id.btnN);
            var — = FindViewById<Button>(Resource.Id.btn—);
            var O = FindViewById<Button>(Resource.Id.btnO);
            var P = FindViewById<Button>(Resource.Id.btnP);
            var Q = FindViewById<Button>(Resource.Id.btnQ);
            var R = FindViewById<Button>(Resource.Id.btnR);
            var S = FindViewById<Button>(Resource.Id.btnS);
            var T = FindViewById<Button>(Resource.Id.btnT);
            var U = FindViewById<Button>(Resource.Id.btnU);
            var V = FindViewById<Button>(Resource.Id.btnV);
            var W = FindViewById<Button>(Resource.Id.btnW);
            var X = FindViewById<Button>(Resource.Id.btnX);
            var Y = FindViewById<Button>(Resource.Id.btnY);
            var Z = FindViewById<Button>(Resource.Id.btnZ);



            List<string> ListaDesordenada = LstDes(ListasDePalabras.ListaEdosMexico);



            PalabraOculta2 = Regex.Replace(ListaDesordenada[2], buscar, reemplazo);                    //crea la cadena con los caracteres ocultos, cada carac. es reeemplazado por "_ "



            lbl_PalabraOculta.Text = PalabraOculta2;

            A.Click += (s, e) =>  {
                string tb = A.Text;   A.Enabled = false;       char[] ca = tb.ToCharArray();
                lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2],ca[0],PalabraOculta2);
                lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length*5)/10;
            };
            B.Click += (s, e) => {
                string tb = A.Text; A.Enabled = false; char[] ca = tb.ToCharArray();
                lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
                lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };






        }//----------------OnCreate -------------------------------------------------



      

        public string ModificaPalabra(string pal, char letra,string PalGuiones)
        {

            int pos = 0;
            char[] caracs = pal.ToCharArray();
            char[] palguicar = PalGuiones.ToCharArray();
            foreach(char c in pal)
            {
                if(c == letra)
                {
                        palguicar[pos] = letra.ToString().ToCharArray()[0];
                }
                pos++;
            }
            string ps = Java.Util.Arrays.ToString(palguicar);
            return ps;

        }



      



        //--------------------------------------------------------------------------------------------------------------------------------------
        public static List<string> LstDes(List<string> L)
        {
            List<string> _L = L;
            List<string> Desordenada = new List<string>();
            Random Rdm = new Random();

            while (_L.Count > 0)
            {
                int IndxRdm = Rdm.Next(0, _L.Count - 1);
                Desordenada.Add(_L[IndxRdm]);
                _L.RemoveAt(IndxRdm);
            }
            ListasDePalabras.ListaEdosMexico = Desordenada;
            return Desordenada;
        }//---metodo para desordenar la lista , regresa una lista desordenada
        //--------------------------------------------------------------------------------------------------------------------------------------






    }//-------------public class Activity
}//-----------Namespace