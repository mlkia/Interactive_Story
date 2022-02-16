using Interactive_Saga;

public class MainMenu
{
    /// <summary>
    /// The message helper instance
    /// </summary>
    MessageHelper messageHelper = new();

    /// <summary>
    /// Runs the menu.
    /// </summary>
    public void RunMenu(/* User user, Universe universe*/)
    {
        while (/* user.WinOverBoss < 3 */ true) // så länge man inte hunnit vinna över alla 3 bossar
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
                    break;

                case 2:
                    Console.Clear();
                    // kör show stats-metoden
                    break;

                case 3:
                    Console.Clear();
                    messageHelper.RulesOfGame();
                    break;

                case 4:
                    // user.WinOverBoss = 3;
                    break;

                default:
                    messageHelper.MenuErrorMessage();
                    Console.ReadKey();
                    break;
            }
        }
    }
}