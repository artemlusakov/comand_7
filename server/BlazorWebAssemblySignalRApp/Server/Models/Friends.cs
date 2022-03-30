using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssemblySignalRApp.Models
{
    public class Friends
    {
        [Key]
        public int Id_friends { get; set; }
        public int user_id { get; set; }
        public DateTime time_creation { get; set; }
        public User? User { get; set; }

    }
}
