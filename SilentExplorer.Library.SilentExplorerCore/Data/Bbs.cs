using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilentExplorer.Library.SilentExplorerCore.Data
{
    public class Bbs
    {
        public async Task<List<Thread>> GetThreadList()
        {
            return new List<Thread>();
        }

        public static Bbs Load(string uri)
        {
            throw new NotImplementedException();
        }

        private Bbs()
        {

        }

        public string Name { get; set; }

        public string Url { get; set; }

        public Dictionary<string, string> SettingTxtDictionary { get; set; } 
    }
}
