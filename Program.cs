using System.Drawing;
using System.Threading.Tasks.Dataflow;

int dayNumber = 6;

switch (dayNumber) {
    case 6 or 7: Console.WriteLine("Выходной"); break;
    default: Console.WriteLine("Будний"); break;
}

int dayNumber = 6;

switch (dayNumber) {
    case 6 or 7 or 5: Console.WriteLine("Выходной"); break;
    default: Console.WriteLine("Будний"); break;
}

int score = 78;

switch (score)
{
    case >= 0 and < 50:
        Console.WriteLine("Неудовлетворительно");
        break;
    case >= 50 and < 70:
        Console.WriteLine("Удовлетворительно");
        break;
    case >= 70 and < 85:
        Console.WriteLine("Хорошо");
        break;
    case >= 85 and <= 100:
        Console.WriteLine("Отлично");
        break;
    default:
        Console.WriteLine("Некорректный балл");
        break;
}

int score = 78;

switch (score)
{
    case >= 0 and < 40:
        Console.WriteLine("Неудовлетворительно");
        break;
    case >= 40 and < 60:
        Console.WriteLine("Удовлетворительно");
        break;
    case >= 60 and < 80:
        Console.WriteLine("Хорошо");
        break;
    case >= 80 and <= 100:
        Console.WriteLine("Отлично");
        break;
    default:
        Console.WriteLine("Некорректный балл");
        break;
}



int score = 78;

string result = score switch {
    >= 85 => "Отлично",
    >= 70 => "Хорошо",
    >= 50 => "Удовлетворительно",
    >= 0 => "Неудовлетворительно",
    _ => "Некорректный балл"
};

Console.WriteLine(result);

int temp = 78;

string result = temp switch
{
    < 0 => "Мороз",
    >= 0 and <= 14 => "Прохладно",
    >= 15 and <= 24 => "Комфортно",
    >= 25 and <= 34 => "Жарко",
    >= 35 => "Очень жарко",
    _ => "Неизвестно"
};

Console.WriteLine(result);

string role = "user";

string result = role switch
{
    "admin" => "Полный доступ",
    not "admin" => "Ограниченный доступ"
};

Console.WriteLine(result);

string role = "user";

string result = role switch
{
    "admin" => "Полный доступ",
    "teacher" => "Доступ преподавателя",
    not "admin" => "Ограниченный доступ"
};

Console.WriteLine(result);


int age = 20;
bool hasTicket = true;

switch (age)
{
    case >= 18 when hasTicket:
        Console.WriteLine("Вход разрешен");
        break;
    case >= 18:
        Console.WriteLine("Нет билета");
        break;
    default:
        Console.WriteLine("Возраст не подходит");
        break;
}


int age = 20;
bool hasTicket = true;

switch (age)
{
    case >= 18 when hasTicket:
        Console.WriteLine("Вход разрешен");
        break;
    case >= 18:
        Console.WriteLine("Нет билета");
        break;
    default:
        Console.WriteLine("Возраст не подходит");
        break;
}


int level = 2;

switch (level)
{
    case 1:
        Console.WriteLine("Начальный уровень");
        break;
    case 2:
        Console.WriteLine("Средний уровень");
        break;
    case 3:
        Console.WriteLine("Продвинутый уровень");
        break;
}

Буничева 4 вариант

string size = "M";
bool isStudent = true;

int price = 0;

switch (Size) {
    case "S":
        price = 150;
        break;
    case "M":
        price = 200;
        break;
    case "L":
        price = 250;
        break;
    default:
        Console.WriteLine("Неизвестный размер");
        break;
}

if (price > 0)
{
    if (isStudent)
    {
        price = price - (price / 10);
    }
    Console.WriteLine(price + "руб.");
}

Буничева 9 вариант

int hour = 14;

switch hour {
    case hour >= 0 and hour <= 5:
        Console.WriteLine("Ночной тариф");
        break;
    case hour >= 6 and hour <= 9:
        Console.WriteLine("Утренний тариф");
        break;
    case hour >= 10 and hour <= 17:
        Console.WriteLine("Дневной тариф");
        break;
    case hour >= 18 and hour <= 23:
        Console.WriteLine("Вечерний тариф");
        break;
    default:
        Console.WriteLine("Некорректное время");
        break;
}

Василенко 2 вариант

Console.Write("Введтте число от 0 до 100: ");

int number = int.Parse(Console.ReadLine());


