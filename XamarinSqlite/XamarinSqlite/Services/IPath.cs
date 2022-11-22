using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinSqlite.Services
{
    public interface IPath
    {
        string GetDbPath(string filename);
    }
}
