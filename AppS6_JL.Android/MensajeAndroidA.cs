using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppS6_JL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace AppS6_JL.Droid
{
    class MensajeAndroidA 
    {
        public void longAlert(string mensaje)
        {
            Toast.MakeText(Application.Context, mensaje, ToastLength.Long).Show();
        }

        public void shortAlert(string mensaje)
        {
            Toast.MakeText(Application.Context, mensaje, ToastLength.Short).Show();
        }
    }
}