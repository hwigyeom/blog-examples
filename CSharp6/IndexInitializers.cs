using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    class IndexInitializers
    {
        public void Test()
        {
            var myDictionary = new Dictionary<string, string>
            {
                { "Name", "Noh Hwigyeom" },
                { "Country", "Republic of Korea" },
                { "City", "Seoul" },
                { "Gender", "Male" }
            };

            myDictionary = new Dictionary<string, string>
            {
                ["Name"] = "Noh Hwigyeom",
                ["Country"] = "Republic of Korea",
                ["City"] = "Seoul",
                ["Gender"] = "Male"
            };

            var list = new List<int>
            {
                [2] = 3
            };
        }
    }
}
