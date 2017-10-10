using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomesteadManager.Core.Models;

namespace HomesteadManager.Core {
    public sealed class Storage {
        private static volatile Storage _instance;
        private static readonly object SyncRoot = new object();

        private Storage() { }

        public static Storage Instance {
            get {
                if (_instance == null) {
                    lock (SyncRoot) {
                        if (_instance == null)
                            _instance = new Storage();
                    }
                }

                return _instance;
            }
        }

        public Config Config = null;
    }
}
