// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var max = 10;

var total = 0;
for (int i = 0; i < max; i++)
{
    for (int j = i; j < max; j++)
    {
        total++;
    }
}

Console.WriteLine(total);