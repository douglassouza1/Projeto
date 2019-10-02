using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;
using Android.Widget;

namespace Projeto
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText mensagem;
        Button button1;
        ImageView ImageView1;
     


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            mensagem = FindViewById<EditText>(Resource.Id.editText1);
            button1 = FindViewById<Button>(Resource.Id.button1);
            ImageView1 = FindViewById<ImageView>(Resource.Id.imageView1);

            button1.Click += delegate {

                Intent i = new Intent(this, typeof(MainActivity2));
                i.PutExtra("mensagem", mensagem.Text);
                StartActivityForResult(i, 0);

            };







        }
    }
}