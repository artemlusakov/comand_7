using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssemblySignalRApp.Models
{
    public class Massages
    {
        [Key]
        public int Id_massages { get; set; }
        public int Dialog_id { get; set; }
        public string Text { get; set; }
        public DateTime Time_creation { get; set; }
        public bool Text_changed { get; set; }

        public Dialogs? Dialogs { get; set; }
        public List<MassageToPhotos> MassageToPhotos { get; set; }
    }
}
