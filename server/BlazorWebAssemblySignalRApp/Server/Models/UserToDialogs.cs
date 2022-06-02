using System.ComponentModel.DataAnnotations;


namespace BlazorWebAssemblySignalRApp.Models
{
    public class UserToDialogs
    {
        [Key]
        public int Id_user_to_dialogs { get; set; }
        public int User_id { get; set; }
        public int Dialogs_id { get; set; }
        public DateTime Time_creation { get; set; } = DateTime.Now;

        public Dialogs? Dialogs { get; set; }
        public User? User { get; set; }
    }
}
