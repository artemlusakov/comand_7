using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssemblySignalRApp.Models
{
    public class MassageToPhotos
    {
        [Key]
        public int Photo_id { get; set; }
        public int Massage_id { get; set; }
        public Massages? Massages { get; set; }
        public Photo? Photos { get; set; }
    }
}
