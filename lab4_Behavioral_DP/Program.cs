using System;
using System.Collections.Generic;


using lab4_Behavioral_DP;

     class Program
{
    static void Main(string[] args)
    {
        // Crearea unui examen
        Exam exam = new Exam("C# Programming Exam", DateTime.Parse("2023-06-01 10:00"), "Aula Magna");

        // Crearea studenților
        Student student1 = new Student("John", "Doe", "jd123");
        Student student2 = new Student("Jane", "Doe", "jd456");

        // Înregistrarea studenților la examen
        exam.Register(student1);
        exam.Register(student2);

        // Notificarea studenților despre schimbările examenului
        exam.ChangeDateTime(DateTime.Parse("2023-06-02 14:00"));
        exam.ChangeLocation("Sala 101");

        // Evaluarea examenului folosind două strategii de evaluare diferite
        List<int> grades1 = new List<int> { 8, 9, 7, 8, 10, 9 };
        IExamEvaluationStrategy evaluationStrategy1 = new ExamEvaluationStrategy1();
        double result1 = evaluationStrategy1.Evaluate(grades1);
        Console.WriteLine($"Media examenului (strategia 1): {result1}");

        List<int> grades2 = new List<int> { 7, 6, 9, 8, 5, 7 };
        IExamEvaluationStrategy evaluationStrategy2 = new ExamEvaluationStrategy2();
        double result2 = evaluationStrategy2.Evaluate(grades2);
        Console.WriteLine($"Media examenului (strategia 2): {result2}");
    }
}

