static void Countdown(int time)
{
  if (time <= 0)
  {
    Console.WriteLine("Blast off!");
    Console.WriteLine("           ___");
    Console.WriteLine("     |     | |");
    Console.WriteLine("    / \\    | |");
    Console.WriteLine("   |--o|===|-|");
    Console.WriteLine("   |---|   |d|");
    Console.WriteLine("  /     \\  |w|");
    Console.WriteLine(" | N     | |b|");
    Console.WriteLine(" | A     | | |");
    Console.WriteLine(" | S     |=| |");
    Console.WriteLine(" | A     | | |");
    Console.WriteLine(" |_______| |_|");
    Console.WriteLine("  |@| |@|  | |");
    Console.WriteLine("___________|_|_");

    return;
  }

  Console.WriteLine($"{time}...");

  // Wait 1 second
  Thread.Sleep(1000);

  time--;
  Countdown(time);
}

Countdown(10);