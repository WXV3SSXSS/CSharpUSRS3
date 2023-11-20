// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] massiv = new int[10]
{
	1, 2, 3, 4, 5, 6, 7, 8, 9, 10
};

Console.WriteLine("количество чётных " + massiv.Count(x => x % 2 == 0));
Console.WriteLine("количество нечётных " + massiv.Count(x => x % 2 == 1));