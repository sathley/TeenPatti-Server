using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeenPatti.Model
{
    public class Table
    {
        public long Id { get; set; }

        public int Capacity { get; set; }

        public long BootSize { get; set; }

        public VariationType Variation { get; set; }

        public long MinimumBankRequired { get; set; }

        public int MinimumPlayersRequired { get; set; }

        public List<Player> Players { get; set; }
    }

    public static class TableProvider
    {
        public static List<Table> Get()
        {
            return new List<Table>()
                {

                };
        }
    }


    
}
