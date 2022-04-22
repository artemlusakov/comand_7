using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssemblySignalRApp.Models
{
    public class User
    {
        [Key]
        public int Id_user { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime time_creation { get; set; }

        public List<Friends> friends { get; set; }
        public List<Role> roles { get; set; }
        public List<UserToDialogs> usersToDialogs { get; set; }
    }
}
