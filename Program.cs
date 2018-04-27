using System;
using System.Collections.Generic;
using System.Linq;

/* Write a class Student with the following properties: first name, last name and age. 
 * Write the method that for a given array of students first name and last name one in alphabetical order. Use LINQ.
 * 
 * Create a LINQ query that finds the first and the last name of all students, aged between 18 and 24 years including.  
 * Use the class Student from from the previous exercise.
 * 
 * By using the extension methods OrderBy(...) and ThenBy(...) with lambda expression and LINQ query sort a list of students 
 * by their first and last name in descending order. Write one method using LINQ another using lambda.
 * 
 * Напишите класс Student со следующими свойствами: имя, фамилия и возраст.
 * Напишите метод, который для данного массива студентов будет сортировать имя и фамилию в алфавитном порядке. Используйте LINQ.
 * 
 * Создайте запрос LINQ, который найдет имя и фамилию всех учащихся в возрасте от 18 до 24 лет включительно.
 * Используйте класс Student из предыдущего упражнения.
 * 
 * Используя методы расширения OrderBy (...) и ThenBy (...) с lambda-выражением и запросом LINQ, отсортируйте список студентов 
 * по их имени и фамилии в порядке убывания. Напишите один метод используя LINQ, другой используя lambda.
*/

namespace _20180322_Task1_LINQ
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student{FirstName = "Zahar", LastName = "Makalkin", Age = 21},
                new Student{FirstName = "Anna", LastName = "Bondarchyk", Age = 23 },
                new Student{FirstName = "Nazar", LastName = "Averin", Age = 15},
                new Student{FirstName = "Pavel", LastName = "Petrhovich", Age = 40},
                new Student{FirstName = "Irina", LastName = "Sidorenko", Age = 9}
            };

            // Сортируем имена и фамилии студентов по алфавиту.
            var sortedStudents = from fl in students
                                 orderby fl.FirstName, fl.LastName
                                 select fl;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Names of students in alphabetical order:");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (Student fl in sortedStudents)
                Console.WriteLine(fl.FirstName + " " + fl.LastName);

            // Поиск студентов в возрасте от 18 до 24 лет включительно.
            var aged = from age in students
                       where age.Age >= 18 && age.Age <= 24
                       select age;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nStudents aged 18 to 24 years inclusive:");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (Student age in aged)
                Console.WriteLine(age.FirstName + " " + age.LastName + ", " + age.Age + " years old");

            // LINQ: Сортируем имена и фамилии студентов по убыванию.
            var sortLinq = from linqQuery in students
                           orderby linqQuery.FirstName descending, linqQuery.LastName descending
                           select linqQuery;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nLINQ: names of students in descending order:");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (Student linqQuery in sortLinq)
                Console.WriteLine(linqQuery.FirstName + " " + linqQuery.LastName);

            // Lambda-expression: Сортируем имена и фамилии студентов по убыванию.
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nLambda-expression: names of students in descending order:");
            Console.ForegroundColor = ConsoleColor.Gray;

            var sortLambda = students.OrderByDescending(std => std.FirstName);

            foreach (Student item in sortLambda)
                Console.WriteLine(item.FirstName + " " + item.LastName);

            Console.ReadKey();
        }
    }
}