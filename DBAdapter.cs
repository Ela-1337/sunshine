using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

//Code Schicht für pysischen Zugriff auf das DB Modell
//Ermöglicht bei Bedarf den Austausch des DB Modells zb von SQLite auf MongoDB
//So muss nur der Adapter verändert werden, nicht die DB an sich

namespace Bietigheim_Sunshine
{
    class DBAdapter
    {
        //Constructor
        public DBAdapter()
        {
            Connection = new SQLiteConnection("Data Source=WetterDaten.db");
        }

        //Connection ist ein Objekt aus Microsoft.Data.Sqlite, um Verbindung zur Datenbank aufzubauen
        public SQLiteConnection Connection { get; }
    }
}
