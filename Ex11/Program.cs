int num = new Random().Next(100, 1000);
int num1= num / 100;
int num3= num % 10;
int nm= num1 * 10 + num3;
Console.WriteLine(num + " -> " + nm);