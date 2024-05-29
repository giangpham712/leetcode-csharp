// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var numbers = Enumerable.Range(0, 10);

var calculateds = numbers
    .ToAsyncEnumerable()
    .SelectAwait(async number => await DoCalculation(number))
    .ToEnumerable();

var results = calculateds.ToList();

async Task<int> DoCalculation(int number)
{
    Console.WriteLine($"Doing calculation for {number}");
    await Task.Delay(1000);
    return number * number;
}