using MauiBugTest.ViewModels;

namespace MauiBugTest.Views;

public partial class PdfViewver : ContentPage
{
	public PdfViewver(PdfViewerViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}