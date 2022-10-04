// S1.11 Составить программу вывода на экран «столбиком» четырех любых чисел

Random rnd = new Random();
int a = rnd.Next(0,255);
int b = rnd.Next(0,255);
int c = rnd.Next(0,255);
int d = rnd.Next(0,255);
Console.WriteLine($"{a}\n{b}\n{c}\n{d}");