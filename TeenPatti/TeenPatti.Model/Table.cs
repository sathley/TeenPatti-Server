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

        public List<long> PlayerIds { get; set; }

        public long BootSize { get; set; }

        public Variation Variation { get; set; }
    }
}
