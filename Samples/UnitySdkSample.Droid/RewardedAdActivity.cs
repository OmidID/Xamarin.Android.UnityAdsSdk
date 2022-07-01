using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Com.Unity3d.Ads;
using static Com.Unity3d.Ads.UnityAds;

namespace UnitySdkSample.Droid
{
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
	public class RewardedAdActivity : AppCompatActivity, IUnityAdsInitializationListener, IUnityAdsShowListener
	{
		private readonly string _unityGameID = "1234567";
		private readonly string _placementId = "Rewarded";
		private readonly bool _isTestMode = true;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_rewarded_ad);

			// Initialize the Ads SDK:
			Initialize(this, _unityGameID, _isTestMode, this);

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
			//
		}

		public void OnInitializationFailed(UnityAdsInitializationError p0, string p1)
		{
			//
		}

		public void OnUnityAdsShowClick(string p0)
		{
		}

		public void OnUnityAdsShowComplete(string p0, UnityAdsShowCompletionState p1)
		{
		}

		public void OnUnityAdsShowFailure(string p0, UnityAdsShowError p1, string p2)
		{
			Toast.MakeText(this, "Ad not yet loaded", ToastLength.Short);
		}

		public void OnUnityAdsShowStart(string p0)
		{
		}
	}
}
