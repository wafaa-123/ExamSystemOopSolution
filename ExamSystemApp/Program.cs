using ExamSystemLibrary.Exams;
using ExamSystemLibrary.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Subject Name: ");
        string name = Console.ReadLine();
        Subject subject = new Subject(1, name);

        Console.WriteLine("Choose Exam Type (1 - Final, 2 - Practical): ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Enter Exam Time (minutes): ");
        int time = int.Parse(Console.ReadLine());

        Console.Write("Enter Number of Questions: ");
        int num = int.Parse(Console.ReadLine());

        Exam exam = type == 1
            ? new FinalExam(time, num)
            : new PracticalExam(time, num);

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine($"\nQuestion {i + 1}:");
            Console.Write("Enter Header: ");
            string header = Console.ReadLine();
            Console.Write("Enter Body: ");
            string body = Console.ReadLine();
            Console.Write("Enter Mark: ");
            double mark = double.Parse(Console.ReadLine());

            Question q;
            if (type == 1)
            {
                Console.Write("Choose Question Type (1 - T/F, 2 - MCQ): ");
                int qType = int.Parse(Console.ReadLine());
                q = qType == 1
                    ? new TFQuestion(header, body, mark)
                    : new MCQQuestion(header, body, mark);
            }
            else
            {
                q = new MCQQuestion(header, body, mark);
            }

            q.Answers = new Answer[3];
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter Answer {j + 1}: ");
                string ans = Console.ReadLine();
                q.Answers[j] = new Answer(j + 1, ans);
            }

            Console.Write("Enter Correct Answer ID (1-3): ");
            int correctId = int.Parse(Console.ReadLine());
            q.CorrectAnswer = q.Answers[correctId - 1];

            exam.Questions.Add(q);
        }

        subject.CreateExam(exam);
        Console.WriteLine($"\n{subject}");
        subject.SubjectExam.ShowExam();
    }
}
