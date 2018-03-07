using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wuerstelstand_Simulator.Database
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
