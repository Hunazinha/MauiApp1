using CommunityToolkit.Mvvm.Input;
using MauiApp1.ViewModels;

namespace MeuSistemaChamados.Views;
public partial class ChamadosPage : ContentPage
{
    public ChamadosPage()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    // Adicione um comando para navegar (se necessário)
    [RelayCommand]
    private async void NavigateToNovoChamado() => await Shell.Current.GoToAsync("NovoChamadoPage");
}
