using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
       
        string connectionString = @"Data Source=DESKTOP-QR4BK4H;Initial Catalog=Wypozyczalnia;Integrated Security=True";

        using (WypozyczalniaContext db = new WypozyczalniaContext(connectionString))
        {
            Console.WriteLine($"Database ConnectionString: {db.ConnectionString}.");

           //Dodawanie
            Console.WriteLine("Dodaj nowego klienta");

            db.Add(new Klienci { Imie="Kamil",Nazwisko="Krech",PESEL="123456789",Email="lubieplacki@gmail.com", Telefon="213769420" });
            db.SaveChanges();
           
           
        
        }
    }
}