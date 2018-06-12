using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using System.Threading.Tasks;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace lus
{
    [Activity(Label = "splashscreem", MainLauncher = true, NoHistory = true)]
    public class splashscreem : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
        }

        // Desabilitamos que el usuario vuelva atraz
        public override void OnBackPressed() { }

        // Espera 8 segundos
        async void SimulateStartup()
        {
            //Log.Debug(TAG, "Performing some startup work that takes a bit of time.");
            await Task.Delay(8000);
            //Log.Debug(TAG, "Startup work is finished - starting MainActivity.");
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}