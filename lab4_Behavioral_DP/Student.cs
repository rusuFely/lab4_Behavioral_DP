using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_Behavioral_DP
{
    public class Student
    {
        public Student(string v1, string v2, string v3)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
        }

        public string Name { get; set; }
        public string V1 { get; }
        public string V2 { get; }
        public string V3 { get; }

        public void Subscribe(Exam exam)
        {
            exam.Subscribe(this);
        }

        public void Unsubscribe(Exam exam)
        {
            exam.Unsubscribe(this);
        }

        public void ReceiveNotification(string message)
        {
            Console.WriteLine($"Notificare pentru studentul {Name}: {message}");
        }
    }

}
