using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class WypozyczalniaContext : DbContext
{
    public DbSet<Klienci> Klient{ get; set; }
    public DbSet<Pracownicy> Pracownik { get; set; }

    public string ConnectionString { get; }

    public WypozyczalniaContext(string connectionString)
    {
        this.ConnectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(this.ConnectionString);
    }
}

public class Klienci
{
    public int Id { get; set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string PESEL { get; set; }
    public string Email { get; set; }
    public string Telefon { get; set; }

}

public class Pracownicy
{
    public int Id { get; set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Telefon { get; set; }

}
   