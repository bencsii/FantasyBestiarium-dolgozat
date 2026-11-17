using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace FantasyBestiarium
{
    internal class SzornyAdatbazis
    {
        string connectionString = "Server=localhost;Database=mydatabase;User=root;Password=;";


        
        public void Feltolt(List<Szorny> szornyek)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (var szorny in szornyek)
                {
                    var command = new SqlCommand("INSERT INTO Szornyek (Id, Nev, VeszelyessegiSzint, Elohely, FoGyengeseg, LeggyakoribbZsakmany, VeszelyesE) VALUES (@Id, @Nev, @VeszelyessegiSzint, @Elohely, @FoGyengeseg, @LeggyakoribbZsakmany, @VeszelyesE)", connection);
                    command.Parameters.AddWithValue("@Id", szorny.Id);
                    command.Parameters.AddWithValue("@Nev", szorny.Nev);
                    command.Parameters.AddWithValue("@VeszelyessegiSzint", szorny.VeszelyessegiSzint);
                    command.Parameters.AddWithValue("@Elohely", szorny.Elohely);
                    command.Parameters.AddWithValue("@FoGyengeseg", szorny.FoGyengeseg);
                    command.Parameters.AddWithValue("@LeggyakoribbZsakmany", szorny.LeggyakoribbZsakmany);
                    command.Parameters.AddWithValue("@VeszelyesE", szorny.VeszelyesE);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
        
}
