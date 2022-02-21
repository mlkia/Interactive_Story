using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Saga
{
    public class UniverseOneJosefinTest //: Universe
    {
        // välkomstmeddelande till universumet

        //gå till crossroad 1: be user välja, input med check, om rätt gå till professor 1 och diamant(0-1), om fel starta om crossroad1.

        public void GoToCrossroad()
        {
            Console.WriteLine("Chose right(r) or left(l)");
            string crossroadInput = Console.ReadLine();
            if (crossroadInput != "r" || crossroadInput != "l") 
            {
                Console.WriteLine("Enter r or l please");
                    Console.ReadKey();
                  }


            Random rnd = new Random();
            int random = rnd.Next(0, 1);
            if (random == 0)
            {
                Console.WriteLine("Oh no, you go back to the last crossroad on your adventure...");
            }
            if (random == 1)
            {
                Console.WriteLine("You are wise, good choice!");
            }
        }

        //Gå till professor 1: visa fråga, input med check alternativt visa ledtråd, om rätt gå till crossroad 2 och diamant(0-1), om fel starta om på crossroad1






        // nedan ska flyttas till rätt universum
        Character professor1 = new("Crazy Professor", "Well Hello..!");
        QuestionHelper questionHelper1 = new("Test question", "a) alertnative A b) alertnative B c) alertnative C", "Clue", "Correct Answer");

        Character professor2 = new("Lazy Professor", "Well Hello..!");
        QuestionHelper questionHelper2 = new("Test question", "a) alertnative A b) alertnative B c) alertnative C", "Clue", "Correct Answer");

        Character professor3 = new("Funny Professor", "Well Hello..!");
        QuestionHelper questionHelper3 = new("Test question", "a) alertnative A b) alertnative B c) alertnative C", "Clue", "Correct Answer");

        Character professor4 = new("Happy Professor", "Well Hello..!");
        QuestionHelper questionHelper4 = new("Test question", "a) alertnative A b) alertnative B c) alertnative C", "Clue", "Correct Answer");

        Character professor5 = new("Sad Professor", "Well Hello..!");
        QuestionHelper questionHelper5 = new("Test question", "a) alertnative A b) alertnative B c) alertnative C", "Clue", "Correct Answer");
    }
}
