using System;
using System.Collections.Generic;
using System.Text;

namespace BashSoft.Exceptions
{
    class CourseNotFoundException : SystemException
    {
        private const string Not_Enrolled_In_Course = "Student must be enrolled in a course before you set his mark.";

        public CourseNotFoundException()
            : base(Not_Enrolled_In_Course)
        {
        }

        public CourseNotFoundException(string message)
            : base(message)
        {
        }
    }
}
