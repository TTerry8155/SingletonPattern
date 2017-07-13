using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.cs
{
    public sealed class LedgerSingleton
    {
        private static LedgerSingleton _instance = null;
        //Thread-Safefty
        private static readonly Object padlock = new Object();

        LedgerSingleton()
        {

        }

        public static LedgerSingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new LedgerSingleton();
                    }
                    return _instance;
                }
            }
        }
    }
}
