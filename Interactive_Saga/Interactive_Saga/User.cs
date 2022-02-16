using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Saga
{
    public class User
    {
        public string UserName { get; set; }
        public int Diamonds { get; set; } = 0;
        public int NumberOfCorrectAnswers { get; set; } = 0;
        public int NumberOfWrongAnswers { get; set; } = 0;
        public int Level { get; set; }= 1;

    }
}
