// See https://aka.ms/new-console-template for more information

namespace SagaÖvning {
using System;

public static class Program
{
    static void Main()
    {
            var TheChoice = new HelpMethods();

            var chapterOne = new ChapterOne();

            var chapterTwo = new Chaptertwo(TheChoice.Choose());

            var chapterThree = new ChapterThree(TheChoice.Choose());
        }
}
}
