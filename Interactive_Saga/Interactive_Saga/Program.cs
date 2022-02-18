using System;

namespace Interactive_Saga.Program
{
    class Program // klassen där universe och karaktär är sammankopplade med varandra 
        // det bllir en lista med alla universes, som utgår ifrån en Universe vilket gör att arvet inte behövs
    {
        public static void Main()
        {
            var universes = new List<Universe>() { CreateUniverseOne(), CreateUniverseTwo(), CreateUniverseThree() };


            //public void CreateList()
            {
                //questions.Add("Vilka är mest aktiva i skogen?"); // träna 
                //questions.Add("Vad gör tandläkare på lunchen?"); // käkar
                //questions.Add("I vilken stad kör bilarna fortast?");// Gaza
               // questions.Add("Var läger myrorna sina ägg? ");// i Ant - värpen
               // questions.Add("Det viktigaste när du köper fotbollsskor är ...");// att de passar 
            }
        }

        private static Universe CreateUniverseOne()
        {
            var lurifax = new Character("Lurifax", new List<Question>);
            return new Universe("Riddle", 1, lurifax);
        }

        private static Universe CreateUniverseTwo()
        {
            var matematikProfessor = new Character("Matematikprofessor", new List<Question>);
            return new Universe("Matematikuppgifter", 2, matematikProfessor);
        }

        private static Universe CreateUniverseThree()
        {
            var sportKommentator = new Character("Sportkommmentator", new List<Question>);
            return new Universe("Sportfrågor", 3, sportKommentator);
        }
    }
}