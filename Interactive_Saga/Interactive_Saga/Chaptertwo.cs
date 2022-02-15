using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SagaÖvning
{
    public class Chaptertwo
    {

        private readonly string StepA = "Hon träfar en rådjur, hon vill prata med honom och fråga honom var gör han här i skogen. ";
        private readonly string StepB = "Hon hittar en bur av äpple, hon undrar om kan ha ett eller flera och äta " +
            "eller går ut och fortsätta med sin promenad.  Vad tror du?";

        public Chaptertwo()
        {

        }

        public Chaptertwo(char Choice)
        {
            string chaptertwo;

            if (Choice == 'A') chaptertwo = StepA;
            else  chaptertwo = StepB;

            Console.WriteLine(chaptertwo);
        }
        

        //public string ChoiceTwo (char thechoice)
        //{
        //    if (thechoice == 'A') return StepA;
        //    else return StepB;
        //}
    }
}
