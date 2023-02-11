/*Показать кубы чисел, заканчивающихся на четную цифру*/

Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    int temp = i * i * i;
    if (temp % 2 == 0)
    {
        Console.WriteLine($"{i} \t {i * i * i} <==");
    }
    else
    {
        Console.WriteLine("-");
    }
}











