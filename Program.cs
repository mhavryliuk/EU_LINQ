using System;
using System.Collections.Generic;

/** <remark>
 * Write a class Student with the following properties: first name, last name and age. 
 * Write the method that for a given array of students first name and last name one in alphabetical order. Use LINQ.
 * 
 * Create a LINQ query that finds the first and the last name of all students, aged between 18 and 24 years including.  
 * Use the class Student from from the previous exercise.
 * 
 * By using the extension methods OrderBy(...) and ThenBy(...) with lambda expression and LINQ query sort a list of students 
 * by their first and last name in descending order. Write one method using LINQ another using lambda.
</remark> */

namespace _20180322_Task1_LINQ
{
    internal class Program
    {
        private static void Main()
        {
            Student st = new Student();

            List<Student> students = new List<Student>()
            {
                new Student{FirstName = "Zahar", LastName = "Makalkin", Age = 21},
                new Student{FirstName = "Anna", LastName = "Bondarchyk", Age = 23 },
                new Student{FirstName = "Nazar", LastName = "Averin", Age = 15},
                new Student{FirstName = "Pavel", LastName = "Petrhovich", Age = 40},
                new Student{FirstName = "Irina", LastName = "Sidorenko", Age = 9}
            };

            try
            {
                st.SortNamesInAlphabeticalOrder(students);
                st.SearchStudentsAged18to24(students);
                st.SortNamesInDescendingOrder_LINQ(students);
                st.SortNamesInDescendingOrder_Lambda(students);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}