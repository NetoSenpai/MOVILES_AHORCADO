using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using Java.IO;
using Android.Provider;
using Android.Content.PM;
using Android.Graphics;
using Android.Net;
using Uri = Android.Net.Uri;
using AHORCADOGAME.Resources;

namespace AHORCADOGAME
{
    [Activity(Label = "AHORCADOGAME", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //private ImageView _imageView;
        ImageView ImgView;
        public static File _file;
        public static File _dir;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
            SetContentView(Resource.Layout.Main);

            if (IsThereAnAppToTakePictures())
            {
                CreateDirectoryForPictures();

                Button button = FindViewById<Button>(Resource.Id.btn_captura);
                //_imageView = FindViewById<ImageView>(Resource.Id.imageView1);
                ImgView = FindViewById<ImageView>(Resource.Id.imageView1);
                button.Click += TakeAPicture;
            }
            else
            {
                Button button = FindViewById<Button>(Resource.Id.btn_captura);
                ImgView = FindViewById<ImageView>(Resource.Id.imageView1);
                button.Visibility = Android.Views.ViewStates.Invisible;
                ImgView.Visibility = Android.Views.ViewStates.Invisible;
            }

            var btn_empezar = FindViewById<Button>(Resource.Id.btn_empezar);
            var btn_salir = FindViewById<Button>(Resource.Id.btn_salir);
            var txt_nombre = FindViewById<EditText>(Resource.Id.txtNombre);


            btn_empezar.Click += (s, e) =>
            {
                
                var intent = new Intent(this, typeof(menuActivity));
                if(string.IsNullOrEmpty(txt_nombre.Text))
                {
                    Toast.MakeText(this, "Ingrese un nombre", ToastLength.Short).Show();
                    return;
                }
                else
                {
                    PathHelper.nombrecito = text_nombre.Text;
                }
                if (!string.IsNullOrEmpty(_file.Path))
                    PathHelper.caminito = _file.Path;
                else
                {
                    Toast.MakeText(this, "Favor de tomar una foto", ToastLength.Short).Show();
                    return;
                }

                //intent.PutExtra(menuActivity.LLAVE_NOMBRE, txt_nombre.Text);
                StartActivity(intent);


            };
            btn_salir.Click += (s, e) =>
            {
                Finish();
                
            };
        }
        //public static class App
        //{
        //    public static File _file;
        //    public static File _dir;
        //    public static Bitmap bitmap;
        //}


        private void CreateDirectoryForPictures()
        {
            _dir = new File(Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryPictures), "Ahorcado");
            if (!_dir.Exists())
            {
                _dir.Mkdirs();
            }
        }
        private bool IsThereAnAppToTakePictures()
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            IList<ResolveInfo> availableActivities = PackageManager.QueryIntentActivities(intent, PackageInfoFlags.MatchDefaultOnly);
            return availableActivities != null && availableActivities.Count > 0;
        }
        private void TakeAPicture(object sender, EventArgs eventArgs)
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            _file = new File(_dir, string.Format("Image_{0}.jpg", Guid.NewGuid()));
            intent.PutExtra(MediaStore.ExtraOutput, Uri.FromFile(_file));
            StartActivityForResult(intent, 0);
        }
        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            if (requestCode == 0 && resultCode == Result.Ok)
            {
                // make it available in the gallery  
                Intent mediaScanIntent = new Intent(Intent.ActionMediaScannerScanFile);
                //Uri contentUri = Uri.FromFile(_file);
                Uri contentUri = Uri.FromFile(_file);
                mediaScanIntent.SetData(contentUri);
                SendBroadcast(mediaScanIntent);
                //Converstion Image Size  
                int height = ImgView.Height;
                int width = Resources.DisplayMetrics.WidthPixels;
                using (Bitmap bitmap = _file.Path.LoadAndResizeBitmap(width, height))
                {
                    //View ImageView  
                    ImgView.RecycleBitmap();
                    ImgView.SetImageBitmap(bitmap);
                    //Upload Image in Database
                    GC.Collect();  
                }
            }
        }
    }
}

