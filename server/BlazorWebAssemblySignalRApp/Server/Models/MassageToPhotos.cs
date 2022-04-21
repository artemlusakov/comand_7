using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssemblySignalRApp.Models
{
    public class MassageToPhotos
    {
        [Key]
        public int photo_id { get; set; }
        public int massage_id { get; set; }
        public Massages? Massages { get; set; }
        public List<Photo> Photos { get; set; }
    }
}
