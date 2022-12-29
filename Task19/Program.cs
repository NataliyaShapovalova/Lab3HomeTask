// палиндром
System.Console.WriteLine("Введите пятизначное число");
int number =Convert.ToInt32(Console.ReadLine());

    if (number.ToString().ToLower()==(new string(number.ToString().ToLower().Reverse().ToArray())))
    {
      Console.Write($"{number} -Палиндром"); 
    }

else
{
    Console.Write("Не палиндром");
}