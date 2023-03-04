using System;

Func<int, int, int> getRandomNumber = delegate(int x, int y) {
  Random rand = new Random();
  return rand.Next(x, y);
};

int i = getRandomNumber(50, 55);
Console.WriteLine(i);

Func<int, int, int> newRandom = (int x, int y) => new Random().Next(x, y);

int result2 = newRandom(5, 10);
Console.WriteLine(result2);


Func<int, int, int> Summary = (int a, int b) => a + b;

Console.WriteLine(Summary(i, result2));

Console.ReadKey();
Console.Clear();

