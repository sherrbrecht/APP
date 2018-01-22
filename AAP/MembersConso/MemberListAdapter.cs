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

namespace MembersConso
{
    class MemberListAdapter : BaseAdapter<Member>
    {

        private Context Context;
        public List<Member> LstMembers;

        public MemberListAdapter(Context context, List<Member> members)
        {
           Context = context;
           LstMembers = members;
        }
        
        public override int Count
        {
            get { return LstMembers.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }
        
        public override Member this[int position] 
        {
            get {return LstMembers[position]; }
        }


        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            //MemberListAdapterViewHolder holder = null;

            if (row == null)
            {
                row = LayoutInflater.From(Context).Inflate(Resource.Layout.MemberRow,null,false);
            }
             
            TextView txtName = row.FindViewById<TextView>(Resource.Id.txtName);
            txtName.Text = LstMembers[position].Name;

            TextView txtFirstName = row.FindViewById<TextView>(Resource.Id.txtFirstName);
            txtFirstName.Text = LstMembers[position].FirstName;

            TextView txtAmount = row.FindViewById<TextView>(Resource.Id.txtAmount);
            txtAmount.Text = Convert.ToString(LstMembers[position].Amount);

            return row;
        }




    }
    /*

    class MemberListAdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
    */
}