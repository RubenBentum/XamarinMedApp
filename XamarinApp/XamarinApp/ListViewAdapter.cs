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

namespace XamarinApp
{
    class ListViewAdapter : BaseAdapter<string>
    {
        private List<string> mItems;
        private Context mContext;
        public ListViewAdapter(Context context, List<string> items)
        {
            mItems = items;
            mContext = context;
        }

        // overrides inherited objects that are not used
        public override int Count { get { return mItems.Count; } }
        public override long GetItemId(int position) { return position;}
        public override string this[int position] { get { return mItems[position]; } }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.layoutScreen1, null, false);
            }

            TextView textScreen1 = row.FindViewById<TextView>(Resource.Id.textScreen1);
            textScreen1.Text = mItems[position];

            return row;

        }
        
    }
}