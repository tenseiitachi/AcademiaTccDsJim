
using Android.App;
using Android.Content;
using Android.OS;

namespace TccFinal.Activitys.DefinicaoExercicios
{
    [Activity(Label = "ActivityExercicios")]

    public class ActivityExercicios : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var playId = Intent.Extras.GetInt("current_play_id", 0);

            var detailsFrag = FragmentExercicios.NewInstance(playId);
            FragmentManager.BeginTransaction()
                            .Add(Android.Resource.Id.Content, detailsFrag)
                            .Commit();
        }
    }
}