using MauiBugTest.ViewModels;
using MauiBugTest.Views;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace MauiBugTest;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NCaF5cXmZCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWH9fcHRcRmReWEx0W0Q="); // Syncfusion License Key
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NDaF5cWWtCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWH9ccXVVRmBeVUB0XEM="); // Syncfusion License Key
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NMaF5cXmBCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWH1fc3RXRGFcV0dzV0I=");
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.RegisterViewModels()
			.RegisterViews();
		builder.ConfigureSyncfusionCore();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
	private static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
	{
		builder.Services.AddSingleton<PdfViewerViewModel>();
		return builder;
	}
	private static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
	{

		builder.Services.AddTransient<PdfViewver>();
		builder.Services.AddTransient<Page1>();
		builder.Services.AddTransient<Page2>();
		return builder;
	}

}
