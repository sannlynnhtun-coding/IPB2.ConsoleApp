using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPB2.ConsoleApp
{
    public class Test
    {
        /// <summary>
        /// Name will be Star + Name
        /// </summary>
        /// <param name="name"></param>
        public void GetName(string name = "Myo Lin")
        {
            Console.WriteLine($"Star {name}");
        }
    }
}
