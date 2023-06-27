namespace Visual_Studio_Code;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Title = ("Fretboard Randomizer");
        string[] notes = {"A", "A#/Bb", "B", "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab"};
        Console.ForegroundColor = ConsoleColor.White;
        NewProblem:
        Random numbergenerator = new Random();
        int num01 = numbergenerator.Next(0,12);

        Console.WriteLine(notes[num01]);
        Console.ReadKey();
        goto NewProblem;
    }
}