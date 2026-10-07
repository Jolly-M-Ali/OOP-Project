using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    internal class PracticalExam:Exam
    {
        public override void ShowExam()
        {
            foreach (Question question in Questions)
            {
                Console.WriteLine(question.BodyQuestion);

                foreach (Answer answer in question.AnswerList)
                {
                    Console.WriteLine(
                        $"{answer.AnswerId}: {answer.AnswerText}");
                }

                Console.Write("Your answer ID: ");
                Console.ReadLine();
            }

            Console.WriteLine("\nCorrect Answers:");

            foreach (Question question in Questions)
            {
                Console.WriteLine(question.BodyQuestion);
                Console.WriteLine(question.RightAnswer.AnswerText);
            }
        }

    }
    }

