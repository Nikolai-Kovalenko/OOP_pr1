using System;

      void Add(int x, int y) => Console.WriteLine(x + y);

      Add(10, 4);


      void Sub(int x, int y) => Console.WriteLine(x - y);

      Sub(10, 4);

      void Mul(int x, int y) => Console.WriteLine(x * y);

      Mul(10, 4);


      void Div(int x, int y) => Console.WriteLine(y != 0 ?  x / y : "На ноль дельть нельзя!");

      Div(10, 0);
