string[] addArray()
{

  Console.Write($"Введи кол-во элементов массива:\t");
  int elmCount = int.Parse(Console.ReadLine());
  string[] myArray = new string[elmCount];
  for (int i = 0; i < myArray.Length; i++)
  {
    Console.WriteLine($" \n Введи значение для {i}-го элемента массива: ");
    myArray[i] = Console.ReadLine();
  }
  return myArray;
}

// 2. Вывод на экран массива, созданного юзером
void printBaseArray(string[] myArray)
{
  Console.WriteLine($" \n Массив, созданный юзером: ");

  Console.Write($"[");
  for (int i = 0; i < myArray.Length; i++)
  {
    Console.Write($" {myArray[i],1} ");
  }
  Console.Write($"] \n");

  Console.WriteLine(" \n ============== ");
}


