using Microsoft.Data.Sqlite;
using lampsite.Models;

namespace lampsite.DbData;

public class LampDataContext
{
    public string DbPath { get; }

    public LampDataContext()
    {
        string location = typeof(LampDataContext).Assembly.Location;
        string folder = new FileInfo(location).Directory.FullName;
        DbPath = Path.Join(folder, "LampData.db");
     
        if (CreateDatabaseIfNotExists())
        {
            AddLamp(new Lamp(){ Naam="Led1"});
            AddLamp(new Lamp(){ Naam="Led2"});
            AddLamp(new Lamp(){ Naam="Led3"});
        }
    }

    private bool CreateDatabaseIfNotExists()
    {
        if (File.Exists(DbPath) == false)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=" + DbPath))
            {
                connection.Open();

                SqliteCommand command = connection.CreateCommand();
                command.CommandText =
                @"
                    CREATE TABLE Lamp(
                        id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        Naam TEXT NOT NULL,
                        Aan INTEGER NOT NULL
                    );
                ";
                command.ExecuteNonQuery();
            }
            return true;
        }
        return false;
    }

    public void AddLamp(Lamp item)
    {
        using (SqliteConnection connection = new SqliteConnection("Data Source=" + DbPath))
        {
            connection.Open();

            SqliteCommand command = connection.CreateCommand();
            command.CommandText =
            @"  
                INSERT  INTO Lamp (Naam,Aan)
                VALUES ( @Naam,@Aan);
            ";

            command.Parameters.Add(new SqliteParameter("@Naam", item.Naam));
            command.Parameters.Add(new SqliteParameter("@Aan", item.Aan));
            int result = command.ExecuteNonQuery();
        }

    }


    public List<Lamp> GetLampen()
    {
        List<Lamp> items = new List<Lamp>();
        using (SqliteConnection connection = new SqliteConnection("Data Source=" + DbPath))
        {
            connection.Open();

            SqliteCommand command = connection.CreateCommand();

            command.CommandText = "SELECT * from Lamp;";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Lamp item = new Lamp()
                    {
                        Id =(long) reader["Id"] ,
                        Naam = reader["Naam"]  as string,
                        Aan =((long)reader["Aan"])==1 ,
                    };
                    items.Add(item);
                }
            }

            return items;
        }
    }
    
}