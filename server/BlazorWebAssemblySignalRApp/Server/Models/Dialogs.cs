using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssemblySignalRApp.Models
{
    public class Dialogs
    {
        [Key]
        public int Id { get; set; }
        public string Name_dialogs { get; set; }
        public DateTime Time_creation { get; set; }

        public List<Role> Roles { get; set; }
        public List<Massages> Massages { get; set; }
        public List<UserToDialogs> UserToDialogs { get; set; }
    }
}
