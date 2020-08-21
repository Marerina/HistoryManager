using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryManager
{
    public class Character
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Info { get; set; }
        public string Biography { get; set; }
        public string Ability { get; set; }
        public string Group { get; set; }
    }

    public struct Field
    {
        public string Name { get; set; }
        public string Vaue { get; set; }
    }
}
