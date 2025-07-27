using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystemLibrary.Exams
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions)
            : base(time, numberOfQuestions) { }

        public override void ShowExam()
        {
            Console.WriteLine("=== Practical Exam ===");
            foreach (var q in Questions)
            {
                q.Display();
                Console.Write("Your Answer: ");
                Console.ReadLine(); // Ignore user input for now
                Console.WriteLine($"Correct Answer: {q.CorrectAnswer.AnswerText}");
            }
        }
    }

}
