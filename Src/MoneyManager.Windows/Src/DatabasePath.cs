﻿using Windows.Storage;
using MoneyManager.Foundation.Interfaces;

namespace MoneyManager.Windows
{
    /// <summary>
    ///     Provides the platform specific database path
    /// </summary>
    public class DatabasePath : IDatabasePath
    {
        /// <summary>
        ///     Provides the platform specific database path
        /// </summary>
        public string DbPath => ApplicationData.Current.LocalFolder.Path;
    }
}