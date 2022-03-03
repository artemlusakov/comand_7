using System;

namespace WebApplication1.Models
{
    public class ConsignmentNote
    {
        public int Id { get; set; }
        public int idCounterparty { get; set; }
        public int idEmployee { get; set; }
        public DateTime dates { get; set; }
    }
}
