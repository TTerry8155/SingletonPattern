using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.cs
{
    public sealed class LedgerSingleton
    {
        private static LedgerSingleton _instance = null;
        //Thread-Safefty
        private static readonly object padlock = new object();

        LedgerSingleton()
        {

        }

        public static LedgerSingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (Instance == null)
                    {
                        _instance = new LedgerSingleton();
                    }
                    return _instance;
                }
            }
        }
    }
}
