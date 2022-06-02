using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssemblySignalRApp.Models
{
    public class Photo
    {
        [Key]
        public int Photo_id { get; set; }
        public string Path { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime Time_creation { get; set; }

        public MassageToPhotos? MassageToPhotos { get; set; }
    }
}
