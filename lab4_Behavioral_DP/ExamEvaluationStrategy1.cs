using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_Behavioral_DP
{
    public class ExamEvaluationStrategy1 : IExamEvaluationStrategy
    {
        public double Evaluate(List<double> grades)
        {
            double sum = 0;
            foreach (var grade in grades)
            {
                sum += grade;
            }
            return sum / grades.Count;
        }

        public double Evaluate(List<int> grades)
        {
            double result = 0;

            // Implementarea logicii pentru evaluarea examenului
            foreach (int grade in grades)
            {
                result += grade;
            }

            result /= grades.Count;
            result = Math.Round(result, 2);

            if (result < 5)
            {
                Console.WriteLine("Studentul a picat examenul.");
            }
            else if (result >= 5 && result < 7)
            {
                Console.WriteLine("Studentul a luat un 5 sau un 6.");
            }
            else if (result >= 7 && result < 8.5)
            {
                Console.WriteLine("Studentul a luat un 7 sau un 8.");
            }
            else if (result >= 8.5 && result < 9.5)
            {
                Console.WriteLine("Studentul a luat un 8.5 sau un 9.");
            }
            else
            {
                Console.WriteLine("Studentul a luat un 10.");
            }

            return result;
        }

    }

}
