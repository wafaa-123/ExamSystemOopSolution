using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystemLibrary.Exams
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions)
            : base(time, numberOfQuestions) { }

        public override void ShowExam()
        {
            double totalMark = 0;
            Console.WriteLine("=== Final Exam ===");
            foreach (var q in Questions)
            {
                q.Display();
                Console.Write("Your Answer: ");
                var ans = Console.ReadLine();
                if (q.Answers.FirstOrDefault(a => a.AnswerText == ans || a.AnswerId.ToString() == ans) == q.CorrectAnswer)
                {
                    totalMark += q.Mark;
                }
            }
            Console.WriteLine($"Your Grade: {totalMark} / {Questions.Sum(q => q.Mark)}");
        }
    }

}
