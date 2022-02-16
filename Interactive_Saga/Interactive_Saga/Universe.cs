using System;

public record Universe(string Name, int Diamonds, List<Level> Levels);


//var currentUniverse = universeOne;
// while (true) { currentUniverse = universeTwo; }

//var universeOne = new Universe("Lurifax ", 5, EasyLevels);


public abstract record Character();

/*
var questions = new() { 
    new Question("Hur många tyskar bor det i Göteborg?", new() { "Görmany", "Jättemånga", "Goagubbar" }, 0),
};
var gothenborgian = new Character("Glen", questions);
*/

public record Level(Character Character);


var universeOne = new Universe("Lurifax", 5, new());


//var universes = new List<Universe>() { universeOne, universeTwo, universeThree};
var currentUniverseIndex = 0;

var currentUniverse = universes[currentUniverseIndex];

while (true)
{
    var currentLevelIndex = 0;
    var currentLevel = currentUniverse.Levels[currentLevelIndex];
    while (true)
    {
        Console.WriteLine(currentLevel.Character.Name);
        var question = currentLevel.Character.Questions.Random();

        Console.WriteLine(question.Query);
        foreach (var answer in question.Answers)
        {
            Console.WriteLine(answer);
        }

        // TAKE USER INPUT
        // CHECK IF CORRECT ANSWER

        // IF CORRECT ANSWER
        // GO TO NEXT LEVEL

        // IF NEXT LEVEL IS NULL
        // GO TO NEXT UNIVERSE

    }
}