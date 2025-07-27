using ExamSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystemLibrary.Exams
{
    public abstract class Exam : IComparable<Exam>
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; }

        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = new List<Question>();
        }

        public abstract void ShowExam();

        public int CompareTo(Exam other)
        {
            return Time.CompareTo(other.Time);
        }

        public override string ToString()
        {
            return $"Exam Duration: {Time} min | Questions Count: {Questions.Count}";
        }
    }

}
