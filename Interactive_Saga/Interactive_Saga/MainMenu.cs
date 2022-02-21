using Interactive_Saga;

public class MainMenu  
{

    MessageHelper messageHelper = new();

    UserJosefinTest user = new("testnamn från huvudmenyn", 0, 1);

    public void RunMenu(UserJosefinTest user)
    {
        while (user.Level < 4) // så länge man inte hunnit vinna över alla 3 bossar
        {
            messageHelper.MainMenuMessage();  // anropar metoden som visar huvudmenyn

            string userMenuInput = Console.ReadLine(); // ta input från user

            int menuInputInt = 0;
            int.TryParse(userMenuInput, out menuInputInt);

            switch (menuInputInt)   
            {
                case 1: // gå till crossroad i universeOne
                    Console.Clear();
                    //universeOne.GoToCrossroad();
                    break;

                case 2:// visa user stats
                    Console.Clear();
                   // user.ShowStats();                                        // funkar inte.... :(
                    break;

                case 3: // visa spelets regler, anropar textmetod från messagehelper.cs
                    Console.Clear();
                    messageHelper.RulesOfGame();
                    break;

                case 4: // exit game
                    user.Level = 4;
                    break;

                default: // error message från messagehelper.cs
                    messageHelper.MenuErrorMessage();
                    Console.ReadKey();
                    break;
            }
        }
    }
}