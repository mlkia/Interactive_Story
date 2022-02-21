// See https://aka.ms/new-console-template for more information

MessageHelper messageHelper = new(); // instansiera menyn
messageHelper.WelcomeMessage(user); //anropar metod för välkomstmeddelande

MainMenu menu = new(); // instansiera menyn
menu.RunMenu(user); //anropa menyn

