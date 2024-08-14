using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOdev16
{
    internal class BaseKisi
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public void Information()
        {
            Console.WriteLine($"İsim: {Name}\nSoyisim: {LastName}");
        }
    }
}
