using System;

class Ejtriangulo_invertido{
	static void Main(){
		int anchura = 0, x = 0;
		int ok = 1;
		int cont;
		
		do{
			try{
				ok = 1;
				
				Console.WriteLine("Dime el ancho (impar y mayor a 3)");
				anchura = Convert.ToInt32(Console.ReadLine());
				
				if (anchura < 3 || anchura % 2 == 0){
					throw new Exception ("Tienes que escribir un número par mayor a 3");
				}
			}
			catch (Exception e){
				Console.WriteLine(e.Message);
				ok = 0;
			}
		}while (ok == 0);
		
		cont = anchura;
			
		while (cont > 0){
		    for (x = cont + 1; x < anchura + 6; x+=2){
				Console.Write(" ");
			}
			for (x = cont - 2; x > 0; x-=2){
				Console.Write("*");
			}
			Console.Write("*");
			for (x = cont - 2; x > 0; x-=2){
				Console.Write("*");
			}
			Console.WriteLine();
			cont-=2;
		}
	}
}
