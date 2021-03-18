using System;
using System.Collections.Generic;

namespace StudentGradeBook
{
    public class Student : ICloneable
    {

        public Student(string name, List<int> score)
        {
            this.StudentName = name;
            this.StudentScore = score;
        }

        public Student(string name)
        {
            this.StudentName = name;
        }

        public Student(List<int> score)
        {
            this.StudentScore = score;
        }

        public Student() { }

        public string StudentName { get; set; }

        public List<int> StudentScore { get; set; }

        public Student DeepCopy()
        {
            Student cloneStudent = new Student();
            cloneStudent = (Student)this.MemberwiseClone();
            cloneStudent.StudentName = String.Copy(this.StudentName);
            cloneStudent.StudentScore = new List<int>(this.StudentScore);
            return cloneStudent;
        }

        public Object Clone()
        {
            return (Student)this.MemberwiseClone();
        }

    public override string ToString()
        {
            string student;
            string displayscrs = "";
            if (this.StudentScore.Count > 0)
            {
                foreach (var s in this.StudentScore)
                {
                    displayscrs += "|" + s;
                }
                student = StudentName + displayscrs;
            }
            else
            {
                student = StudentName;
            }
            return student;
        }
    }
}
