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
                .HasOne(d => d.MassageToPhotos)
                .WithMany(f => f.Photos)
                .HasForeignKey(b => b.Photo_id);

            modelBuilder.Entity<MassageToPhotos>()
                .HasOne(d => d.Massages)
                .WithMany(f => f.MassageToPhotos)
                .HasForeignKey(l => l.Massage_id);

            modelBuilder.Entity<Massages>()
                .HasOne(d => d.Dialogs)
                .WithMany(f => f.Massages)
                .HasForeignKey(s => s.Dialog_id);

            modelBuilder.Entity<Friends>()
                .HasOne(d => d.User)
                .WithMany(f => f.Friends)
                .HasForeignKey(a => a.User_id);

            modelBuilder.Entity<User>()
                .HasOne(d => d.Roles)
                .WithMany(f => f.User)
                .HasForeignKey(q => q.Id_user);

            modelBuilder.Entity<Role>()
                .HasOne(d => d.Dialogs)
                .WithMany(f => f.Roles)
                .HasForeignKey(w => w.Id_dialogs);

            modelBuilder.Entity<UserToDialogs>()
                .HasOne(d => d.User)
                .WithMany(f => f.UserToDialogs)
                .HasForeignKey(r => r.User_id);

            modelBuilder.Entity<UserToDialogs>()
                .HasOne(d => d.Dialogs)
                .WithMany(f => f.UserToDialogs)
                .HasForeignKey(t => t.Dialogs_id);
        }
    }

    
}
