public class UniverseOne : Universe
{
    public string Theme { get; set; } = "Gåtor";
    public int Level { get; set; } = 1;

    Character myCharacter = new Character();
    public void PoseQuestionToUser()
    {
        Console.WriteLine("Crossroadfråga");
        bool correctAnswer = false;
        if (correctAnswer)
        {
            GoToQuestionHelper();
        }
        else GoToCrossRoad();
    }

}



        // TAKE USER INPUT
        // CHECK IF CORRECT ANSWER

        // IF CORRECT ANSWER
        // GO TO NEXT LEVEL

        // IF NEXT LEVEL IS NULL
        // GO TO NEXT UNIVERSE

    
