// See https://aka.ms/new-console-template for more information

Console.Clear();
int [] mass = new int [10];
int col = 0;
for (int i = 0; i < mass.Length; i++) {
    mass[i] = new Random().Next(1,101);
    if (90 >= mass[i] && mass[i] >= 20) col++; }
    Console.WriteLine(string.Join(",", mass));
    Console.WriteLine("Количество чисел в диапазоне от 20 до 90 : " + col);