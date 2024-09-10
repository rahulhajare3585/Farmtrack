using UIKit;
#if __ANDROID__
using Android.Content.Res;
#endif

namespace FarmTrack;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
		{
#if __ANDROID__
			handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#elif __IOS__
			handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
			handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
#endif
		});
		MainPage = new AppShell();
	}
}

