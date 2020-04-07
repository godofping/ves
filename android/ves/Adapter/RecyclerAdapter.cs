using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace ves.Adapter
{


    public class RecyclerViewHolder : RecyclerView.ViewHolder, View.IOnClickListener, View.IOnLongClickListener
    {

        public TextView textMatchNumber, textTeamAName, textTeamBName, textDate, textTime, textDateModified;
        public IItemClickListenener itemClickListener;

        public RecyclerViewHolder(View itemView) : base(itemView)
        {
            textMatchNumber = itemView.FindViewById<TextView>(Resource.Id.textMatchNumber);
            textTeamAName = itemView.FindViewById<TextView>(Resource.Id.textTeamAName);
            textTeamBName = itemView.FindViewById<TextView>(Resource.Id.textTeamBName);
            textDate = itemView.FindViewById<TextView>(Resource.Id.textDate);
            textTime = itemView.FindViewById<TextView>(Resource.Id.textTime);
            textDateModified = itemView.FindViewById<TextView>(Resource.Id.textDateModified);

            itemView.SetOnClickListener(this);
            itemView.SetOnLongClickListener(this);
        }

        public void SetItemClickListener(IItemClickListenener itemClickListener)
        {
            this.itemClickListener = itemClickListener;
        }

        public void OnClick(View v)
        {
            itemClickListener.OnClick(v, AdapterPosition, false);
        }

        public bool OnLongClick(View v)
        {
            itemClickListener.OnClick(v, AdapterPosition, true);
            return true;
        }
    }

    public class RecyclerAdapter : RecyclerView.Adapter, IItemClickListenener
    {
        private List<int> listData = new List<int>();
        private Context context;

        public RecyclerAdapter(List<int> listData, Context context)
        {
            this.listData = listData;
            this.context = context;
        }

        public override int ItemCount
        {
            get
            {
                return listData.Count;
            }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            EL.Matches matchEL = new EL.Matches();
            DL.Matches matchDL = new DL.Matches();

            matchEL.Matchid = listData[position];

            matchEL = matchDL.Select(matchEL);

            RecyclerViewHolder vh = holder as RecyclerViewHolder;
            vh.textMatchNumber.Text = "Match Number: " + matchEL.Matchnumber;
            vh.textTeamAName.Text = "Team A Name: " + matchEL.Teamaname;
            vh.textTeamBName.Text = "Team B Name: " + matchEL.Teambname;
            vh.textDate.Text = "Match Date: " + matchEL.Matchdate;
            vh.textTime.Text = "Match Time: " + matchEL.Matchtime;
            vh.textDateModified.Text = "Date modified: " + matchEL.Matchsaveddatetime;
            vh.SetItemClickListener(this);
        }

        public void OnClick(View itemView, int position, bool isLongClick)
        {

            Intent cp = new Intent(context, typeof(ViewMatchInformationActivity));
            cp.PutExtra("matchid", listData[position].ToString());
            context.StartActivity(cp);
            


        }


        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            LayoutInflater inflater = LayoutInflater.From(parent.Context);
            View itemView = inflater.Inflate(Resource.Layout.rvListItems, parent, false);
            return new RecyclerViewHolder(itemView);
        }
    }
}