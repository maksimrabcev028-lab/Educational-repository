// Задание 1

using System.ComponentModel;

int[] ocenki = new int [7] {2,3,4,5,3,4,5};

int doubl = 0;
int five = 0;
int sum = 0;
foreach (int num in ocenki)
{
    sum =sum + num;
    if (num == 5)
        five++;
    if (num == 2)
        doubl++;

}
double crednee = (double)sum / ocenki.Length;
Console.WriteLine($"Средний балл: {crednee}");
Console.WriteLine($"Количество пятёрок: {five}");
Console.WriteLine($"Количество двоек: {doubl}");

// Задание 2

int[] zx = new int[5] {1,2,3,4,5};

foreach (int cc in zx)
{
    Console.WriteLine(cc);
}
for (int i = zx.Length - 1; i >= 0; i--)
{
    Console.WriteLine(zx[i]);
}

// Задание 3

for (int i = 1; i <= 20; i++)
{
    
    if (i % 2 != 0)
    {
        continue; 
    }

    Console.Write(i + " ");
}

// Задание 4

string password= "1234";
int maxAttempts = 3;

for (int attempt = 0; attempt <= maxAttempts; attempt++)
{
    Console.Write("\nВведите пароль: ");
    string input = Console.ReadLine();

    if (input == password)
    {
        Console.WriteLine("Доступ разрешён");
        break;
    }
    else
    {
        Console.WriteLine($"Неверный пароль. Осталось попыток: {maxAttempts - attempt}");
    }
    if (attempt == 3)
    {
        Console.WriteLine("Доступ запрещён");
    }
}