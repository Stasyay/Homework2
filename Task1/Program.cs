Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

int n = a / 10; 
int m = n % 10; 

Console.WriteLine("Вторая цифра этого числа - " + m);