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
    public class Member
    {
        /// <summary>
        /// 
        /// </summary>
        private string name;

        /// <summary>
        /// 
        /// </summary>
        private string firstName;

        /// <summary>
        /// 
        /// </summary>
        private double amount;


        public string Name { get => name; set => name = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public double Amount { get => amount; set => amount = value; }
    }
}