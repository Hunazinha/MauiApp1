using CommunityToolkit.Mvvm.Input;
using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class ChamadosPage : ContentPage
{
    public ChamadosPage()
    {
        InitializeComponent();
    }

    [RelayCommand]
    private async void NavigateToNovoChamado() => await Shell.Current.GoToAsync("NovoChamadoPage");
}
