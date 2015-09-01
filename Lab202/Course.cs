using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    class Course
    {
        private string name;
        private string courseID;
        private string lecturer;
        private int maxStudents;
        private int numStudents;

        public Course()
        {
            name = "Unknow";
            courseID = "123456";
            numStudents = 0;
            lecturer = "staff";
            maxStudents = 30;
        }
      
        public Course(string name, string courseID)
        {
            this.name = name;
            this.courseID = courseID;
            numStudents = 0;
            lecturer = "staff";
            maxStudents = 30;
        }
        public Course(string name, string courseID, string lecturer)
        {
            this.name = name;
            this.courseID = courseID;
            numStudents = 0;
            this.lecturer = lecturer;
            maxStudents = 30;
        }
        public Course(string name, string courseID, string lecturer, int maxStudent)
        {
            this.name = name;
            this.courseID = courseID;
            numStudents = 0;
            this.lecturer = lecturer;
            this.maxStudents = maxStudents;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string CourseID
        {
            get
            {
                return courseID;
            }
            set
            {
                if (value.Length > 6)
                {
                    Console.WriteLine("{0}: error try setting invalid CourseID!", courseID);
                }
                else
                {
                    int check = 0;
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (char.IsDigit(value[i]))
                        {
                            check++;
                        }
                        else
                        {
                            check = 0;
                        }
                    }
                    if (check != 6)
                    {
                        Console.WriteLine("{0}: error try setting invalid CourseID!", courseID);
                    }
                    else
                    {
                        courseID = value;
                    }

                }
            }
        }
        public string Lecturer
        {
            get
            {
                return lecturer;
            }
            set
            {
                lecturer = value;
            }
        }
        public int MaxStudents
        {
            get
            {
                return maxStudents;
            }
            set
            {
                if (value < numStudents || value > 80 || value < 0)
                {
                    Console.WriteLine("{0}: error try setting invalid Max No. Students!", courseID);

                }
                else
                {
                    maxStudents = value;
                }
               
            }
        }
        public int NumStudents
        {
            get
            {
                return numStudents;
            }
            set
            {
                if(value > maxStudents||value < 0 )
                {
                    Console.WriteLine("{0}: error try setting invalid No. Students!", courseID);                    
                }
                else
                {                
                    numStudents = value;                
                }

            }
        }

        public override string ToString()
        {
            return "[Course: " + Name + " (" + CourseID + "), Lecturer=" + Lecturer + ", has " + NumStudents + " students, max=" + MaxStudents + "]";

        }




    }

}
