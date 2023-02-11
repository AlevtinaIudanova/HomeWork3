/*Найти кубы чисел от 1 до N*/

Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"{i} \t {i * i * i} ");
}
