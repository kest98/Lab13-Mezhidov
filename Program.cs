// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader()
// {
//    Console.WriteLine("^_^");
//    Console.WriteLine("Лабораторная работа №13");
//    Console.WriteLine("0_0");

// }

// void PrintFooter()
// {
//    Console.WriteLine(">_<");
//    Console.WriteLine("   Конец программы");
//    Console.WriteLine("Дата формирования отчета: 10.10.2010");
//    Console.WriteLine("X_X");
// }


// using System.ComponentModel;
// using System.Runtime.InteropServices;

// void PrintStudentCard(string name, int age, string group)
// {
//    Console.WriteLine($"Студент: {name}, возраст: {age}, группа: {group}");

// }
// PrintStudentCard("Егор", 18,"ИСП-251");
// PrintStudentCard("Валерия", 17, "ИСП-252");




// double CalculateScholarship(double baseAmount, double bonusPercent)
// {
//    return baseAmount + baseAmount * bonusPercent / 100;
// }
// bool IsEligibleForBonus(double averageGrade)
// {
//    return averageGrade >= 4.5;
// }
// double result = CalculateScholarship(2000, 15);
// Console.WriteLine(result);
// double studentGrade = 4.0;
// double CalculateScholarship2;

// if (IsEligibleForBonus(studentGrade))
// {
//    CalculateScholarship2 = CalculateScholarship(2000, 20);
//    Console.WriteLine($"С надбавкой: {CalculateScholarship2}");
// }
// else
// {
//    CalculateScholarship2 = CalculateScholarship(2000, 15);
//    Console.WriteLine($"Без надбавки: {CalculateScholarship2}");
// }




// double CalculateAverageGrade(int[] grades)
// {
//    int sum = 0;
//    foreach (int grade in grades)
//    {
//       sum += grade;
//    }
//    return (double)sum / grades.Length;
// }
// int countFives(int[] grades)
// {
//    int count = 0;
//    foreach (int grade in grades)
//    {
//       if (grade == 5)
//       {
//          count++;
//       }

//    }
//    return count;
// }
// int[] grades = { 4, 5, 3, 5, 4 };
// double average = CalculateAverageGrade(grades);
// Console.WriteLine(average);

// int fives = countFives(grades);
// Console.WriteLine(fives);



// class Program
// {
//    static void Main()
//    {
//       Console.WriteLine(Add(2, 3));
//       Console.WriteLine(Add(2.5, 3.5));
//       Console.WriteLine(Add(2, 3, 4));
//    }

//    static int Add(int a, int b)
//    {
//       return a + b;
//    }
//    static double Add(double a, double b)
//    {
//       return a + b;
//    }
//    static int Add(int a, int b, int c)
//    {
//       return a + b + c;
//    }
// }



//Б
// void PrintPerson(string name, int age)
// {
//    Console.WriteLine($"Студент: {name}, возраст: {age}");

// }
// PrintPerson("Евгений", 20);
// PrintPerson("Максим", 19);


//В
// int N = int.Parse(Console.ReadLine());
// if (IsEven(N))
// {
//    Console.WriteLine("Число четное" + N){
//       else
//       {
//          Console.WriteLine("Число нечетное" + N);
//       }
//    }
// }
// bool IsEven(int number)
// {
//    return number % 2 == 0;
// }




// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname))
// {
//    Console.WriteLine("Фамилия не введена. Завершение работы.");
//    return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


//3

bool IsPositive(int number)
{
    return number > 0;
}

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (IsPositive(a))
{
    Console.WriteLine($"{a} положительное.");
}
else
{
    Console.WriteLine($"{a} не  положительное.");
}


//5
// double CalculateBmi(double weight, double heightMeters)
// {
//     return weight / (heightMeters * heightMeters);
// }

// double bmi = CalculateBmi(75.5, 1.75);
// Console.WriteLine($"Индекс массы тела: {bmi}");

