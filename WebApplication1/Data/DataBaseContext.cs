using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebAppkication1.data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        public DbSet<Product> products { get; set; } = null!;

        public DbSet<CompositionConsignment> compositionConsignment { get; set; } = null!;

        public DbSet<ConsignmentNote> ConsignmentNote { get; set; }= null!;

        public DbSet<Conterparty> Conterparty { get; set; }= null!;

        public DbSet<Employee> Employee { get; set; }= null!;

        public DbSet<Position> Position { get; set; }= null!;

        public DbSet<TypeProduct> TypeProduct { get; set; }= null!;

        public DbSet<Unit> Unit { get; set; }=null!;


    }
}