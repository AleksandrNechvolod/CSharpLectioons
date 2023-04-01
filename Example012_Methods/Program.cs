// Вид 1 void-ничего не принимает на вход, ничего не возврадает в консоль!!!
void Method1()
{
  Console.WriteLine("Автор...");
}
// // Method1(); // Правильный вызов метода!!!











// Вид 2 void-принимает аргументы на вход, но ничего не возвращает в консоль!!!
// void Method2(string msg)
// {
//   Console.WriteLine(msg);
// }
// // //Method2("Текст сообщения");
// /// запись этого же метода с именованными аргументами(входящих аргументов больше одного.
void Method21(string msg, int count)
{
  int i = 0;
  while (i < count)
  {
    Console.WriteLine(msg);
    i++;
  }
}
// Method21("Текст", 4);// Вывод с аргументами!
// Method21(count:4, msg:"новый текст"); ///вариант вывода с назначенными именованными аргументами!!!







// // Вид 3 метод назначается той переменной, которую будет использовать, например int и, 
// не получая в себя никаких данных, выводит какие-то данные.
// int Method3()
// {
//   return DateTime.Now.Year;
// }

// // int year = Method3(); // кладет в переменноую результат работы метода
// // Console.WriteLine(year); // выводит в консоль саму переменную и ее значение










// // Вид 4 
// // string Method4(int count, string text)
// // {
// //   int i = 0;
// //   string result = String.Empty; //пустая строка
// // Вариант решения с циклом while
// //   while (i < count)
// //   {
// //     result = result + text;
// //     i++;
// //   }
// //   return result;
// // }

// string Method4(int count, string text)
// {
//   string result = String.Empty; //пустая строка
//   for (int i = 0; i < count; i++)   //  Вариант решения с циклом for. ин.счетж; пров усл; инкремент увел счетчика  
//   {
//     result = result + text;
//   }
//   return result;
// }
// // string res = Method4(10, "z");
// // Console.WriteLine(res);



// for (int i = 2; i <= 10; i++)
// {
//   for (int j = 2; j <= 10; j++)
//   {
//     Console.WriteLine($"{i}*{j} = {i * j}");
//   }
//   Console.WriteLine();
// }


// ====== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Венценгороде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";


// string s = "gwerty"
//             012...
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
  string result = string.Empty;

  int length = text.Length;
  for (int i = 0; i < length; i++)
  {
    if (text[i] == oldValue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
  }
  return result;
}
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
  int count = array.Length;
  for (int i = 0; i < count; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

void SelectionSort(int[] array)
{
  for (int i = 0; i < array.Length - 1; i++)
  {
    int minPosition = i;

    for (int j = i + 1; j < array.Length; j++)
    {
      if (array[j] < array[minPosition]) minPosition = j;
    }

    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
  }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);