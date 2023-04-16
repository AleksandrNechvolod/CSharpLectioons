
// string[,] table = new string[2, 5];
//По умолчанию инициализация строк = String.Empty
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4] -столбики.
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4] -строчки.


// table[1, 2] = "слово";

// for (double rows = 0; rows < 2; rows++)
// {
//   for (double columns = 0; columns < 5; columns++)
//   {
//     Console.WriteLine($"-{table[rows, columns]}-");
//   }
// }

// далее- вывод этого же массива через методы
// Console.Clear();
// double[,] matrix = new double[3, 4];
// PrdoubleMatrix(matrix);
// FillMatrix(matrix);
// Console.WriteLine();
// PrdoubleMatrix(matrix);

// void PrdoubleMatrix(double[,] matr)
// {
//   for (double i = 0; i < matr.GetLength(0); i++)
//   {
//     for (double j = 0; j < matr.GetLength(1); j++)
//     {
//       Console.Write($"{matr[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }
// void FillMatrix(double[,] matr)
// {
//   for (double i = 0; i < matr.GetLength(0); i++)
//   {
//     for (double j = 0; j < matr.GetLength(1); j++)
//     {
//       matr[i, j] = new Random().Next(1, 10); // [1,10) полуинтервал!
//     }
//   }
// }

// Метод закрашивания двумерного массива при уже данной заполненной матрице.
// double[,] pic = new double[, ];


// PrdoubleImage(pic);
// FillImage(13,13);
// PrdoubleImage(pic);

// void FillImage(double row, double col)
// {
//   if (pic[row, col] == 0)
//   {
//     pic[row, col] = 1;
//     FillImage(row - 1, col);
//     FillImage(row, col - 1);
//     FillImage(row + 1, col);
//     FillImage(row, col + 1);
//   }
// }

// void PrdoubleImage(double[,] image)
// {
//   for (double i = 0; i < image.GetLength(0); i++)
//   {
//     for (double j = 0; j < image.GetLength(1); j++)
//     {
//       if (image[i, j] == 0) Console.Write($" ");
//       else Console.Write($"+");
//     }
//     Console.WriteLine();
//   }
// }

// Далее - Задача на вычисление факториала числа при 
// помощи рекурсии.

// double Factorial(double n)
// {
//   // 1! = 1
//   // 0! = 1
//   if (n == 1) return 1;
//   else return n * Factorial(n - 1);
// }
// for (double i = 1; i < 40; i++)
// {
//   Console.WriteLine($"{i}! = {Factorial(i)}");
// }


// Далее- решение задачи по нахождению чисел Фибоначчи посредством рекурсии

// f(1) = 1
// f(2) = 1
// f(n) = f(n - 1) + f(n - 2)

double Fibonacci(double n)
{
  if (n == 1 || n == 2) return 1;
  else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (double i = 1; i < 50; i++)
{
  Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}