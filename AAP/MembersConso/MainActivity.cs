using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Net;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MembersConso
{
    [Activity(Label = "MembersConso", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private ListView mListView;
        private List<Member> mMembers;
        private WebClient mClient;
        private Uri mUrl;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mListView = FindViewById<ListView>(Resource.Id.listView);
            mMembers = new List<Member>();
            mClient = new WebClient();
            mUrl = new Uri("https://script.google.com/macros/s/AKfycbzUCDqjiZgELd0X40jlHvoT3LEz-uab9mYx5pqKzE37hVGE6re1/exec");

            mClient.DownloadDataAsync(mUrl);
            mClient.DownloadDataCompleted += mClient_DowloaddataCompleted;


        }

        private void mClient_DowloaddataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            RunOnUiThread(() =>
                {
                    string json = Encoding.UTF8.GetString(e.Result);
                    mMembers = JsonConvert.DeserializeObject<List<Member>>(json);

                });
        }
    }
}

