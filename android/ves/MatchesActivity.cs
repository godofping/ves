using System;
using System.Collections.Generic;
using System.Data;
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
        List<int> listData = new List<int>();
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

            DL.Matches matchDL = new DL.Matches();

            var dt = matchDL.List("");


            foreach (DataRow row in dt.Rows)
            {
                listData.Add(Convert.ToInt32(row["matchid"]));
            }


       
          


      
           
        }
    }
}