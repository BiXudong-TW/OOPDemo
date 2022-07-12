using System.Collections.Generic;

namespace OOPDemo.Class_Diagram.Association
{
    public class AssociationDemo
    {
        public class School
        {
            //one to many
            private List<Student> Students;

            public List<Student> GetStudents()
            {
                return Students;
            }
        }

        public class Student
        {
            //something
        }
    }
}