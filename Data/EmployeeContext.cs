using EmployeeManagement.Models; // Importiert den Namespace, der das Employee-Modell enthält
using Microsoft.EntityFrameworkCore; // Importiert Entity Framework Core

namespace EmployeeManagement.Data // Definiert den Namespace für die Datenzugriffsschicht
{
    public class EmployeeContext : DbContext // Leitet von der DbContext-Klasse ab, die die Verbindung zur Datenbank verwaltet
    {
        // Konstruktor, der DbContextOptions<EmployeeContext> als Argument erhält und diese Optionen an die Basisklasse weitergibt
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        // DbSet-Eigenschaft, die die Employees-Tabelle in der Datenbank darstellt
        public DbSet<Employee> Employees { get; set; }

        // Überschreibt die OnModelCreating-Methode, um die Tabelle und die Modellkonfiguration zu spezifizieren
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Spezifiziert, dass die Employee-Entität der Tabelle "Employee" in der Datenbank entspricht
            modelBuilder.Entity<Employee>().ToTable("Employee");
        }
    }
}
