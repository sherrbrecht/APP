using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Net;
using System.Collections.Generic;

namespace MembersConso
{
    [Activity(Label = "MembersConso", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private ListView mListView;
        private List<Member> mMembers;
        private WebClient mClient;
        private Uri mUri;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

