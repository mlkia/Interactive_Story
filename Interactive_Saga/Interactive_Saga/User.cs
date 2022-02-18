namespace Interactive_Saga
{
    public class User
    {
        public string UserName { get; set; } = "";
        public int Diamonds { get; set; } = 0;
        public int NumberOfCorrectAnswers { get; set; } = 0;
        public int NumberOfWrongAnswers { get; set; } = 0;
        public int Level { get; set; } = 1;



        public void ShowStates()
        {
            var TheAnswers = new Character();

            int[] numOfAnswers = new int[2];

            numOfAnswers = TheAnswers.AskQuestion();

            NumberOfCorrectAnswers = numOfAnswers[0];
            NumberOfWrongAnswers = numOfAnswers[1];

            Console.WriteLine("You have " + NumberOfCorrectAnswers + " Right answers");
            Console.WriteLine("You have " + NumberOfWrongAnswers + " Wrong answers");
        }

    }
}
