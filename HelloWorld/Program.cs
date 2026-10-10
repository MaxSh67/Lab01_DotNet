// // // // // // // Console.WriteLine("Привет от ИСП-242!");
// // // // // // // Console.WriteLine("Автор: Шаранов Максим");
// // // // // // // Console.WriteLine("Год: 2026");
// // // // // // int age = 20;
// // // // // // double gpa = 4.5;
// // // // // // bool isStudent = true;
// // // // // // string name = "Иван";
// // // // // // Console.WriteLine(name);
// // // // // // Console.WriteLine(age);
// // // // // // Console.WriteLine(gpa);
// // // // // // Console.WriteLine(isStudent);

// // // // // // var city = "Москва";
// // // // // // var year = 2026;          
// // // // // // var pi = 3.14159;        
// // // // // // var isActive = true;
// // // // // // Console.WriteLine(city);
// // // // // // Console.WriteLine(year);
// // // // // // Console.WriteLine(pi);
// // // // // // Console.WriteLine(isActive);

// // // // // // string myName = "Максим";
// // // // // // int myAge = 18;
// // // // // // string myGroup = "ИСП-242";
// // // // // // Console.WriteLine($"Меня зовут {myName}, мне {myAge} лет, я учусь в группе {myGroup}.");

// // // // // // Console.WriteLine("Введите ваш возраст: ");
// // // // // // string input = Console.ReadLine();
// // // // // // int age2 = int.Parse(input);
// // // // // // Console.WriteLine($"Через 10 лет вам будет {age2 + 10} лет.");

// // // // // // int x = 10;
// // // // // // int y = 3;
// // // // // // Console.WriteLine(x + y);
// // // // // // Console.WriteLine(x - y);
// // // // // // Console.WriteLine(x * y);
// // // // // // Console.WriteLine(x / y);
// // // // // // Console.WriteLine(x % y);

// // // // // string firstName = "Максим";
// // // // // string lastName = "Шаранов";
// // // // // string group = "ИСП-242";
// // // // // int birthYear = 2008;
// // // // // double gpa = 4.7;
// // // // // bool hasScholarship = true;

// // // // // int currentYear = 2026;
// // // // // int age = currentYear - birthYear;

// // // // // Console.WriteLine("Студенческое удостоверение");
// // // // // Console.WriteLine($"Имя: {firstName} {lastName}");
// // // // // Console.WriteLine($"Группа: {group}");
// // // // // Console.WriteLine($"Возраст: {age} лет");
// // // // // Console.WriteLine($"Средний балл: {gpa}");
// // // // // Console.WriteLine($"Стипендия: {hasScholarship}");

// // // // // Console.Write("\nВведите ваш любимый предмет: ");
// // // // // string subject = Console.ReadLine();
// // // // // Console.WriteLine($"Отлично! {firstName} любит {subject}.");

// // // // // int a = 15;
// // // // // int b = 4;
// // // // // Console.WriteLine($"Сумма: {a + b}");
// // // // // Console.WriteLine($"Разность: {a - b}");
// // // // // Console.WriteLine($"Произведение: {a * b}");
// // // // // Console.WriteLine($"Частное (int): {a / b}");
// // // // // Console.WriteLine($"Остаток: {a % b}");
// // // // // double result = (double)a / b;
// // // // // Console.WriteLine($"Частное (double): {result}");

// // // // // Console.WriteLine(Math.Abs(-5));
// // // // // Console.WriteLine(Math.Pow(2, 10));
// // // // // Console.WriteLine(Math.Sqrt(144));
// // // // // Console.WriteLine(Math.Max(10, 25));
// // // // // Console.WriteLine(Math.Min(10, 25));
// // // // // Console.WriteLine(Math.Round(3.567, 2));

// // // Console.WriteLine("Калькулятор");
// // // Console.WriteLine("Введите первое число: ");
// // // double num1 = double.Parse(Console.ReadLine());
// // // Console.WriteLine("Введите второе число: ");
// // // double num2 = double.Parse(Console.ReadLine());
// // // Console.WriteLine($"Сумма: {num1 + num2}");
// // // Console.WriteLine($"Разность: {num1 - num2}");
// // // Console.WriteLine($"Произведение: {num1 * num2}");
// // // if (num2 != 0)
// // //     Console.WriteLine($"Частное: {num1 / num2}");
// // // else
// // //     Console.WriteLine("Деление на ноль невозможно!");

// // // Console.WriteLine(int.MaxValue);
// // // Console.WriteLine(int.MinValue);
// // // Console.WriteLine(double.MaxValue);
// // // Console.WriteLine(double.MinValue);

// // int metr1 = 1;
// // System.Int32 metr2 = 1;

// Console.WriteLine("Добро пожаловать в анкету!");
// Console.WriteLine("Введите ваше имя: ");
// string name = Console.ReadLine();
// Console.WriteLine("Введите вашу фамилию: ");
// string surname = Console.ReadLine();
// Console.WriteLine("Введите вашу группу: ");
// string group = Console.ReadLine();
// Console.WriteLine("Введите ваш год рождения: ");
// int birthYear = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите ваш средний балл (например, 4.5): ");
// double gpa = double.Parse(Console.ReadLine());
// int currentYear = 2026;
// int age = currentYear - birthYear;
// bool isExcellent = gpa >= 4.5;
// string status = isExcellent ? "Отличник" : "Хорошист";
// Console.WriteLine("Ваша анкета");
// Console.WriteLine($"Имя:          {name} {surname}");
// Console.WriteLine($"Группа:       {group}");
// Console.WriteLine($"Возраст:      {age} лет");
// Console.WriteLine($"Средний балл: {gpa}");
// Console.WriteLine($"Статус:       {status}");
// Console.WriteLine($"Лет до 30:    {30 - age}");
// Console.WriteLine("Нажмите Enter для выхода...");
// Console.ReadLine();

//Задание 1
// string game = "DeadByDaylight";
// int number = 7;
// double pi = 3.14;
// char bukva = 'М';
// Console.WriteLine($"Любимая игра: {game}");
// Console.WriteLine($"Любимая цифра: {number}");
// Console.WriteLine($"Число пи: {pi}");
// Console.WriteLine($"Любимая буква: {bukva}");

// Задание 2
// Console.WriteLine("I");
// Console.WriteLine("need");
// Console.WriteLine("more");
// Console.WriteLine("power!");

// Задание 3
// Console.WriteLine("\"Hello There\"");

//Задание 4
// Console.WriteLine("Введите стоимость монитора: ");
// int monitor = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите стоимость системного блока: ");
// int blok = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите стоимость клавиатуры: ");
// int klava = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите стоимость мыши: ");
// int mouse = int.Parse(Console.ReadLine());
// int x = monitor + blok + klava + mouse;
// int total = x * 3;
// Console.WriteLine($"Стоимость покупки: {total}");

// Задание 5
// Console.WriteLine("Введите a: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите b: ");
// int b = int.Parse(Console.ReadLine());
// double x = 3 * Math.Pow(a + b, 3) + 275 * Math.Pow(b, 2) - 127 * a - 41;
// Console.WriteLine($"Значение функции: {x}");

// Задание 6
Console.WriteLine("Введите температуру в градусах Цельсия: ");
double c = double.Parse(Console.ReadLine());
double f = c * 9 / 5 + 32;
Console.WriteLine($"Температура: {f}°F");