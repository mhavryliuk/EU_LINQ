using System;
using System.Collections.Generic;
using System.Linq;

namespace _20180322_Task1_LINQ
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        /// <summary>
        /// The CeskForeNullandEmpts() method that checks the parameter to null and checks whether the parameter is an empty collection.
        /// </summary>
        /// <param name="students">Students list.</param>
        private static void CheckForNullandEmpty(List<Student> students)
        {
            if (students == null)
                throw new ArgumentNullException(nameof(students));
            if (students.Count == 0)
                throw new ArgumentException("Value cannot be an empty collection.", nameof(students));
        }

        /// <summary>
        /// The SortingNamesInAlphabeticalOrder() method sorts the names and surnames of students alphabetically.
        /// </summary>
        /// <param name="students">Students list.</param>
        internal void SortNamesInAlphabeticalOrder(List<Student> students)
        {
            CheckForNullandEmpty(students);

            var sortedStudents = from fl in students
                                 orderby fl.FirstName, fl.LastName
                                 select fl;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Names of students in alphabetical order:");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (Student fl in sortedStudents)
                Console.WriteLine(fl.FirstName + " " + fl.LastName);
        }

        /// <summary>
        /// The SearchStudentsAged18to24() method searches for students aged 18 to 24 years inclusive.
        /// </summary>
        /// <param name="students">Students list.</param>
        internal void SearchStudentsAged18to24(List<Student> students)
        {
            CheckForNullandEmpty(students);

            var aged = from age in students
                       where age.Age >= 18 && age.Age <= 24
                       select age;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nStudents aged 18 to 24 years inclusive:");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (Student age in aged)
                Console.WriteLine(age.FirstName + " " + age.LastName + ", " + age.Age + " years old");
        }

        /// <summary>
        /// The SortNamesInDescendingOrder_LINQ() method sorts the names and surnames of students in descending order with using LINQ.
        /// </summary>
        /// <param name="students">Students list.</param>
        internal void SortNamesInDescendingOrder_LINQ(List<Student> students)
        {
            CheckForNullandEmpty(students);

            var sortLinq = from linqQuery in students
                           orderby linqQuery.FirstName descending, linqQuery.LastName descending
                           select linqQuery;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nLINQ: names of students in descending order:");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (Student linqQuery in sortLinq)
                Console.WriteLine(linqQuery.FirstName + " " + linqQuery.LastName);
        }

        /// <summary>
        /// The SortNamesInDescendingOrder_LINQ() method sorts the names and surnames of students in descending order with using Lambda-expression.
        /// </summary>
        /// <param name="students">Students list.</param>
        internal void SortNamesInDescendingOrder_Lambda(List<Student> students)
        {
            CheckForNullandEmpty(students);

            var sortLambda = students.OrderByDescending(std => std.FirstName);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nLambda-expression: names of students in descending order:");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (Student item in sortLambda)
                Console.WriteLine(item.FirstName + " " + item.LastName);
        }
    }
}