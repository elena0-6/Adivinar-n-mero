// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenido a adivinar el número");
Console.WriteLine("Las reglas son las siguientes:");
Console.WriteLine("-Debes adivinar un número del 1 al 15");
Console.WriteLine("-Tienes 3 intentos");
var generadorAleatorio= new Random();
int numeroParaAdivinar = generadorAleatorio.Next(1, 15);
int i=0;
while(i<3){
	string linea = Console.ReadLine();
	int entrada = Int32.Parse(linea);

	if (entrada == numeroParaAdivinar) {
		Console.WriteLine("Lo has acertado");
		break;
		
	}	
	else{
		if (entrada > numeroParaAdivinar) {
		Console.WriteLine("Estas por encima");
		}
		else{
		Console.WriteLine("Estas por debajo");
		}
	}
	i++;
	if (i==3){
		Console.WriteLine($"Has perdido, el número a adivinar era {numeroParaAdivinar}");
	}
}
		if (entrada > 15)
			Console.WriteLine ("Este número no es válido");
