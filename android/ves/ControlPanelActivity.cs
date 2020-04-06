﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ves
{
    [Activity(Label = "ControlPanelActivity")]
    public class ControlPanelActivity : Activity
    {
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_controlpanel);

            var tvSetNumber = FindViewById<TextView>(Resource.Id.tvSetNumber);
        }
    }
}