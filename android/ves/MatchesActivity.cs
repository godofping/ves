using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using ves.Adapter;

namespace ves
{
    [Activity(Label = "MatchesActivity")]
    public class MatchesActivity : AppCompatActivity
    {
        List<string> listData = new List<string>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_matches);



            SetupList();
            var recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            recyclerView.HasFixedSize = true;
            var layoutmanager = new LinearLayoutManager(this);
            recyclerView.SetLayoutManager(layoutmanager);

            RecyclerAdapter adapter = new RecyclerAdapter(listData, this);
            recyclerView.SetAdapter(adapter);
        }

        private void SetupList()
        {
            for (int i = 1; i <= 10; i += 1)
            {
                listData.Add("Click me" + i);
            }
        }
    }
}