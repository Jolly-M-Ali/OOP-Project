namespace OOP_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            subject.SubjectId = 1;
            subject.SubjectName = "C#";

            subject.SubjectExam = new FinalExam
            {
                ExamSubject = subject,
                ExamTime = TimeSpan.FromMinutes(60),
                NumberOfQuestions = 2
            };
        }
    }
}
