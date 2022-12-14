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

