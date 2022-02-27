using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaceApp
{
    public interface IDatabase
    {
        int Login(string Username, string password);
        void close();
        void addValue(string value);
        void deleteValue();
        void getValue();



    }
}
