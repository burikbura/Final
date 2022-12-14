# Final
Описание контрольной работы

Блок №1
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
Метод addArray

задаем массив myArray с размерностью, калибровочным юзером ;

перебирая массив, на каждой итерации предполагается вводить в консолидированное значение строки для каждого элемента;

по завершении возвращем полученное значение массива myArray


Блок №2
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
Метод printBaseArray
В данном блоке мы выводим массив заданный пользователем, поместив его в цикл.


Блок №3
{
  string[] addNewArray = new string[myArray.Length];

  Console.Write($"Массив, в котором длинна строк не более 3 символов:\n");

  Console.Write($"[");
  for (int i = 0; i < myArray.Length; i++)
  {

    if (myArray[i].Length <= 3)
    {
      addNewArray[i] = myArray[i];
      Console.Write($" {addNewArray[i],1} ");
    }
  }
  Console.Write($"] \n");

  Console.WriteLine(" \n ============== ");

}
Метод createSecondArr

В данном блоке мы форматируем массив, заданный пользователем.

создаем новый массив createSecondArr, куда будем складывать значения в соответствии с условиями задачи;

с целью обработать каждый массив массивов, запустить цикл для ;

внутри цикла применения условия if, при помощи которого сверяем длинну значения каждого i-го элемента массива createSecondArr с условием жесткости трём;

если условие 'true', тогда используется в новом массиве addNewArray каждое значение, удовлетворившее условие;


Блок №4
string[] firstArray = addArray();
printBaseArray(firstArray);

createSecondArr(firstArray);
В этом блоке вызываются методы, подхватываемые приемом параматер в виде первого массива.
