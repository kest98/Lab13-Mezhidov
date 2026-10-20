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


using System.Runtime.InteropServices;

// void PrintStudentCard(string name, int age, string group)
// {
//    Console.WriteLine($"Студент: {name}, возраст: {age}, группа: {group}");

// }
// PrintStudentCard("Егор", 18,"ИСП-251");
// PrintStudentCard("Валерия", 17, "ИСП-252");



//задание не сделано шаг3
// double CalculateScholarship(double baseAmount, double bonusPercent)
// {
//    return baseAmount + baseAmount + bonusPercent / 100;
// }
// double result = CalculateScholarship(2000, 15);
// Console.WriteLine(result);



double CalculateAverageGrade(int[] grades)
{
   int sum = 0;
   foreach (int grade in grades)
   {
      sum += grade;
   }
   return (double)sum / grades.Length;
}
int countFives(int[] grades)
{
   int count = 0;
   foreach (int grade in grades)
   {
      if (grade == 5)
      {
         count++;
      }

   }
   return count;
}
int[] grades = { 4, 5, 3, 5, 4 };
double average = CalculateAverageGrade(grades);
Console.WriteLine(average);

int fives = countFives(grades);
Console.WriteLine(fives);

