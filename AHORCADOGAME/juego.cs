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
   public class juego
    {

        //public static void metodoLetras( juegoActivity ja)
        //{

        //   ja.A.Click += (s, e) =>
        //    {
        //        string tb = A.Text; A.Enabled = false; char[] ca = tb.ToCharArray();

        //        // lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 11) / 10;
        //    };
        //    B.Click += (s, e) =>
        //    {
        //        string tb = B.Text; B.Enabled = false; char[] ca = tb.ToCharArray();

        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);


        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    C.Click += (s, e) =>
        //    {
        //        string tb = C.Text; C.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    D.Click += (s, e) =>
        //    {
        //        string tb = D.Text; D.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    E.Click += (s, e) =>
        //    {
        //        string tb = E.Text; E.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    F.Click += (s, e) =>
        //    {
        //        string tb = F.Text; F.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    G.Click += (s, e) =>
        //    {
        //        string tb = G.Text; G.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    H.Click += (s, e) =>
        //    {
        //        string tb = H.Text; H.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    I.Click += (s, e) =>
        //    {
        //        string tb = I.Text; I.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    J.Click += (s, e) =>
        //    {
        //        string tb = J.Text; J.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    K.Click += (s, e) =>
        //    {
        //        string tb = K.Text; K.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    L.Click += (s, e) =>
        //    {
        //        string tb = L.Text; L.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    M.Click += (s, e) =>
        //    {
        //        string tb = M.Text; M.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    N.Click += (s, e) =>
        //    {
        //        string tb = N.Text; N.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    Ñ.Click += (s, e) =>
        //    {
        //        string tb = Ñ.Text; Ñ.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    O.Click += (s, e) =>
        //    {
        //        string tb = O.Text; O.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    P.Click += (s, e) =>
        //    {
        //        string tb = P.Text; P.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    Q.Click += (s, e) =>
        //    {
        //        string tb = Q.Text; Q.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    R.Click += (s, e) =>
        //    {
        //        string tb = R.Text; R.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    S.Click += (s, e) =>
        //    {
        //        string tb = S.Text; S.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    T.Click += (s, e) =>
        //    {
        //        string tb = T.Text; T.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    U.Click += (s, e) =>
        //    {
        //        string tb = U.Text; U.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    V.Click += (s, e) =>
        //    {
        //        string tb = V.Text; V.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    W.Click += (s, e) =>
        //    {
        //        string tb = W.Text; W.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    X.Click += (s, e) =>
        //    {
        //        string tb = X.Text; X.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    Y.Click += (s, e) =>
        //    {
        //        string tb = Y.Text; Y.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };
        //    Z.Click += (s, e) =>
        //    {
        //        string tb = Z.Text; Z.Enabled = false; char[] ca = tb.ToCharArray();
        //        lbl_PalabraOculta.Text = ModificaPalabra(ListaDesordenada[2], ca[0], PalabraOculta2);
        //        lbl_PalabraOculta.TextSize = (ListaDesordenada[2].Length * 5) / 10;
        //    };


        //}












    }//-------------- class juego
}///  ----------namespace