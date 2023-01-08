using KpopComebacks.ViewModel;
using KpopComebacks.Services; 

namespace KpopComebacks;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<MonkeysViewModel>();
        builder.Services.AddTransient<MonkeysViewModel>();
		builder.Services.AddSingleton<WebScraper>(); 
        builder.Services.AddTransient<MainPage>();
        return builder.Build();
	}
}
