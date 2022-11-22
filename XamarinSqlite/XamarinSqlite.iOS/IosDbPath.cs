using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Foundation;
using UIKit;
using Xamarin.Forms;
using XamarinSqlite.iOS;
using XamarinSqlite.Services;

[assembly: Dependency(typeof(IosDbPath))]
namespace XamarinSqlite.iOS
{
    public class IosDbPath : IPath
    {
        public string GetDbPath(string filename)
        {
            return Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments),
                "..", "Library", filename);
        }
    }
}
