// See https://aka.ms/new-console-template for more information
using Interactive_Saga;

UserJosefinTest user = new("testnamn från program.cs", 0, 1);

MessageHelper messageHelper = new(); // instansiera menyn
messageHelper.WelcomeMessage(user); //anropar metod för välkomstmeddelande

MainMenu menu = new(); // instansiera menyn
menu.RunMenu(); //anropa menyn

//skapa instans av universumen......