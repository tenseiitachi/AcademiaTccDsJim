using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace TccFinal.Activitys
{
    [Activity(Label = "CalculoImc")]
    public class CalculoImc : Activity
    {
        EditText edtCalcAltura;
        EditText edtCalcPeso;
        Button BtnCalcular;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.TelaCalculoImc);

            edtCalcAltura = FindViewById<EditText>(Resource.Id.edtCalcAltura);
            edtCalcPeso = FindViewById<EditText>(Resource.Id.edtCalcPeso);
            BtnCalcular = FindViewById<Button>(Resource.Id.btnCalcular);


            BtnCalcular.Click += BtnCalcular_Click;







        }


        void BtnCalcular_Click(object sender, EventArgs e)
        {
           
            double altura = double.Parse(edtCalcAltura.Text);
           
            double peso = double.Parse(edtCalcPeso.Text);
            double Resultado = peso / (altura * altura);








            if (Resultado <= 18.5)
            // MAGREZA exibir opinião médica e abrir a tela para exercícios para magreza definição
            {

                var magrezaAtividade = new Intent(this, typeof(ActivityMagreza));

                StartActivity(magrezaAtividade);
            }
            else if (Resultado <= 24.9)
            //NORMAL exibir opinião médica e abrir exercícios para definição
            {
                var normalAtividade = new Intent(this, typeof(ActivityNormal));
                StartActivity(normalAtividade);

            }
            else if (Resultado <= 29.9)
            //SOBREPESO abrir exercícios para sobrepeso e definição 
            {
                var sobrepesoAtividade = new Intent(this, typeof(ActivitySobrepeso));
                StartActivity(sobrepesoAtividade);
            }
            else if (Resultado <= 39.9)
            //OBESIDADE exibir opinião médica e abrir exercícios para obesidade e definição
            {
                var obesidadeAtividade = new Intent(this, typeof(ActivityObesidade));
                StartActivity(obesidadeAtividade);
            }
            else
            //OBESIDADE GRAVE exibir opinião médica e abrir exercícios para obesidade grave e definição
            {
                var obesidadeGraveAtividade = new Intent(this, typeof(ActivityObesidadeGrave));
                StartActivity(obesidadeGraveAtividade);
            }

        }



    }

}
 