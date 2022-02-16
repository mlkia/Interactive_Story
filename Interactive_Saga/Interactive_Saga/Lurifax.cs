using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Saga
{
    public class Lurifax : Character
    {
        public Lurifax()
        {
            Name = "Lurifax";
            var questions = new List<CharacterQuestion>
            {
                new CharacterQuestion ("hej hej"),
                new CharacterQuestion ("hej hej"),
            };
        }
    }
}
