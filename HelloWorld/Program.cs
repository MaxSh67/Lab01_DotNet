// // Console.WriteLine("Привет от ИСП-242!");
// // Console.WriteLine("Автор: Шаранов Максим");
// // Console.WriteLine("Год: 2026");
// int age = 20;
// double gpa = 4.5;
// bool isStudent = true;
// string name = "Иван";
// Console.WriteLine(name);
// Console.WriteLine(age);
// Console.WriteLine(gpa);
// Console.WriteLine(isStudent);

// var city = "Москва";
// var year = 2026;          
// var pi = 3.14159;        
// var isActive = true;
// Console.WriteLine(city);
// Console.WriteLine(year);
// Console.WriteLine(pi);
// Console.WriteLine(isActive);

// string myName = "Максим";
// int myAge = 18;
// string myGroup = "ИСП-242";
// Console.WriteLine($"Меня зовут {myName}, мне {myAge} лет, я учусь в группе {myGroup}.");

// Console.WriteLine("Введите ваш возраст: ");
// string input = Console.ReadLine();
// int age2 = int.Parse(input);
// Console.WriteLine($"Через 10 лет вам будет {age2 + 10} лет.");

// int x = 10;
// int y = 3;
// Console.WriteLine(x + y);
// Console.WriteLine(x - y);
// Console.WriteLine(x * y);
// Console.WriteLine(x / y);
// Console.WriteLine(x % y);

string firstName = "Максим";
string lastName = "Шаранов";
string group = "ИСП-242";
int birthYear = 2008;
double gpa = 4.7;
bool hasScholarship = true;

int currentYear = 2026;
int age = currentYear - birthYear;

Console.WriteLine("Студенческое удостоверение");
Console.WriteLine($"Имя: {firstName} {lastName}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine($"Средний балл: {gpa}");
Console.WriteLine($"Стипендия: {hasScholarship}");

Console.Write("\nВведите ваш любимый предмет: ");
string subject = Console.ReadLine();
Console.WriteLine($"Отлично! {firstName} любит {subject}.");