using MauiApp1.Models;

namespace MauiApp1.Services
{
    public class TicketService
    {
        // 🔸 Cria uma instância única (singleton)
        private static readonly TicketService _instance = new TicketService();
        public static TicketService Instance => _instance;

        private List<Ticket> _tickets = new()
        {
            new Ticket { Id = 1, Titulo = "Problema no computador", Descricao = "PC não liga", Area = "TI", Status = TicketStatus.Pendente, DataCriacao = DateTime.Now.AddDays(-1) },
            new Ticket { Id = 2, Titulo = "Folha de pagamento", Descricao = "Erro no cálculo", Area = "RH", Status = TicketStatus.EmAndamento, DataCriacao = DateTime.Now.AddDays(-2) },
            new Ticket { Id = 3, Titulo = "Chamado resolvido", Descricao = "Impressora consertada", Area = "TI", Status = TicketStatus.Finalizado, DataCriacao = DateTime.Now.AddDays(-3) }
        };

        public List<Ticket> GetTickets() => _tickets;

        public void AddTicket(Ticket ticket)
        {
            ticket.Id = _tickets.Max(t => t.Id) + 1;
            ticket.DataCriacao = DateTime.Now;
            _tickets.Add(ticket);
        }

        public List<Ticket> GetTicketsByStatus(TicketStatus status)
            => _tickets.Where(t => t.Status == status).ToList();
    }
}
