using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_Behavioral_DP
{
    public class Exam
    {
        private readonly List<Student> students = new List<Student>();

        public Exam(string v1, DateTime dateTime, string v2)
        {
            V1 = v1;
            DateTime = dateTime;
            V2 = v2;
        }

        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string V1 { get; }
        public DateTime DateTime { get; }
        public string V2 { get; }

        public void Subscribe(Student student)
        {
            students.Add(student);
        }

        public void Unsubscribe(Student student)
        {
            students.Remove(student);
        }

        public void NotifyStudents(string message)
        {
            foreach (var student in students)
            {
                student.ReceiveNotification($"{Subject} la data de {Date} la locatia {Location}: {message}");
            }
        }

        internal void ChangeDateTime(DateTime dateTime)
        {
            
        }

        internal void ChangeLocation(string v)
        {
            
        }

        internal void Register(Student student1)
        {
            
        }
    }

}
