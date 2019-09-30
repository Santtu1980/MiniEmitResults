using MTRSerial.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniEmitResults.ValueObjects;

namespace MiniEmitResults.Courses
{
    public class Courses
    {
        public List<ValueObjects.Course> AllCourses { get; set; }
        private bool CheckCourseCorrecetStamps(ValueObjects.Course course, List<int> points)
        {
            {
                //Loop throught courses and checkpoints if stamps match
            }
            return false;
        }
    }

    public static class CourseHelper
    {
        public static Course CreateACourseFromControlPointNumbers(List<int> controlNumbers, int length, string name)
        {
            List<ControlPoint> controls = new List<ControlPoint>();
            var i = 1;
            foreach(var control in controlNumbers)
            {
                controls.Add(new ControlPoint{OrderNumber = i, IdNumber = control, IsInterval = false, BackUpLabelMatrix = Array.Empty<bool>()});
                i++;
            }

            return new Course
            {
                OrderNumber = 0,
                Length_m = length,
                Name = name,
                ControlPoints = controls
            };
        }
        public static void CheckCourses(MTRResponse emitData)
        {

        }

    }
}
