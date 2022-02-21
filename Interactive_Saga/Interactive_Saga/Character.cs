using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Saga
{
    public abstract class Character
    {
       public string Name { get; set; }
        public List<CharacterQuestion> questions { get; set; }

        //Josefin kod
     
    
        public string Name { get; set; } // karaktärens namn
        public string HelloPhrase { get; set; }  // hälsningsfras, inte nödvändigt men roligt

        //public string CongratulationsPhrase { get; set; }                  // extra properties vi kan lägga till
        //public string IncorrectAnswerPhrase { get; set; }
        //public string GoodbyePhrase { get; set; }

        public Character(string name, string helloPhrase)  // constructor
        {
            this.Name = name;
            this.HelloPhrase = helloPhrase;
        }
    }
    
}
