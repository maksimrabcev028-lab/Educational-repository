// 1

int number = 10;

if (number > 0)
{ Console.WriteLine("Число положительное"); }
if (number < 0)
{ Console.WriteLine("Число отрицательное"); }
if (number == 0)
{ Console.WriteLine("Число равно нулю"); }

// 2

        Console.Write("Введите ваш возраст: ");

int age = Convert.ToInt32(Console.ReadLine());


if (age >= 18)
        {Console.WriteLine("Вы совершеннолетний"); }
else
        {Console.WriteLine("Вы несовершеннолетний"); }
    

// 3
        
        int num = 7;

       
        if (num % 2 == 0)
        {
            Console.WriteLine("Число чётное");
        }
        else
        {
            Console.WriteLine("Число нечётное");
        }


// 4

int a = 5, b = -2;


if (a > 0 && b > 0)
{
    Console.WriteLine("Оба числа положительные");
}

if (a > 0 || b > 0)
{
    Console.WriteLine("Хотя бы одно число положительное");
}

if (a < 0)
{
    Console.WriteLine("a не положительное");
}

// 5

int grade;

Console.Write("Введите оценку: ");
grade = Convert.ToInt32(Console.ReadLine());


if (grade < 3)
{
    Console.WriteLine("Неудовлетворительно");
}
else if (grade == 3)
{
    Console.WriteLine("Удовлетворительно");
}
else if (grade == 4)
{
    Console.WriteLine("Хорошо");
}
else if (grade == 5)
{
    Console.WriteLine("Отлично");
}
