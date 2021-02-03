﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mine
{
    public static class Constants
    {
        //public const string DatabaseFilename = "TodoSQLite.db3";
        public const string DatabaseFilename = "mine.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create te database if it doesn't
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded databse access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }
    }
}
