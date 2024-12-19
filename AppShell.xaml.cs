using MauiBugTest.Views;

namespace MauiBugTest;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
			Routing.RegisterRoute("pdfViewver", typeof(PdfViewver));
	}
}
