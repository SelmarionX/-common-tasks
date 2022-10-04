// S1.7 Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.

Random rnd = new Random();
int a = rnd.Next(0, 10);
int b = rnd.Next(0, 10);
int c = rnd.Next(0, 10);
Console.WriteLine($"{a}  {b}  {c}");