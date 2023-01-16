//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
  /*Console.Write("Введите число A: ");
  int numA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numB = Convert.ToInt32(Console.ReadLine());
  int sum = GetNum(numA, numB);
  Console.WriteLine("Ответ: " + sum);*/




//-------------метод-------------

/*int GetNum (int numA, int numB){
    int result = 1;
    for(int i = 1; i <= numB; i++){
        result = result * numA; 
    }
    return result;  
}*/
  

 
  //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
int sumNumber = GetNum(numA);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);*/



//----------метод----------

/*int GetNum(int numA){
    
    int counter = Convert.ToString(numA).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numA - numA % 10;
      result = result + (numA - advance);
      numA = numA / 10;
    }
   return result;
  }*/



//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)


/*int[] num = nums(8);
Console.WriteLine($"[{String.Join(",",num)}]");


//---------метод------------
int[] nums(int size){
  int[] nums = new int[size];
  for(int i = 0; i < size; i++){
    nums[i] = new Random().Next(100);
  }
  return nums;
}*/
