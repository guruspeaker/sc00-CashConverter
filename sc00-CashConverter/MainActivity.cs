using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace sc00_CashConverter
{
    [Activity(Label = "sc00_CashConverter", MainLauncher = true)]
    public class MainActivity : Activity
    {
        int countClicks = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // get hold of out button
            Button button = FindViewById<Button>(Resource.Id.btnConvert);
            EditText amount2Convert = FindViewById<EditText>(Resource.Id.editTextAmount);
            TextView result = FindViewById<TextView>(Resource.Id.textViewResult);
            button.Click += delegate
            {
                if (amount2Convert.Text.Length < 1)
                {
                    Toast.MakeText(this, "Please enter something!", ToastLength.Short).Show();
                    result.Text = "";
                    return;
                } else
                {
                    var convertedAmt = Convert.ToDouble(amount2Convert.Text) * 0.85;
                    result.Text = "$" + amount2Convert.Text + " =€" + convertedAmt; 
                }
            };
        }
    }
}

