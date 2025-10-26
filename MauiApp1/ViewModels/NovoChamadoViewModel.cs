using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;
using MauiApp1.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Android.Icu.Text.CaseMap;


    namespace MauiApp1.ViewModels
    {
        private readonly TicketService _ticketService;
        [ObservableProperty]
        private string titulo;
        [ObservableProperty]
        private string descricao;
        [ObservableProperty]
        private string selectedArea;
        public ObservableCollection<string> Areas { get; } = new ObservableCollection<string> { "TI", "RH", "Financeiro", "Operacional" };
        public NovoChamadoViewModel()
        {
            _ticketService = new TicketService();
        }
        [RelayCommand]
        private async void CriarChamado()
        {
            if (string.IsNullOrWhiteSpace(Titulo) || string.IsNullOrWhiteSpace(Descricao) || string.IsNullOrWhiteSpace(SelectedArea))
                return;  // Validação básica
            var novoTicket = new Ticket
            {
                Titulo = Titulo,
                Descricao = Descricao,
                Area = SelectedArea,
                Status = TicketStatus.Pendente
            };
            _ticketService.AddTicket(novoTicket);

            // Limpar campos e navegar de volta (usando Shell)
            Titulo = string.Empty;
            Descricao = string.Empty;
            SelectedArea = null;
            await Shell.Current.GoToAsync("..");  // Volta para a página anterior
        }
    }
    }