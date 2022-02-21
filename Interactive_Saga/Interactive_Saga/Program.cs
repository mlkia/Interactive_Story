<<<<<<< HEAD
﻿// See https://aka.ms/new-console-template for more information
using Interactive_Saga;

MessageHelper messageHelper = new(); // instansiera menyn
messageHelper.WelcomeMessage(); //anropar metod för välkomstmeddelande

MainMenu menu = new(); // instansiera menyn
menu.RunMenu(/*user, universe*/); //anropa menyn
=======
﻿using System;

namespace Interactive_Saga.Program
{
    class Program // klassen där universe och karaktär är sammankopplade med varandra 
        // det bllir en lista med alla universes, som utgår ifrån en Universe vilket gör att arvet inte behövs
    {
        public static void Main()
        {
            var universes = new List<Universe>() { CreateUniverseOne(), CreateUniverseTwo(), CreateUniverseThree() };

            var currentUniverse = CreateUniverseOne();

            var isCorrectAnswer = currentUniverse.Character.AskQuestion();

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
            var questions = new List<QuestionAlina>()
            {
                new QuestionAlina(
                    text: "Vilka är mest aktiva i skogen?",
                    answers: new List<string>
                    {
                        "Mössen",
                        "Grodorna",
                        "Träna"
                    },
                    correctAnswerIndex: 3
                ),
                new Question(
                    )
            };


            var lurifax = new CharacterAlina("Lurifax", questions);
            return new Universe("Riddle", 1, lurifax);
        }

        private static Universe CreateUniverseTwo()
        {
            var matematikProfessor = new CharacterAlina("Matematikprofessor", new List<QuestionAlina>);
            return new Universe("Matematikuppgifter", 2, matematikProfessor);
        }

        private static Universe CreateUniverseThree()
        {
            var sportKommentator = new CharacterAlina("Sportkommmentator", new List<QuestionAlina>);
            return new Universe("Sportfrågor", 3, sportKommentator);
        }
    }
}
>>>>>>> alina-implement-universe
