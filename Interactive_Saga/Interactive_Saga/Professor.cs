using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Saga
{
    public class Professor : Character
    {
        // constructor med namn och metoder

        public Professor(string name, string helloPhrase) : base(name, helloPhrase) // constructor gjord av VS
        {
        }

        // nedan ska flyttas till rätt universum
        Professor professor = new("Crazy Professor", "Well Hello..!");


        QuestionHelper questionHelper1 = new("Test question", "a) alertnative A b) alertnative B c) alertnative C", "Clue", "Correct Answer");

        QuestionHelper questionHelper2 = new("Test question", "a) alertnative A b) alertnative B c) alertnative C", "Clue", "Correct Answer");

        QuestionHelper questionHelper3 = new("Test question", "a) alertnative A b) alertnative B c) alertnative C", "Clue", "Correct Answer");

        QuestionHelper questionHelper4 = new("Test question", "a) alertnative A b) alertnative B c) alertnative C", "Clue", "Correct Answer");

        QuestionHelper questionHelper5 = new("Test question", "a) alertnative A b) alertnative B c) alertnative C", "Clue", "Correct Answer");
    }
}
