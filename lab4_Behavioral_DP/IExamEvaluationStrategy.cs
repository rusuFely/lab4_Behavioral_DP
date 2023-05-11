using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_Behavioral_DP
{
    public interface IExamEvaluationStrategy
    {
        double Evaluate(List<double> grades);
        double Evaluate(List<int> grades1);
    }

}
