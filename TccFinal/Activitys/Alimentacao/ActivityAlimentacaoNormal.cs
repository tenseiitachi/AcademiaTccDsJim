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

namespace TccFinal.Activitys.Alimentacao
{
    [Activity(Label = "ActivityAlimentacaoNormal")]
    public class ActivityAlimentacaoNormal : ListActivity
    {
        static readonly string[] alimentos = new String[] { "Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra" };
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            ListAdapter = new ArrayAdapter<string>(this, Resource.Layout.list_item, alimentos);

            ListView.TextFilterEnabled = true;

            ListView.FastScrollEnabled = true;

            ListView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Short).Show();
            };
        }
    }
}