using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssemblySignalRApp.Models
{
    public class Role
    {
        [Key]
        public int Id_roles { get; set; }
        public int User_id { get; set; }
        public int Id_dialogs { get; set; }
        public bool role { get; set; }

        public Dialogs? Dialogs { get; set; }
        public List<User> User { get; set; }

    }
}
