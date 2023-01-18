using Russian_Nesting_Dolls;

// Dolls
var smallest = new Doll("smallest", null);
var smaller = new Doll("smaller", smallest);
var small = new Doll("small", smaller);
var large = new Doll("large", small);
var larger = new Doll("larger", large);
var largest = new Doll("largest", larger);

static void OpenDolls(Doll doll)
{
  var child = doll.Open();

  if (child == null)
  {
    Console.WriteLine($"Cannot open {doll.Size}");
  }
  else
  {
    Console.WriteLine($"Opened {doll.Size}");
    OpenDolls(child);
  }
}

OpenDolls(largest);
