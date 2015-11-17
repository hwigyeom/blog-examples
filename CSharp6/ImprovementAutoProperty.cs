using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    class ImprovementAutoProperty
    {
        public string Key { get; } = Guid.NewGuid().ToString("N");
        public string Subject { get; set; } = "TODO:";
        public bool IsComplete { get; set; }
        public DateTime? Updated { get; private set; } = DateTime.Now;
    }
}
