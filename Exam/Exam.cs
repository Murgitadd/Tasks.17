using System;

class Exam
{
    public string Subject { get; set; }
    public double ExamDuration { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public Exam(string subject, double examDuration)
    {
        Subject = subject;
        ExamDuration = examDuration;
        StartDate = DateTime.Now;
//        EndDate = StartDate + examDuration; Error
    }
}
