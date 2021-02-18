using System;
using System.Collections.Generic;

namespace lab4
{
    class StudentsCompare : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)  //реалізуємо інтерфейс IComparer
        {
            if (s1.AverageMark > s2.AverageMark)
                return 1;
            else if (s1.AverageMark < s2.AverageMark)
                return -1;
            else
                return 0;
        }
    }
}
