using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssemblySignalRApp.Models
{
    public class Photo
    {
        [Key]
        public int Photo_id { get; set; }
        public string Path { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime time_creation { get; set; }

        public MassageToPhotos? massageToPhotos { get; set; }
    }
}
