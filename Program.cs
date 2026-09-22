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