using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        //public string ExamSubject { get; set; }
        public Exam SubjectExam { get; set; }
    }
}
