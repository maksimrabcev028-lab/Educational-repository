// Задание 1
void SayHello()
{
    Console.WriteLine("Привет, мир!");
}
SayHello();
SayHello();
SayHello();
// Задание 2

 void Greet(string name)
{
    Console.WriteLine($"Привет, {name}!");
}
    Greet("Саша");
    Greet("Ярослав");
    Greet("Анна");


// Задание 3
PrintPerson("Егор", 15, "Москва");
PrintPerson("Анна", 22, "Санкт-Петербург");

   
void PrintPerson(string name, int age, string city)
{
    Console.WriteLine($"Имя: {name} Возраст: {age} Город: {city}");
}

// Задание 4
PrintPerso("Алексей");



PrintPerso("Мария", 25, "Рисование");

void PrintPerso(string name, int age = 18, string hobby = "Не указано")
{
    Console.WriteLine($"Имя: {name}");
    Console.WriteLine($"Возраст: {age}");
    Console.WriteLine($"Хобби: {hobby}");
}
// Задание 5

int Square(int x)
{

    Console.WriteLine(x * x);
    return x;
}

Square(4);

