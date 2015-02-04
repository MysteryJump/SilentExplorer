using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilentExplorer.Library.SilentExplorerCore.Data
{
    public class Thread
    {
        public string ThreadName { get; set; }

        public string ThreadDatNumber { get; set; }

        public DateTime ThreadStandTime
        {
            get
            {
                try
                {
                    var dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                    dt.AddHours(9);
                    return dt.AddSeconds(double.Parse(ThreadDatNumber));
                }
                catch
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public int ThreadCount { get; set; }

        public int Index { get; set; }

        public int Speed { get; set; }

        public bool IsReaded { get; set; }

        public async Task<List<Response>> GetThreadReses()
        {
            return new List<Response>();
        }

    }
}
