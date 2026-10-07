using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    internal  abstract class Exam
    {
        public TimeSpan ExamTime { get; set; }
        public int NumberOfQuestions { get; set; }
        public Subject ExamSubject { get; set; }
        public abstract void ShowExam();
        public Question[] Questions { get; set; }
    }
}
