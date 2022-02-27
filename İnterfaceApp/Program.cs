using System;

namespace İnterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string mark = new string('-', 6);
            int value;
            DatabaseManager database;

            Console.WriteLine("{0}\n< C# Interface Örnekleri >\n{1}", mark, mark);
            Console.WriteLine("[1] - Oracle Database Bağlantısı Kur\n[2] - Mysql Database Bağlantısı Kur\n{0}", mark);
            Console.Write("-> Kararınız: ");
            value = Convert.ToInt32(Console.ReadLine());

            switch (value)
            {
                case 1:
                    database = new DatabaseManager(new OracleDatabaseManager());
                    database.LoginDB();
                    break;
                case 2:
                    database = new DatabaseManager(new MysqlDatabaseManager());
                    database.LoginDB();
                    break;
                default:
                    Console.WriteLine(mark);
                    break;


            }
        }
    }
}
