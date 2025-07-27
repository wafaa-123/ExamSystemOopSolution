using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystemLibrary.Models
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, double mark)
            : base(header, body, mark) { }

        public override void Display()
        {
            Console.WriteLine($"[MCQ] {Header}: {Body} ({Mark} Marks)");
            foreach (var answer in Answers)
                Console.WriteLine(answer);
        }
    }

}
