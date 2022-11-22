using Android.App;
using Android.Content;

using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XamarinSqlite.Droid;
using XamarinSqlite.Services;

[assembly: Dependency(typeof(AndroidDbPath))]
namespace XamarinSqlite.Droid
{
    public class AndroidDbPath : IPath
    {
        public string GetDbPath(string filename)
        {
            return Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.Personal),
                filename);
        }
    }
}