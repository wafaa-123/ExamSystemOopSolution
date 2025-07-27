using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystemLibrary.Models
{
    public abstract class Question : ICloneable
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }
        public Answer[] Answers { get; set; }
        public Answer CorrectAnswer { get; set; }

        protected Question(string header, string body, double mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public abstract void Display();

        public object Clone() => this.MemberwiseClone();
    }

}
