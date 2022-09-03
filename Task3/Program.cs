Console.Write("Введите цифру от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());

while (a > 7 || a < 1)
{
    Console.Write("Надеюсь, что это просто опечатка, попробуйте еще раз:  ");
    a = Convert.ToInt32(Console.ReadLine());
}
if (a == 6 || a == 7)
Console.Write("Этот день выходной");
else
Console.Write("Не время расслабляться");
