﻿using MoneyTransfer;

Guy jacek = new Guy() { Cash = 50, Name = "Jacek" };
Guy bartek = new Guy() { Cash = 100, Name = "Bartek" };

while (true)
{
    jacek.WriteMyInfo();
    bartek.WriteMyInfo();

    Console.Write("Podaj kwotę: ");
    string howMuch = Console.ReadLine();
    if (howMuch == "") return;
    if (int.TryParse(howMuch, out int amount))
    {
        Console.Write("Pieniądze ma przekazać: ");
        string whichGuy = Console.ReadLine();
        if (whichGuy == "Jacek")
        {
            jacek.GiveCash(amount);
            bartek.RecieveCash(amount);
        }
        else if (whichGuy == "Bartek")
        {
            bartek.GiveCash(amount);
            jacek.RecieveCash(amount);
        }
        else
        {
            Console.WriteLine("Wpisz 'Jacek', lub 'Bartek'");
        }
    
    }
    else
    {
        Console.WriteLine("Wpisz kwotę (lub pusty wiersz, aby zakończyć).");
    }
}