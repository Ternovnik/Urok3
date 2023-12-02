// See https://aka.ms/new-console-template for more information
Console.Clear();
double [] mass = new double [10];
double raznisa = 0;
double max = 0 ;
double min = 0 ;  
for (int i = 0; i < mass.Length; i++) 
    mass[i] = new Random().NextDouble();
    max = mass[0];
    min = mass[0];
 for (int i = 0; i < mass.Length; i++) {
    if (mass[i] > max) max = mass[i]; 
    if (mass[i] < min) min = mass[i];
 }    
   Console.WriteLine(string.Join(" ; ", mass));
   Console.WriteLine(); 
      Console.WriteLine(" Разница между максиммальным и минимальным числами: " + (max - min));
