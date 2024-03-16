using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class CourseManager
    {
        public void Add()
        {
            Course course = new Course();
        }
    }

    //Internal class'lar aynı proje içinde hiçbir referans sıkıntısı olmadan kullanılabiliyorlar.
}
