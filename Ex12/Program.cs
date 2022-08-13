Console.Write("Введите первое число: ");
int num1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 =Convert.ToInt32(Console.ReadLine());
int rem = num1 % num2;
if (rem == 0) Console.Write("Кратно");
else Console.Write("Некратно, остаток: "+ rem);
