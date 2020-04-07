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

        public TextView txt_description;
        public IItemClickListenener itemClickListener;

        public RecyclerViewHolder(View itemView) : base(itemView)
        {
            txt_description = itemView.FindViewById<TextView>(Resource.Id.textDescription);
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
        private List<string> listData = new List<string>();
        private Context context;

        public RecyclerAdapter(List<string> listData, Context context)
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
            RecyclerViewHolder vh = holder as RecyclerViewHolder;
            vh.txt_description.Text = listData[position];
            vh.SetItemClickListener(this);
        }

        public void OnClick(View itemView, int position, bool isLongClick)
        {
            if (isLongClick)
            {
                Toast.MakeText(context, "Long Click:" + listData[position], ToastLength.Long).Show();
            }
            else
            {
                Toast.MakeText(context, " " + listData[position], ToastLength.Long).Show();
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            LayoutInflater inflater = LayoutInflater.From(parent.Context);
            View itemView = inflater.Inflate(Resource.Layout.rvListItems, parent, false);
            return new RecyclerViewHolder(itemView);
        }
    }
}