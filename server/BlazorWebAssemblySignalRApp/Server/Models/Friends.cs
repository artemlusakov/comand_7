using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssemblySignalRApp.Models
{
    public class Friends
    {
        [Key]
        public int Id_friends { get; set; }
        public int User_id { get; set; }
        public DateTime Time_creation { get; set; }
        public User? User { get; set; }

    }
}
