// See https://aka.ms/new-console-template for more information
Console.Clear();
int [] mass = new int [10];
int col = 0;
for (int i = 0; i < mass.Length; i++) {
    mass[i] = new Random().Next(1,999);
    if (mass[i]%2 == 0) col++; }
    Console.WriteLine(string.Join(",", mass));
    Console.WriteLine("Количество четных чисел : " + col);
