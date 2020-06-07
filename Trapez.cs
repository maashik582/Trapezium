using System; 
public class HelloWorld { 
	public static void Main(String[] args) 
	{	int num = 3; 
		int space; 
		int i, j, lterm, rterm; 
		lterm = 1; 
		rterm = num * num + 1; 
		for (i = num; i > 0; i--) { 
			for (space = num; space > i; space--) 
				Console.Write(" "); 
			for (j = 1; j <= i; j++) { 
				Console.Write(lterm); 
				Console.Write("*"); 
				lterm++; 
			} 
			for (j = 1; j <= i; j++) { 
				Console.Write(rterm); 
				if (j < i) 
					Console.Write("*"); 
				rterm++; 
			} 
			rterm = rterm - (i - 1) * 2 - 1; 
			Console.WriteLine(); 
		} 
	} 
} 

