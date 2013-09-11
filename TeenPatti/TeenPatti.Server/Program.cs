using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeenPatti.Model;

namespace TeenPatti.Server
{
    public class Program
    {
        public static void Main()
        {
            var tables = new List<Table>()
                {
                    new Table(VariationType.Classic, 10, 10, 1000, 3,"table1")
                };
            tables.ForEach(t=>t.InitGameplay());
        }
    }
}