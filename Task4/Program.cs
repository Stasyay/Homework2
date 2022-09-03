// Лесенка 

Console.Write("Введите цифру от 1 до 9: ");
int a = Convert.ToInt32(Console.ReadLine());

while (a > 9 || a < 1)
{
    Console.Write("Неправильно, попробуйте еще раз:  ");
    a = Convert.ToInt32(Console.ReadLine());
}

for (int i = 1; i <= a; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);      
    }  
  Console.WriteLine("");
}