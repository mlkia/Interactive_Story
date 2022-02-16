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
       public List<Question> questions { get; set; }
    }
    public class Lurifax : Character
    {
        public Lurifax()
        {
            Name = "Lurifax";
        }
    }
}
