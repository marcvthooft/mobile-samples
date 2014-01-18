using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using BluetoothLEExplorer.iOS.UI.Screens.Scanner.Home;

namespace BluetoothLEExplorer.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		UINavigationController _nav;
		UIStoryboard _storyboard;


		//
		// This method is invoked when the application has loaded and is ready to run. In this
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			_storyboard = UIStoryboard.FromName ("Main", null);
			this._nav = new UINavigationController( (ScannerHome)_storyboard.InstantiateInitialViewController () );

			this.window.RootViewController = _nav;

			// make the window visible
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

