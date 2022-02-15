using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SagaÖvning
{
    internal class HelpMethods
    {
        public char Choose ()
        {
            char choose= ' ';

            Console.WriteLine("Ska du gå med A eller B");
            
            string Thecois = Console.ReadLine().ToUpper();

            _ = char.TryParse(Thecois, out choose);

            return choose;

        }


    }
}
