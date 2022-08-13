int num = new Random().Next(10, 100);
Console.WriteLine(num);
int n1 = num / 10;
int n2 = num % 10;
int max = 0;
if (n1 > n2)
{
    max = n1;
    Console.WriteLine("Max = " + max);
}
if (n2 > n1) 
{
    max = n2;
    Console.WriteLine("Max = " + max);
}
if (n1 == n2)
{
    Console.WriteLine("цифры равны");
}

