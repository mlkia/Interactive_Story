using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Saga    // behövde skapa en ny characterklass för att kunna exprimentera med hur vi ställer frågor osv / Josefin
{
    public class Character
    {
        public string Name { get; set; }
        public string HelloPhrase { get; set; }

        //public string CongratulationsPhrase { get; set; }
        //public string IncorrectAnswerPhrase { get; set; }
        //public string GoodbyePhrase { get; set; }

        public Character(string name, string helloPhrase)
        {
            this.Name = name;
            this.HelloPhrase = helloPhrase;
        }
    }
}
