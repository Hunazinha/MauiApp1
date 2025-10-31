using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MauiApp1.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Area { get; set; }  // "TI", "RH", etc.
        public TicketStatus Status { get; set; }  // Enum para status
        public DateTime DataCriacao { get; set; }
    }
    public enum TicketStatus
    {
        Pendente,
        EmAndamento,
        Finalizado
    }
}