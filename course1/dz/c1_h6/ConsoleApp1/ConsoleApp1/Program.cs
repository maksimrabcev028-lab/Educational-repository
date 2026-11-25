// Задание 3
var p1 = new Player("Alex", 5);
var p2 = new Player("Alex", 5);
var p3 = p1;
Console.WriteLine(p1 == p2);
Console.WriteLine(p1 == p3);
Console.WriteLine(p1.Equals(p2));

// Задание 4
User user = new User { Login = "admin" };
user.Password = "12345";
Console.WriteLine(user.CheckPassword("12345"));
user.Password = "";
// Задание 5
var p33 = new Point(2, 3);
var p44 = p33;

p33.Move(5, 5);

p44.Print();

public class Player
{
    public string Name;
    public int Level;

    public Player(string name, int level)
    {
        Name = name;
        Level = level;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Name}, уровень {Level}");
    }

    public override bool Equals(object? obj)
    {
        if (obj is Player other)
            return this.Name == other.Name && this.Level == other.Level;
        return false;
    }
}

// Задание 4
public class User
{
    public string Login { get; set; }

    private string password;

    public string Password
    {
        get => password;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                password = value;
                Console.WriteLine("Пароль обновлён");
            }
            else
            {
                Console.WriteLine("Ошибка: пароль не может быть пустым");
            }
        }
    }

    public bool CheckPassword(string input)
    {
        return password == input;
    }
}

// Задание 5
public class Point
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Move(int dx, int dy)
    {
        X += dx;
        Y += dy;
    }

    public void Print()
    {
        Console.WriteLine($"({X}, {Y})");
    }
}



