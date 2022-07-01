using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Com.Unity3d.Ads;

namespace UnitySdkSample.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class InterstitialAdActivity : AppCompatActivity, IUnityAdsInitializationListener, IUnityAdsShowListener
    {
        private readonly string _unityGameID = "1234567";
        private readonly string _placementId = "video";
        private readonly bool _isTestMode = true;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_interstitial_ad);

            // Initialize the Ads SDK:
            UnityAds.Initialize(this, _unityGameID, _isTestMode);

            var showAdButton = FindViewById<Button>(Resource.Id.showAdButton);
            showAdButton.Click += ShowAdButton_Click;
        }

        private void ShowAdButton_Click(object sender, System.EventArgs e)
        {
            DisplayInterstitialAd();
        }

        private void DisplayInterstitialAd()
        {
	        UnityAds.Show(this, _placementId, this);
        }

        public void OnInitializationComplete()
        {

        }

        public void OnInitializationFailed(UnityAds.UnityAdsInitializationError p0, string p1)
        {

        }

        public void OnUnityAdsShowClick(string p0)
        {

        }

        public void OnUnityAdsShowComplete(string p0, UnityAds.UnityAdsShowCompletionState p1)
        {
        }

        public void OnUnityAdsShowFailure(string p0, UnityAds.UnityAdsShowError p1, string p2)
        {
	        Toast.MakeText(this, "Ad not yet loaded", ToastLength.Short);
        }

        public void OnUnityAdsShowStart(string p0)
        {

        }
    }
}
