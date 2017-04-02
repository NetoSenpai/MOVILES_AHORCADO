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
    public class ListasDePalabras
    {


      
        public static List<string> ListaEdosMexico = new List<string>() {

"AGUASCALIENTES",
"BAJA CALIFORNIA",
"BAJA CALIFORNIA SUR",
"CAMPECHE",
"CHIAPAS"
//"CHIHUAHUA"
//"COAHUILA",
//"COLIMA",
//"DISTRITO FEDERAL",
//"DURANGO",
//"ESTADO DE MÉXICO",
//"GUANAJUATO",
//"GUERRERO",
//"HIDALGO",
//"JALISCO",
//"MICHOACAN",
//"MORELOS",
//"NAYARIT",
//"NUEVO LEON",
//"OAXACA",
//"PUEBLA",
//"QUERÉTARO",
//"QUINTANA ROO",
//"SAN LUIS POTOSÍ",
//"SINALOA",
//"SONORA",
//"TABASCO",
//"TAMAULIPAS",
//"TLAXCALA",
//"VERACRUZ",
//"YUCATÁN",
//"ZACATECAS"
};

        public static List<string> ListaCiudadesEU = new List<string>() {

 "ALABAMA",
"ALASKA",
"ARIZONA",
"ARKANSAS",
"CALIFORNIA",
"CAROLINA DEL NORTE",
"CAROLINA DEL SUR",
"COLORADO",
"CONNECTICUT",
"DAKOTA DEL NORTE",
"DAKOTA DEL SUR",
"DELAWARE",
"FLORIDA",
"GEORGIA",
"HAWAI",
"IDAHO",
"ILLINOIS",
"IOWA",
"KANSAS",
"KENTUCKY",
"LUISIANA",
"MAINE",
"MARYLAND",
"MASSACHUSETTS",
"MÍCHIGAN",
"MINNESOTA",
"MISISIPI",
"MISURI",
"MONTANA",
"NEBRASKA",
"NEVADA",
"NUEVA JERSEY",
"NUEVA YORK",
"NUEVO HAMPSHIRE",
"NUEVO MÉXICO",
"OHIO",
"OKLAHOMA",
"OREGÓN",
"PENSILVANIA",
"RHODE ISLAND",
"TENNESSEE",
"TEXAS",
"UTAH",
"VERMONT",
"VIRGINIA",
"VIRGINIA OCCIDENTAL",
"WASHINGTON",
"WISCONSIN",
"WYOMING"

        };


        public static List<string> ListaVacia = new List<string>() { };


        public static List<string> ItemSpinner = new List<string>() { "Mirar datos", "Estados Rep. Mexicana", "Estados de EU", "Frutas y verduras", "Deportes" };



       





        public static Queue<string> _Cola = new Queue<string>();
        public static Queue<string> Cola
        {
            get { return _Cola; }
            set { _Cola = value; }
        }




//-------------------------------------------------------------

        public static string _P;

        public static string P
        {
            get { return _P; }
            set { _P = value; }
        }

        //------------------------------------------------------------------------


        //public static int _CantLetras;
        //public static int CantLetras
        //{
        //    get { return _CantLetras; }
        //    set { _CantLetras = value; }
        //} 










        //------------------------------------------------------------

        //public static int NumLetras(string palabra)
        //{
        //    int _NumDeLetras = 0;
        //    string _palabra = palabra;
        //    foreach (char c in _palabra)
        //    {
        //        if (c == '_') { _NumDeLetras++; }

        //    }
        //    return _NumDeLetras;
        //}

//------------------------------------------------------------------
















    }
}