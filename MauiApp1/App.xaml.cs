using MauiApp1.Services;

namespace MauiApp1;

public partial class App : Application
{
	public App(QRCodeService readerService)
	{
		InitializeComponent();

		MainPage = new MainPage(readerService);
	}
}
