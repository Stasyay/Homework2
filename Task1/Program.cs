Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a > 999 || a < 100)
{
    Console.Write("Нужно ввести трехзначное :  ");
    a = Convert.ToInt32(Console.ReadLine());
}
int n = a / 10; 
int m = n % 10; 

Console.WriteLine("Вторая цифра этого числа: " + m);