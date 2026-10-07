using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    internal class Question
    {
        public string HeaderQuestion { get; set; }
        public string BodyQuestion { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }

    }
}
