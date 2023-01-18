namespace Russian_Nesting_Dolls
{
  internal class Doll
  {
    // Properties
    public string Size { get; set; }
    public Doll Child { get; set; }

    // Constructor
    public Doll(string size, Doll child)
    {
      this.Size = size;
      this.Child = child;
    }

    public Doll Open()
    {
      return this.Child;
    }
  }
}
