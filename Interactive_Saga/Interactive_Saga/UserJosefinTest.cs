using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Saga
{
    public class UserJosefinTest
    {
        public string UserName { get; set; } = "";    // kommer från input i välkomstmeddelandet
        public int Diamonds { get; set; } = 0;
        public int Level { get; set; } = 1;   //börjar på 1, slutar på 3(4?)

        public void ShowStats()
        {
            // visa stats
            Console.WriteLine("Name:     " + UserName);
            Console.WriteLine("Diamonds:    " + Diamonds);
            Console.WriteLine("Level:      " + Level + "/3");
           
        }
    }
}
