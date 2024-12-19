using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Storage;

namespace MauiBugTest.ViewModels;

public class PdfViewerViewModel : ObservableObject, IQueryAttributable
{
    public int Number { get; set; }
    public Stream PdfStream { get; set; }
    public PdfViewerViewModel()
    {
        Number = 42;
        PdfStream = new MemoryStream();
    }

    public async void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync("PDF_example.pdf");
        await fileStream.CopyToAsync(PdfStream);
    }
}