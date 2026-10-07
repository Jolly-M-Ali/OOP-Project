using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    internal class FinalExam:Exam
    {
        public override void ShowExam()
        {
            int grade = 0;

            foreach (Question question in Questions)
            {
                Console.WriteLine(question.BodyQuestion);

                foreach (Answer answer in question.AnswerList)
                {
                    Console.WriteLine(
                        $"{answer.AnswerId}: {answer.AnswerText}");
                }

                Console.Write("Your answer ID: ");
                string studentAnswer = Console.ReadLine();
                int input = Convert.ToInt32(studentAnswer);
                //int.TryParse(studentAnswer, out int studentAnswerId);
                //int studentAnswer = int.Parse(Console.ReadLine());
                if (input == question.RightAnswer.AnswerId)
                {
                    grade += question.Mark;
                }
            }

            Console.WriteLine($"Your Grade: {grade}");

        }
    }
}
