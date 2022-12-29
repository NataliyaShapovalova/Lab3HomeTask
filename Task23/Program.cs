// принимает на вход число N  и выдает таблицу кубов
Console.Clear();
Console.Write("Введите число для выведения таблицы кубов:");
int a=Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= a; i++)
{
    Console.Write(i +"^"+"3 = "+" "+ Math.Pow(i,3));    
}