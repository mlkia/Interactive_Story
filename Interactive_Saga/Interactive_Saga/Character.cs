public class Character:Universe
{
    public string Name { get; set; } = "test person";
    public string HelpPhrase { get; set; }
    List <string> questions = new List <string> ();
    public void CreateList()
    {
        questions.Add("Vad heter Danmarks huvudstad?");
        questions.Add("Hur långt är avstånd i km mellan Jorden och Månen?");
        questions.Add("Var bor påfåglar?");
    }

    public void AskQuestion(List<string> list)
    {
        foreach (var item in questions)
        {
            Random random = new Random();
            int randomisedNumber=random.Next(0, questions.Count);
            Console.WriteLine(questions[randomisedNumber]);
        }
        Console.WriteLine("1.Köpenhamn", "2. Oslo", "3. Berlin");
        int UserAnswer = int.Parse(Console.ReadLine());
        if (UserAnswer == 1)
        {
            GoToCrossNextRoad();
        }
        else 
        {
            GoToPreviousCharacterQuestion();
        }

    }

}



        // TAKE USER INPUT
        // CHECK IF CORRECT ANSWER

        // IF CORRECT ANSWER
        // GO TO NEXT LEVEL

        // IF NEXT LEVEL IS NULL
        // GO TO NEXT UNIVERSE

    
