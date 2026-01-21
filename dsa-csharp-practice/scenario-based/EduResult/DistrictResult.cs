using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.EduResults
{
    internal class DistrictResult
    {
        public string DistrictName;
        public Student[] Students;
        public DistrictResult(string name, Student[] students)
        {
            DistrictName = name;
            Students = students;
        }
    }
}
