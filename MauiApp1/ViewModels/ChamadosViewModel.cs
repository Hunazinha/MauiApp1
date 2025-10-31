using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;
using MauiApp1.Services;
using System.Collections.ObjectModel;
using System.Linq;
using MauiApp1.Views;

namespace MauiApp1.ViewModels
{
    public partial class ChamadosViewModel : ObservableObject
    {
        private readonly TicketService _ticketService;

        [ObservableProperty]
        private ObservableCollection<Ticket> pendentes;

        [ObservableProperty]
        private ObservableCollection<Ticket> emAndamento;

        [ObservableProperty]
        private ObservableCollection<Ticket> finalizados;

        public ChamadosViewModel()
        {
            _ticketService = new TicketService();
            LoadTickets();
        }

        private void LoadTickets()
        {
            var allTickets = _ticketService.GetTickets();
            Pendentes = new ObservableCollection<Ticket>(allTickets.Where(t => t.Status == TicketStatus.Pendente));
            EmAndamento = new ObservableCollection<Ticket>(allTickets.Where(t => t.Status == TicketStatus.EmAndamento));
            Finalizados = new ObservableCollection<Ticket>(allTickets.Where(t => t.Status == TicketStatus.Finalizado));
        }

        [RelayCommand]
        private void Refresh() => LoadTickets();
    
        [RelayCommand]
        private async Task NavigateToNovoChamado()
        {
            {
                await Shell.Current.GoToAsync(nameof(NovoChamadoPage));
            }
        }
    }
}

