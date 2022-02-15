// Set up Console UI (CUI)
Console.Title = "My Rocking App";
ConsoleColor defFore = Console.ForegroundColor;
ConsoleColor defBack = Console.BackgroundColor;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("*************************************");
Console.WriteLine("***** Welcome to My Rocking App *****");
Console.WriteLine("*************************************");
Console.ForegroundColor = defFore;
Console.BackgroundColor = defBack;
