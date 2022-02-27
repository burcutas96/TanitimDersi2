﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaceApp
{
    public class MysqlDatabaseManager : IDatabase
    {
        private string value, userName = "mysql", password = "admin", mark = new string('-', 6);
        public void addValue(string value)
        {
            this.value = value;
        }

        public void close()
        {
            Console.WriteLine("{0}\n-> Mysql veritabanı bağlantınız başarılı bir şekilde sonlandırıldı.\n{1}", mark, mark);
        }

        public void deleteValue()
        {
            this.value = null;
            Console.WriteLine("{0}\n-> Veri tabanı üzerinde tutmuş olduğum verileri başarılı bir şekilde sildim.\n{1}", mark, mark);
        }

        public void getValue()
        {
            if (value != null)
                Console.WriteLine("{0}\n-> İsteğiniz doğrultuda hafızamdaki [{1}] verisini başarılı bir şekilde " +
                    "getirdim.\n{2}", mark, value, mark);
            else
                Console.WriteLine("{0}\n-> Veri tabanı içerisinde henüz bir veri bulunmuyor. Lütfen daha sonra tekrar " +
                    "deneyin.\n{1}", mark, mark);
        }

        public int Login(string Username, string password)
        {
            if (Username == userName && password == this.password)
                return 1;
            else
                return 0;
        }
    }
}
