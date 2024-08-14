using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOdev16
{
    internal class Teacher: BaseKisi
    {
        public int Salary {  get; set; }

        public void TeacherInformation()
        {
            Information();
            Console.WriteLine($"Maaşınız: {Salary}");
        }
    }
}
