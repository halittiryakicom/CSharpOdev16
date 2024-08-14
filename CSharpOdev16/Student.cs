using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOdev16
{
    internal class Student:BaseKisi
    {
        public string StudentNumber { get; set; }

        public void StudentInformation()
        {
            Information();
            Console.WriteLine($"Öğrenci Numarası: {StudentNumber}");
        }
    }
}
