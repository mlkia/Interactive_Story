using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Saga
{
    public class UserJosefinTest
    {
        public string UserName { get; set; } = "";    // anges i välkomstmeddelandet
        public int Diamonds { get; set; } = 0; // startar på 0
        public int Level { get; set; } = 1;   //börjar på 1, slutar på 3(4?)

        //constructor
        public UserJosefinTest(string userName, int diamonds, int level)                   
        {
            this.UserName = userName;
            this.Diamonds = diamonds;
            this.Level = level;
        }

        public void ShowStats(UserJosefinTest user) // visar user stats, får den inte att fungera :(
        {
            Console.WriteLine("Name:     " + user.UserName);
            Console.WriteLine("Diamonds:    " + user.Diamonds);
            Console.WriteLine("Level:      " + user.Level + "/3");
           
        }
    }
}
