// Задание 1
while (true)
{
    Console.Write("Введите выражение (или exit): ");
    string input = Console.ReadLine();

    if (input == "exit")
    {
        Console.WriteLine("Программа завершена");
        break;
    }

    string[] parts = input.Split(' ');
    double a = double.Parse(parts[0]);
    string op = parts[1];
    double b = double.Parse(parts[2]);

    double result = 0;

    if (op == "+") result = Add(a, b);
    else if (op == "-") result = Subtract(a, b);
    else if (op == "*") result = Multiply(a, b);
    else if (op == "/") result = Divide(a, b);

    Console.WriteLine("Результат: " + result);
}
    

    static double Add(double a, double b)
{
    return a + b;
}

static double Subtract(double a, double b)
{
    return a - b;
}

static double Multiply(double a, double b)
{
    return a * b;
}

static double Divide(double a, double b)
{
    return a / b;
}

// Задание 2
var phone = new Phone { Model = "Samsung Galaxy" };

phone.Charge(30);
Console.WriteLine($"Заряд: {phone.Battery}%");

phone.Use(10);
Console.WriteLine($"Заряд: {phone.Battery}%");

class Phone()
{
    public string Model { get; set; }
    public int Battery { get; set; }

    public void Charge(int amount)
    {
        if (amount > 0)
        {
            Battery += amount;
        }
    }

    public void Use(int amount)
    {
        if (amount > 0)
        {
            Battery -= amount;
        }
    }
}
