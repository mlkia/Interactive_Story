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

        public void AskQuestion(Character character, UserJosefinTest user, QuestionHelper questionHelper)
        {
            Console.WriteLine(character.HelloPhrase);
            Console.WriteLine(questionHelper.Question);
            Console.WriteLine(questionHelper.Alternatives);
            Console.WriteLine("Are you ready to answer(press 1) or do you want to buy a clue for 1 diamonds(press 2)?");
            string userInput = Console.ReadLine();
            int inputInt = 0;
            int.TryParse(userInput, out inputInt);

            if(inputInt = 1)
            {
                CheckAnswer(character, userInput, questionHelper);
            }
            else if(inputInt = 2)
            {
                GiveClue();
            }
            else
            {
                Console.WriteLine("Enter 1 or 2 please!");
            }

        }

        public void CheckAnswer()
        {
            Console.Clear();
            Console.WriteLine(questionHelper.Question);
            Console.WriteLine(questionHelper.Alternatives);
            Console.WriteLine("Answer by pressing a, b or c!");
            string userAnswer = Console.ReadLine();

            if (userAnswer == questionHelper.CorrectAnswer)
            {
                Console.WriteLine("Correct!");
                RandomDiamond();
            }
        }

        public void GiveClue(QuestionHelper questionHelper)
        {
            Console.Clear ();
            Console.WriteLine("Here is your clue...");
            Console.WriteLine(questionHelper.Clue);
            CheckAnswer();
        }

        public void RandomDiamond(UserJosefinTest user)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 1);
            if (random == 0)
            {
                Console.WriteLine("No diamonds for you! Better luck next time...");
            }
            if (random == 1)
            {
                user.Diamond++;
                Console.WriteLine("You got i diamond! You now have " + user.Diamond + " diamonds!");
            }
        }
    }
}
