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
using System.IO;

namespace AHORCADOGAME
{
    [Activity(Label = "AHORCADOGAME", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        public static ImageView _imageView;
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
                _imageView = FindViewById<ImageView>(Resource.Id.imageView1);
                button.Click += TakeAPicture;
            }


            //  var btn_caaptura = FindViewById<Button>(Resource.Id.btn_captura);
            var btn_empezar = FindViewById<Button>(Resource.Id.btn_empezar);
            var btn_salir = FindViewById<Button>(Resource.Id.btn_salir);
            var txt_nombre = FindViewById<EditText>(Resource.Id.txtNombre);


            btn_empezar.Click += (s, e) =>
            {
                var intent = new Intent(this, typeof(menuActivity));

                intent.PutExtra(menuActivity.LLAVE_NOMBRE,txt_nombre.Text);


                StartActivity(intent);


            };
            btn_salir.Click += (s, e) =>
            {
                Finish();
                
            };
        }
        public static class App
        {
            public static Java.IO.File _file;
            public static Java.IO.File _dir;
            public static Bitmap bitmap;
        }


        private void CreateDirectoryForPictures()
        {
            App._dir = new Java.IO.File(
                Android.OS.Environment.GetExternalStoragePublicDirectory(
                    Android.OS.Environment.DirectoryPictures), "AhorcadoFoto");
            if (!App._dir.Exists())
            {
                App._dir.Mkdirs();
            }
        }

        private bool IsThereAnAppToTakePictures()
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            IList<ResolveInfo> availableActivities =
                PackageManager.QueryIntentActivities(intent, PackageInfoFlags.MatchDefaultOnly);
            return availableActivities != null && availableActivities.Count > 0;
        }

        private void TakeAPicture(object sender, EventArgs eventArgs)
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            App._file = new Java.IO.File(App._dir, String.Format("myPhoto_{0}.jpg", Guid.NewGuid()));
            intent.PutExtra(MediaStore.ExtraOutput, Android.Net.Uri.FromFile(App._file));
            StartActivityForResult(intent, 0);
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            // Make it available in the gallery

            Intent mediaScanIntent = new Intent(Intent.ActionMediaScannerScanFile);
            Android.Net.Uri contentUri = Android.Net.Uri.FromFile(App._file);
            mediaScanIntent.SetData(contentUri);
            SendBroadcast(mediaScanIntent);

            // Display in ImageView. We will resize the bitmap to fit the display.
            // Loading the full sized image will consume to much memory
            // and cause the application to crash.

            int height = Resources.DisplayMetrics.HeightPixels;
            int width = _imageView.Height;
            //App.bitmap = App._file.Path.LoadAndResizeBitmap(width, height);
            App.bitmap = Bitmap.CreateScaledBitmap(App.bitmap, width, height, true);
            if (App.bitmap != null)
            {
                _imageView.SetImageBitmap(App.bitmap);
                App.bitmap = null;
            }

            // Dispose of the Java side bitmap.
            GC.Collect();
        }

    }
}

