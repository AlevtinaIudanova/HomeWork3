/*Написать программу вычисления произведения чисел от 1 до N*/

Console.WriteLine("Enter number: ");
int A = int.Parse(Console.ReadLine());

int result = 1;

for (int i = 1; i <= A; i++)
{
    result *= i;
    Console.WriteLine("Факториал \"{0}\" = {1}", i, result);

}
