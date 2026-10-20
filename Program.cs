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


void PrintStudentCard(string name, int age, string group)
{
   Console.WriteLine($"Студент: {name}, возраст: {age}, группа: {group}");

}
PrintStudentCard("Егор", 18,"ИСП-251");
PrintStudentCard("Валерия", 17,"ИСП-252");