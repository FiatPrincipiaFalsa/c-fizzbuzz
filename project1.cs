using System;
public class program
{
	public static void Main()
	{
		for (int i = 0; i < 201; i++ )
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
