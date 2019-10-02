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
using Android.Webkit;

namespace Projeto
{
    [Activity(Label = "MainActivity2")]
    public class MainActivity2 : Activity
    {
        
        EditText segundo;
        Button button2;
        TextView textoVisor;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetContentView(Resource.Layout.layout2);


            base.OnCreate(savedInstanceState);





            segundo = FindViewById<EditText>(Resource.Id.segundo);
            button2 = FindViewById<Button>(Resource.Id.button2);
            textoVisor = FindViewById<TextView>(Resource.Id.textoVisor);


            
            textoVisor.Text = Intent.GetStringExtra("mensagem");


            button2.Click += delegate
            {
                Intent a = new Intent(this, typeof(MainActivity));
                a.PutExtra("foto", ImageView..view1);
                SetResult(Result.Ok, a);
                Finish();


                





            };




            // Create your application here
        }
    }
}