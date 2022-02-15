using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SagaÖvning
{
    public class ChapterThree
    {
        public string StepA { get; set; } = "Gubben bjöder henne att äta lunch med varndra.";
        public string StepB { get; set; } = "Gubben frågar henne om kan han gå med Lyla på hennes promenad.";

        public ChapterThree()
        {

        }

        public ChapterThree(char Choice)
        {
            string chaptertwo;

            if (Choice == 'A') chaptertwo = StepA;
            else chaptertwo = StepB;

            Console.WriteLine(chaptertwo);
        }
    }
}
