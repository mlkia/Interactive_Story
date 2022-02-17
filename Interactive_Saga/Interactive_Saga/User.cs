using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Saga
{
    public  class User
    {
        public string Name{ get; set; } 
        public int Diamonds { get; set; }
        public int Level { get; set; }  

        //public void ShowStats() 



        List<string> unswers = new List<string>();
        public void CreateList()
        {
            unswers.Add("1");
            unswers.Add("2");
            unswers.Add("3");
        }

    }
}
