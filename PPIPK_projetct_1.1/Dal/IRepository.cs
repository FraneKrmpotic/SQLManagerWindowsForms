using PPIPK_projetct_1._1.Models;
using System.Collections.Generic;
using System.Data;

namespace PPIPK_projetct_1._1.Dal
{
    interface IRepository
    {
        DataSet CreateDataSet(string text);
        IEnumerable<Database> GetDatabases();
        void LogIn(string server, string username, string password);
    }
}