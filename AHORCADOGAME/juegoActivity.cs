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

       public static readonly String LLAVE_NOMBRE = "nombre";


        protected override void OnCreate(Bundle savedInstanceState)
        {

            Queue<string> Cla = new Queue<string>();

            string buscar = "[A-Za-z]";
            string reemplazo = "_";
            string PalabraOculta2 ="";
            string palabraAdivinar = "";


            var nombre = Intent.GetStringExtra(LLAVE_NOMBRE);


            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.juego);

           List<string> ListaDesordenada = LstDes(ListasDePalabras.ListaEdosMexico);

            if (ListasDePalabras.Cola.Count() == 0)
            {  foreach (string s in ListaDesordenada)  { ListasDePalabras.Cola.Enqueue(s); }
                ListasDePalabras.Cola.Enqueue(null);
            }



            if (ListasDePalabras.Cola.Peek() == null) { ListasDePalabras.Cola.Clear();  CuadroDialogo2("DESEA CONTINUAR ?"); }else
           palabraAdivinar = ListasDePalabras.Cola.Dequeue();
            PalabraOculta2 = Regex.Replace(palabraAdivinar, buscar, reemplazo);                    //crea la cadena con los caracteres ocultos, cada carac. es reeemplazado por "_ "


       

            ListasDePalabras.P = PalabraOculta2;

            




            var _Table1 = FindViewById<TableLayout>(Resource.Id.tableLayout1);
            var _imgTitulo = FindViewById<ImageView>(Resource.Id.imgTitulo);
            var lbl_PalabraOculta = FindViewById<TextView>(Resource.Id.lblPalabraOculta);
            var _cronometro = FindViewById<Chronometer>(Resource.Id.cronometro);
            var _btnStart = FindViewById<Button>(Resource.Id.btnStart);

            var _lblNombre = FindViewById<TextView>(Resource.Id.lbl_Nombre);

            _lblNombre.Text = nombre;



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

            lbl_PalabraOculta.Text = ListasDePalabras.P;

            
            A.Click += (s, e) =>
            {
                string tb = A.Text; A.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P= ModificaPalabra(/*ListaDesordenada[2]*/palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                
                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }

                //   lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            B.Click += (s, e) =>
            {
                string tb = B.Text; B.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(/*ListaDesordenada[2]*/palabraAdivinar, ca[0], ListasDePalabras.P);
                 lbl_PalabraOculta.Text = ListasDePalabras.P;
                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                // lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            C.Click += (s, e) =>
            {
                string tb = C.Text; C.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(/*ListaDesordenada[2]*/palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }

                // lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], ListasDePalabras.P);
                //   lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            D.Click += (s, e) =>
            {
                string tb = D.Text; D.Enabled = false; char[] ca = tb.ToCharArray();

                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                // lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            E.Click += (s, e) =>
            {
                string tb = E.Text; E.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //  lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            F.Click += (s, e) =>
            {
                string tb = F.Text; F.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //  lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            G.Click += (s, e) =>
            {
                string tb = G.Text; G.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                // lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            H.Click += (s, e) =>
            {
                string tb = H.Text; H.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //  lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            I.Click += (s, e) =>
            {
                string tb = I.Text; I.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //  lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            J.Click += (s, e) =>
            {
                string tb = J.Text; J.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //  lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            K.Click += (s, e) =>
            {
                string tb = K.Text; K.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //  lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            L.Click += (s, e) =>
            {
                string tb = L.Text; L.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //   lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            M.Click += (s, e) =>
            {
                string tb = M.Text; M.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //  lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            N.Click += (s, e) =>
            {
                string tb = N.Text; N.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //  lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            —.Click += (s, e) =>
            {
                string tb = —.Text; —.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //   lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            O.Click += (s, e) =>
            {
                string tb = O.Text; O.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //   lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            P.Click += (s, e) =>
            {
                string tb = P.Text; P.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                // lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            Q.Click += (s, e) =>
            {
                string tb = Q.Text; Q.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //  lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            R.Click += (s, e) =>
            {
                string tb = R.Text; R.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //  lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            S.Click += (s, e) =>
            {
                string tb = S.Text; S.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //  lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            T.Click += (s, e) =>
            {
                string tb = T.Text; T.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //  lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            U.Click += (s, e) =>
            {
                string tb = U.Text; U.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //  lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            V.Click += (s, e) =>
            {
                string tb = V.Text; V.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //  lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            W.Click += (s, e) =>
            {
                string tb = W.Text; W.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //  lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            X.Click += (s, e) =>
            {
                string tb = X.Text; X.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //  lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            Y.Click += (s, e) =>
            {
                string tb = Y.Text; Y.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //   lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };
            Z.Click += (s, e) =>
            {
                string tb = Z.Text; Z.Enabled = false; char[] ca = tb.ToCharArray();
                ListasDePalabras.P = ModificaPalabra(palabraAdivinar, ca[0], ListasDePalabras.P);
                lbl_PalabraOculta.Text = ListasDePalabras.P;

                if (!lbl_PalabraOculta.Text.Contains("_"))
                {
                    CuadroDialogo("GANASTES .....Deseas seguir jugando ?");
                }
                //  lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
            };





        }//----------------OnCreate -------------------------------------------------


      



       







        //----------------------------------------------------------------------------

        public string ModificaPalabra(string pal, char letra,string PalGuiones)
        {
            int pos = 0;
            char[] caracs = pal.ToCharArray();
            char[] palguicar = PalGuiones.ToCharArray();
            int NumCarac = caracs.Length-1;

          

           for( pos=0;pos<=NumCarac;pos++)
            {
                if (pos <= NumCarac)
                {
                    if (caracs[pos] == letra)
                    {
                        palguicar[pos] = letra;
                                             
                    }
                }
               
            }
           
            string ps = new string(palguicar);
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

        public static int NumLetras(string palabra)
        {
            int _NumDeLetras = 0;
            string _palabra = palabra;
            char[] Vec= _palabra.ToCharArray();


           for(int x=0;x<=Vec.Length-1;x++)
            {
                if (Vec[x] != '\0') { _NumDeLetras++; }
                else
                    continue;
                   
            }
            return _NumDeLetras;
        }


//------------------------------------------------------------------------------------------------------
public void CuadroDialogo(string s)
        {
            AlertDialog.Builder dialogo = new AlertDialog.Builder(this);
            dialogo.SetTitle("EL AHORCADO - GAME");
            dialogo.SetMessage(s);
         //   dialogo.SetNeutralButton("aceptar",BotonSi);
              dialogo.SetPositiveButton("SI",BotonSi);
             dialogo.SetNegativeButton("NO",BotonNo);
            dialogo.Show();

        }

       



        private void BotonSi(object sender, DialogClickEventArgs e)
        {
            var intent = new Intent(this, typeof(juegoActivity));


            Finish();
            StartActivity(intent);
            
        }
        private void BotonNo(object sender, DialogClickEventArgs e)
        {
            Finish();
           
        }


        //-------------------------------------------------------------------------------

        public void CuadroDialogo2(string s)
        {
            AlertDialog.Builder dialogo = new AlertDialog.Builder(this);
            dialogo.SetTitle("FELICIDADES, HAS ADIVINADO TODAS LAS PALABRAS DE LA CATEGORIA");
            dialogo.SetMessage(s);
              dialogo.SetNeutralButton("aceptar",aceptar);
            //dialogo.SetPositiveButton("SI", BotonSi);
            //dialogo.SetNegativeButton("NO", BotonNo);
            dialogo.Show();

        }
        private void aceptar(object sender,DialogClickEventArgs e)
        {
            Finish();
            
            var intent = new Intent(this, typeof(menuActivity));
          //  ListasDePalabras.Cola.Clear();
            StartActivity(intent);


        }







    }//-------------public class Activity
}//-----------Namespace