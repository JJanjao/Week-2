using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    class Student
    {
        private string name;
        private int year;
        private Boolean isactive;
        private string studentID;


        public string Name
        {
            get {
                return name;            
            }
            set {
                name = value;
            }
        }

        public int YearOfBirth 
        {
            get
            {
                return year;
            }
            set
            {
                if (value > 2000 || value < 1950) 
                {
                    Console.WriteLine(StudentID + ": error try setting invalid year-of-birth value!");
                }
                else
                {
                    year = YearOfBirth;
                    

                }
               
            }
     
        }

        public string StudentID
        {
            get
            {
                return studentID;
            }
            set
            {
               studentID = value;
            }
        }
        public Boolean isActive 
        {
            get
            {
                return isactive;
            }
            set
            {
                this.isactive = value;
            }
        }

        //constructor
        public Student () 
        {
            name = "John Doe ";
            studentID = "Unknown";
            year = 1995;
            isactive = false;

        }
      
        public Student (string name,string studentID)
        {
            this.name = name;
            this.studentID = studentID;
            year = 1995;
            isactive = true;
        }
        public Student (string name,string studentID,int year)
        {
            this.name = name;
            this.studentID = studentID;
            this.year = year;
            isactive = true;
        }
        public Student (string name,string studentID,int year,Boolean isactive)
        {
            this.name = name;
            this.studentID = studentID;
            this.year = year;
            this.isactive = isactive;
        }

        public int getAge() 
        {
            return DateTime.Now.Year - YearOfBirth;
        
        }

        public override string ToString()
        {
            if (isActive == true)
            {
                return "[Student:" + Name + " (" + StudentID + "), age=" + getAge() + ", is active student]";
            }
            else
            {
                return "[Student:" + Name + " (" + StudentID + "), age=" + getAge() + ", is NOT active student]";
            }
        }

        }
}
