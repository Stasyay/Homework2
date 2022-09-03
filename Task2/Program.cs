Console.Write("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 0) 
a = a*-1;

if (a < 100)
    Console.WriteLine("Третьей цифры нет");
else
{
        while (a >= 1000)
        a = a/10; 
}
 a = a%10;
Console.WriteLine(a);
