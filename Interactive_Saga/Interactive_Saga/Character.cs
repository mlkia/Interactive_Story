using Interactive_Saga;

public class Character // basklass för karaktär 
{
    public string Name { get; }
    private List<Question> Questions;

    private static Random random = new Random(); // random-funktion skapas i början, så att den inte anropas på nytt varje gång

    public Character(string name, List<Question> questions) // karaktär har med sig lista med frågor 
    {
        Name = name;
        Questions = questions;
    }

    public bool AskQuestion() // frågefunktion har bool, så att anroparen kan bedömma vad som ska ske vid rätt/fel svar 
    {
        var randomQuestion = Questions[random.Next(Questions.Count)];
        Console.WriteLine(randomQuestion.Text);

        for (int i = 0; i < randomQuestion.Answers.Count; i++)
        {
            var answer = randomQuestion.Answers[i];

            Console.WriteLine($"{i + 1}: {answer}"); // frågor och svar börjar från 1 till 3
        }

        int userAnswer = int.Parse(Console.ReadLine()) - 1;

        return randomQuestion.IsCorrectAnswer(userAnswer);
    }

}



       

    
