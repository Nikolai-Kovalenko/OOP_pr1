using System;

namespace pr1
{
     class Program
     {
          static void Main() {
              
                Func<int>[] delegate_array = new Func<int>[] {
                    () => new Random().Next(1, 11),
                    () => new Random().Next(1, 11),
                    () => new Random().Next(1, 11),
                    () => new Random().Next(1, 11),
                    () => new Random().Next(1, 11)
                };

               int avg = Get_array(delegate_array);
               System.Console.WriteLine(avg);
                
           }

          static int Get_array(Func<int>[] delegate_array) {
              int summ = 0;
              int count = delegate_array.Length;

              foreach (var del_ar in delegate_array)
              {
                  summ += del_ar(); 
              }

              return summ / count;
          }
     }
}

