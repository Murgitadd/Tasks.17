using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Exam> exams = new List<Exam>();

        exams.Add(new Exam("Math", 3.5));
        exams.Add(new Exam("History", 1.5));
        exams.Add(new Exam("Science", 2.0));
        exams.Add(new Exam("Programming", 4.0));
        
        //??? week hissesini anlamadım... :(

        var longExams = exams.Where(exam => exam.ExamDuration > 2.0);
        Console.WriteLine("2 hrs+ exams:");
        foreach (var exam in longExams)
        {
           Console.WriteLine(exam.Subject + exam.ExamDuration);
        }
        Console.WriteLine();


        var currentExams = exams.Where(exam => exam.StartDate <= DateTime.Now && exam.EndDate >= DateTime.Now);
        Console.WriteLine("Exams currently:");
        foreach (var exam in currentExams)
        {
            Console.WriteLine(exam.Subject + exam.ExamDuration);
        }
        Console.ReadLine();
    }
}
