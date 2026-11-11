// Задание 1: Конвертер температуры
Console.Write("Введите температуру в градусах Цельсия: ");
double celsia = Convert.ToDouble(Console.ReadLine());

double farenheit = celsia * 9 / 5 + 32;

Console.WriteLine($"Температура в градусах Фаренгейта: {farenheit}");

//Задание 2. Среднее арифметическое трёх чисел
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите третье число: ");
double num3 = Convert.ToDouble(Console.ReadLine());

double crednee = (num1 + num2 + num3) / 3;

Console.WriteLine($"Среднее арифметическое введённых чисел равно: {crednee}");

// Задание 3. Калькулятор
Console.Write("Введите первое число: ");
double q =  Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double w  = Convert.ToDouble(Console.ReadLine());

double sum = q + w;
double raz = q - w;
double proiz = q * w;
double chast = q / w;

Console.WriteLine($"Сумма чисел: {sum}; разность чисел: {raz}; произведение чисел: {proiz}; частное чисел: {chast}");
