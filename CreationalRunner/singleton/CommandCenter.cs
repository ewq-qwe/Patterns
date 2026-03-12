using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalRunner.singleton
{
    internal class CommandCenter
    {
        private static volatile CommandCenter _instance = null;
        private CommandCenter()
        { }
        public static CommandCenter GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CommandCenter();
            }
            return _instance;
        }
        public string GetCommander()
        {
            return "Адмірал Філпс";
        }
    }
}
