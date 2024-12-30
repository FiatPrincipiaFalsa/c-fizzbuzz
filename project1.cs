using System;
public class program
{
	public static void Main()
	{	
		Console.WriteLine("How many numbers shall I count:");
		int x = int.Parse(Console.ReadLine());
		for (int i = 0; i < x + 1; i++ )
		{	
			if ( i % 3 == 0 && i % 5 ==0)
				Console.WriteLine("fizzbuzz");
			else	
				if ( i % 3 == 0)
					Console.WriteLine("fizz");
				else	
					if ( i % 5 == 0)
						Console.WriteLine("buzz");
					else
						Console.WriteLine(i);
		}

	}
}
