using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Saga
{
    public class Question
    {
        public Question(string text, List<string> answers, int correctAnswerIndex) // konstruktör för fråga
        {
            Text = text;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        public string Text { get; }
        public List<string> Answers { get; }

        private int CorrectAnswerIndex { get; }

        public bool IsCorrectAnswer(int answerIndex)
               => answerIndex == CorrectAnswerIndex;
               
    }
}
