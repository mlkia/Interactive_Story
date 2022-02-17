using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Saga
{
    public class QuestionHelper
    {
       

        public string Question { get; set; }
        public string Alternatives { get; set; }
        public string Clue { get; set; }
        public string CorrectAnswer { get; set; }

        //constructor....
        public QuestionHelper(string question, string alternatives, string clue, string correctAnswer)
        {
            this.Question = question;
            this.Alternatives = alternatives;
            this.Clue = clue; 
            this.CorrectAnswer = correctAnswer;    
        }

        public void AskQuestion()
        {
           
        }

        public void CheckAnswer()
        {

        }

        public void GiveClue()
        {

        }
    }
}
