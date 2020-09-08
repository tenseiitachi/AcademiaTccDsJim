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
using TccFinal.Activitys.Alimentacao;
using TccFinal.Activitys.DefinicaoExercicios;

namespace TccFinal.Activitys
{
    [Activity(Label = "ActivityMagreza")]
    public class ActivityMagreza : Activity
    {
        ImageButton ImgAlimentacao;
        ImageButton ImgExercicios;
        ImageButton ImgGanhoDeMassa;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.TelaMagreza);



            ImgAlimentacao = FindViewById<ImageButton>(Resource.Id.imgAlimentacao);
            ImgExercicios = FindViewById<ImageButton>(Resource.Id.imgExercicios);
            ImgGanhoDeMassa = FindViewById<ImageButton>(Resource.Id.imgGanhoDeMassa);


            ImgAlimentacao.Click += ImgAlimentacao_Click;

            ImgGanhoDeMassa.Click += ImgGanhoDeMassa_Click;

            ImgExercicios.Click += ImgExercicios_Click;
        }

        private void ImgExercicios_Click(object sender, EventArgs e)
        {
            var ActivityExercicios = new Intent(this, typeof(ActivityExercicios));
            StartActivity(ActivityExercicios);
        }

        private void ImgGanhoDeMassa_Click(object sender, EventArgs e)
        {
            var ActivityGanhoDeMassa = new Intent(this, typeof(ActivityGanhoDeMassa));
            StartActivity(ActivityGanhoDeMassa);
        }

        private void ImgAlimentacao_Click(object sender, EventArgs e)
        {
           var ActivityAlimentacaoMagreza = new Intent(this, typeof(ActivityAlimentacaoMagreza));
            StartActivity(ActivityAlimentacaoMagreza);
        }
    }
}