using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_Behavioral_DP
{
    public class ExamEvaluationStrategy2 : IExamEvaluationStrategy
    {
        public double Evaluate(List<double> grades)
        {
            double minGrade = grades.Min();
            double maxGrade = grades.Max();
            double sum = 0;
            foreach (var grade in grades)
            {
                sum += grade;
            }
            return (sum - minGrade - maxGrade) / (grades.Count - 2);
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

            if (result < 6)
            {
                Console.WriteLine("Studentul a picat examenul.");
            }
            else if (result >= 6 && result < 8)
            {
                Console.WriteLine("Studentul a luat un 6 sau un 7.");
            }
            else if (result >= 8 && result < 9.5)
            {
                Console.WriteLine("Studentul a luat un 8 sau un 9.");
            }
            else
            {
                Console.WriteLine("Studentul a luat un 10.");
            }

            return result;
        }

    }
}
