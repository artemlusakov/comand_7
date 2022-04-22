using BlazorWebAssemblySignalRApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAssemblySignalRApp.Data
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
        public DbSet<Dialogs> Dialogs { get; set; } = null!;
        public DbSet<Friends> Friends { get; set; } = null!;
        public DbSet<Massages> Massages { get; set; } = null!;
        public DbSet<MassageToPhotos> MassageToPhotos { get; set; } = null!;
        public DbSet<Photo> Photos { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<User> User { get; set; } = null!;
        public DbSet<UserToDialogs> UserToDialogs { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Photo>()
                .HasOne(d => d.massageToPhotos)
                .WithMany(f => f.Photos)
                .HasForeignKey(b => b.Photo_id);

            modelBuilder.Entity<MassageToPhotos>()
                .HasOne(d => d.Massages)
                .WithMany(f => f.massageToPhotos)
                .HasForeignKey(l => l.massage_id);

            modelBuilder.Entity<Massages>()
                .HasOne(d => d.Dialogs)
                .WithMany(f => f.massages)
                .HasForeignKey(s => s.dialog_id);

            modelBuilder.Entity<Friends>()
                .HasOne(d => d.User)
                .WithMany(f => f.friends)
                .HasForeignKey(a => a.user_id);

            modelBuilder.Entity<User>()
                .HasOne(d => d.roles)
                .WithMany(f => f.user)
                .HasForeignKey(q => q.Id_user);

            modelBuilder.Entity<Role>()
                .HasOne(d => d.dialogs)
                .WithMany(f => f.roles)
                .HasForeignKey(w => w.Id_dialogs);

            modelBuilder.Entity<UserToDialogs>()
                .HasOne(d => d.User)
                .WithMany(f => f.userToDialogs)
                .HasForeignKey(r => r.user_id);

            modelBuilder.Entity<UserToDialogs>()
                .HasOne(d => d.Dialogs)
                .WithMany(f => f.userToDialogs)
                .HasForeignKey(t => t.dialogs_id);
        }
    }

    
}
