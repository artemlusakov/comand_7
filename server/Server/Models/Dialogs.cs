using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssemblySignalRApp.Models
{
    public class Dialogs
    {
        [Key]
        public int Id { get; set; }
        public string Name_dialogs { get; set; }
        public DateTime time_creation { get; set; }
    }
}
