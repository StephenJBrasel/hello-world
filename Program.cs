using System;

/// <summary>
/// This is a simple Hello World! program. 
/// </summary>
public class Class1
{
	public void Main(string[] args)
	{
        Console.WriteLine("Hello World!");
        
        Console.SetCursorPosition(0, Console.WindowHeight - 1);
        Console.Write("Press ENTER to continue... ");
        Console.ReadLine();
        Console.Clear();
	}
}
