// Мороженое
Console.WriteLine("Введите целое, положительное число: ");
int k = Convert.ToInt32(Console.ReadLine());

while (k < 0)
{
    Console.Write("Неправильно, попробуйте еще раз:  ");
    k = Convert.ToInt32(Console.ReadLine());
}

if (k % 3 == 0 || k % 5 ==0 || k % 8 ==0)
Console.WriteLine("yes");
else
Console.WriteLine("No");

