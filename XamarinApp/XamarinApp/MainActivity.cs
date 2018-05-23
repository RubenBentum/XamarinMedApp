using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System.Linq;
using Android.Views;



namespace XamarinApp
{
    [Activity(Label = "XamarinApp", MainLauncher = true)]
    public class MainActivity : Activity
    {

        private List<string> mItems;
        private ListView mListView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mListView = FindViewById<ListView>(Resource.Id.listView1);

            mItems = new List<string>();
            mItems.Add("Button 1");
            mItems.Add("Button 2");
            mItems.Add("Button 3");

            ListViewAdapter adapter = new ListViewAdapter(this, mItems);
                        
            mListView.Adapter = adapter;

            

        }
    }
}

