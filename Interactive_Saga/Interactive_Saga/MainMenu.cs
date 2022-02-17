using Interactive_Saga;

public class MainMenu
{
    /// <summary>
    /// The message helper instance
    /// </summary>
    MessageHelper messageHelper = new();

    UserJosefinTest user = new();

    UniverseOneJosefinTest universeOne = new();


    /// <summary>
    /// Runs the menu.
    /// </summary>
    public void RunMenu(UniverseJosefinTest user)
    {
        while (user.Level < 4) // så länge man inte hunnit vinna över alla 3 bossar
        {
            messageHelper.MainMenuMessage();

            string userMenuInput = Console.ReadLine();

            int menuInputInt = 0;
            int.TryParse(userMenuInput, out menuInputInt);

            switch (menuInputInt)
            {
                case 1:
                    Console.Clear();
                    // kör spel-metoden
                    universeOne.GoToCrossroad();
                    break;

                case 2:
                    Console.Clear();
                    user.ShowStats();
                    break;

                case 3:
                    Console.Clear();
                    messageHelper.RulesOfGame();
                    break;

                case 4:
                    user.Level = 4;
                    break;

                default:
                    messageHelper.MenuErrorMessage();
                    Console.ReadKey();
                    break;
            }
        }
    }
}