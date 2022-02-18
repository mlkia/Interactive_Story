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

        public QuestionHelper()  // skapad av VS, borde inte behövas....?
        {
        }

        //QuestionHelper questionHelper = new();

        // UserJosefinTest user = new();


        //public void CheckAnswer(UserJosefinTest user, QuestionHelper questionHelper)          // funkar inte för mig :(
        //{
        //    Console.Clear();
        //    Console.WriteLine(questionHelper.Question);
        //    Console.WriteLine(questionHelper.Alternatives);
        //    Console.WriteLine("Answer by pressing a, b or c!");
        //    string userAnswer = Console.ReadLine();

        //    if (userAnswer == questionHelper.CorrectAnswer)
        //    {
        //        Console.WriteLine("Correct!");
        //        RandomDiamond(user);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Wrong answer! You now go back to the last question...");
        //    }
        //}

        public void GiveClue(QuestionHelper questionHelper, UserJosefinTest user)
        {
            Console.Clear();
            Console.WriteLine("Here is your clue...");
            Console.WriteLine(questionHelper.Clue);
            //questionHelper.CheckAnswer(user);                                      // checkanswer funkar inte
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
                user.Diamonds++;
                Console.WriteLine("You got i diamond! You now have " + user.Diamonds + " diamonds!");
            }
        }

        public void AskQuestion(QuestionHelper questionHelper, Character character, UserJosefinTest user)
        {
            Console.WriteLine(character.HelloPhrase);
            Console.WriteLine(questionHelper.Question);
            Console.WriteLine(questionHelper.Alternatives);
            Console.WriteLine("Are you ready to answer(press 1) or do you want to buy a clue for 1 diamonds(press 2)?");
            string userInput = Console.ReadLine();
            int inputInt = 0;
            int.TryParse(userInput, out inputInt);

            if(inputInt == 1)
            {
                //questionHelper.CheckAnswer(user);                                           // checkanswer funkar inte
                Console.WriteLine("ska kolla om du svarat rätt");
            }
            else if(inputInt == 2)
            {
                // questionHelper.GiveClue(user);
                Console.WriteLine("ska ge ledtråd");
            }
            else
            {
                Console.WriteLine("Enter 1 or 2 please!");
            }

        }

 

       
    }
}
