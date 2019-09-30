using MTRSerial.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEmitResults.Courses
{
    public class Courses
    {
        public List<ValueObjects.Course> AllCourses { get; set; }
        private bool CheckCourseCorrecetStamps(ValueObjects.Course course, List<int> points)
        {
            foreach(Dictionary<int,int> point in course.CheckPoints)
            {
                //Loop throught courses and checkpoints if stamps match
            }
            return false;
        }
    }

    public static class CourseHelper
    {
        public static void CheckCourses(MTRResponse emitData)
        {

        }

    }
}
