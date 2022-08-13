Console.Write("Введите первое число: ");
int num1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 =Convert.ToInt32(Console.ReadLine());
if (num1*num1== num2) Console.Write("ДА");
else
{
   if (num2*num2 ==num1) Console.Write("ДА");
   else Console.Write("НЕТ");
}
