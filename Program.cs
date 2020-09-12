using System;

namespace lab4
{
    class Programm
    {
        // Студент групи ІО-91 Герейханов Тимур
        // Номер залікової книжки: 9107
        // С11 = 10
        static void Main()
        {
            Student s1 = new Student("Timur", "Gereihanov", 177.76, 89, 67);
            Student s2 = new Student("Paul", "Krasnoshchock", 180.3, 80, 84);
            Student s3 = new Student("Vasya", "Bodnar", 175.2, 70, 72);

            Student[] students = new Student[] { s1, s2, s3 };             //створюємо масив з об'єктами класу
            Array.Sort(students);   //сортуємо по росту за зростанням

            Console.WriteLine("Сортування студентiв за зростанням росту");
            foreach (Student p in students)
            {
                Console.WriteLine($"Iм'я студента: {p.NameOfStudent}\nПрiзвище студента: {p.SecondNameOfStudent}" +
                    $"\nЗрiст студента: {p.HeightOfStudent}\nСереднiй бал: {p.AverageMark}\nМаса студента: {p.Weight}");
                Console.WriteLine();
            }

            Console.Write(new string('_',70));
            Console.WriteLine();

            Array.Sort(students, new StudentsCompare());   
            Array.Reverse(students);                    //сортуємо по середньому балу за спаданням

            Console.WriteLine("Сортування студентiв за спаданням середнього балу");
            foreach (Student p in students)
            {
                Console.WriteLine($"Iм'я студента: {p.NameOfStudent}\nПрiзвище студента: {p.SecondNameOfStudent}" +
                    $"\nЗрiст студента: {p.HeightOfStudent}\nСереднiй бал: {p.AverageMark}\nМаса студента: {p.Weight}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        
    }



        
    
}
