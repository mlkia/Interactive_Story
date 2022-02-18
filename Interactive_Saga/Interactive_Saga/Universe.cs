using System;
public class Universe // basen för universe 
{
    public Universe(string name, int level, Character character)
    {
        Name = name;
        Level = level;
        Character = character;
    }

    public string Name { get; }
    public int Level { get; }
    public Character Character { get; }
}







