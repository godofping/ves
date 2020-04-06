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

namespace ves
{
    [Activity(Label = "ControlPanelActivity")]
    public class ControlPanelActivity : Activity
    {

        EL.Matches matchEL = new EL.Matches();
        DL.Matches matchDL = new DL.Matches();

        Button btnTeamAAddScore, btnTeamAMinusScore, btnTeamAAddTimeout, btnTeamAMinusTimeout, btnTeamBAddScore, btnTeamBMinusScore, btnTeamBAddTimeout, btnTeamBMinusTimeout, btnMatchInformation, btnEndSet, btnSaveMatch, btnReset;
        TextView tvSetNumber, tvTeamAName, tvTeamAWonSet, tvTeamAScore, tvTeamATimeout, tvTeamBName, tvTeamBWonSet, tvTeamBScore, tvTeamBTimeout;


        private void initialize()
        {

            btnTeamAAddScore = (Button)FindViewById(Resource.Id.btnTeamAAddScore);
            btnTeamAMinusScore = (Button)FindViewById(Resource.Id.btnTeamAMinusScore);
            btnTeamAAddTimeout = (Button)FindViewById(Resource.Id.btnTeamAAddTimeout);
            btnTeamAMinusTimeout = (Button)FindViewById(Resource.Id.btnTeamAMinusTimeout);

            btnTeamBAddScore = (Button)FindViewById(Resource.Id.btnTeamBAddScore);
            btnTeamBMinusScore = (Button)FindViewById(Resource.Id.btnTeamBMinusScore);
            btnTeamBAddTimeout = (Button)FindViewById(Resource.Id.btnTeamBAddTimeout);
            btnTeamBMinusTimeout = (Button)FindViewById(Resource.Id.btnTeamBMinusTimeout);

            btnMatchInformation = (Button)FindViewById(Resource.Id.btnMatchInformation);
            btnEndSet = (Button)FindViewById(Resource.Id.btnEndSet);
            btnSaveMatch = (Button)FindViewById(Resource.Id.btnSaveMatch);
            btnReset = (Button)FindViewById(Resource.Id.btnReset);

            tvSetNumber = (TextView)FindViewById(Resource.Id.tvSetNumber);
            tvTeamAName = (TextView)FindViewById(Resource.Id.tvTeamAName);
            tvTeamAWonSet = (TextView)FindViewById(Resource.Id.tvTeamAWonSet);
            tvTeamAScore = (TextView)FindViewById(Resource.Id.tvTeamAScore);
            tvTeamATimeout = (TextView)FindViewById(Resource.Id.tvTeamATimeout);
            tvTeamBName = (TextView)FindViewById(Resource.Id.tvTeamBName);
            tvTeamBWonSet = (TextView)FindViewById(Resource.Id.tvTeamBWonSet);
            tvTeamBScore = (TextView)FindViewById(Resource.Id.tvTeamBScore);
            tvTeamBTimeout = (TextView)FindViewById(Resource.Id.tvTeamBTimeout);


        }


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_controlpanel);

            initialize();


        }
    }
}