// See https://aka.ms/new-console-template for more information
int num, reverse = 0;
Console.Write("Enter a Number to Reverse:\t");
num = int.Parse(Console.ReadLine());
while(num != 0)
{
reverse = reverse * 10;
reverse = reverse + num % 10;
num = num / 10;
}
Console.WriteLine($"Reverse Number is {reverse}");
