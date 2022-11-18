using Delegates.Models;
using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        //public delegate bool CheckNums(int num);

        static void Main(string[] args)
        {

            #region Task 1 - Practice

            //string name = null;
            //Console.WriteLine(name);
            //Student student = null;
            //Console.WriteLine(student);

            //int? a = null;
            //Student student = new Student();
            //Console.WriteLine(student.Id);
            //Console.WriteLine(a);
            //var result1 = SumOfOddNums(arr);
            //var result2 = SumOfEvenNums(arr);
            //var result3 = GreaterThanFour(arr);
            //Console.WriteLine("Sum of odd numbers in array: " + result1);
            //Console.WriteLine("Sum of even numbers in array: " + result2);
            //Console.WriteLine("Sum of numbers greater than four in array: " + result3);
            //var result = Sum(CheckEvenNums, arr);
            //Console.WriteLine(result);
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(Sum(GreaterThanFour,arr));
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var result = list.FindAll(GreaterThanFour);

            #endregion
            #region Task 2 - Homework
            //List<Person> list = new List<Person>();
            //AddPersons(list);
            //GetNameSurnameAndAddress(CheckSalary, list);
            #endregion
            #region Task 3 - Homework

            //List<Book> list = new List<Book>();
            //AddBooks(list);
            //var result = CountOfBooks(CheckAuthor, list);
            //Console.WriteLine("Count of books = " + result);
            #endregion
            #region Task 4 - Homework

            //List<Employee> list = new List<Employee>();
            //AddEmployees(list);
            //var result = FindAverageOfSalaryofEmployees(CheckAgesOfEmployees,list);
            //Console.WriteLine("Average of salaries = "+ result);
            #endregion
        }


        public static bool GreaterThanFour(int num)
        {
            return num > 4;
        }
        public static bool CheckOddNums(int num)
        {
            return num % 2 == 0;
        }
        public static bool CheckEvenNums(int num)
        {
            return num % 2 == 1;
        }

        public static int Sum(Predicate<int> predicate,int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                if (predicate(item))
                {
                    sum += item;
                }
            }
            return sum;
        }
        //public static int SumOfEvenNums(int[] arr)
        //{
        //    int sum = 0;
        //    foreach (var item in arr)
        //    {
        //        if (item % 2 == 0)
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}
        //public static int GreaterThanFour(int[] arr)
        //{
        //    int sum = 0;
        //    foreach (var item in arr)
        //    {
        //        if (item > 4)
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}



        public static string GetData(int? id)
        {   
            if (id is null)
            {
                return " ";
            }
            return "";
        }
        class Student
        {
            public int? Id { get; set; }
        }


        public static bool CheckSalary(Person person)
        {
            return person.Salary > 1000;
        }

        public static void GetNameSurnameAndAddress(Predicate<Person> predicate, List<Person> list)
        {
            foreach (Person person in list)
            {
                if (predicate(person))
                {
                    Console.WriteLine($"Name = {person.Name}, Surname = {person.Surname}, Address = {person.Address}");
                    //Console.WriteLine("Name = {0}, Surname = {1}, Address = {2}",person.Name, person.Surname, person.Address);
                    //Console.WriteLine("Name = " + person.Name + ",Surname = " + person.Surname + ",Address = " + person.Address);
                }
            }
        }

        public static void AddPersons(List<Person> list)
        {
            list.Add(new Person { Name = "Elcan", Surname = "Musali", Address = "Nerimanov metrosu", Salary = 1100 });
            list.Add(new Person { Name = "Selim", Surname = "Agamaliyev", Address = "Genclik metrosu", Salary = 1500 });
            list.Add(new Person { Name = "Yunis", Surname = "Balakisiyev", Address = "Azadliq metrosu", Salary = 800 });
            list.Add(new Person { Name = "Ulfet", Surname = "Mirzeyev", Address = "Neftciler metrosu", Salary = 1200 });
            list.Add(new Person { Name = "Murad", Surname = "Umudov", Address = "Hezi Aslanov metrosu", Salary = 900 });
            list.Add(new Person { Name = "Cavid", Surname = "Necefli", Address = "Memar Ecemi metrosu", Salary = 1400 });
            list.Add(new Person { Name = "Xeyal", Surname = "Aslanzade", Address = "20 Yanvar metrosu", Salary = 750 });
        }



        public static bool CheckAuthor(Book book)
        {
            return book.Author == "Nizami Gencevi";
        }

        public static int CountOfBooks(Predicate<Book> predicate, List<Book> list)
        {
            int count = 0;
            foreach (Book book in list)
            {
                if (predicate(book))
                {
                    count++;
                }
            }
            return count;
        }

        public static void AddBooks(List<Book> list)
        {
            list.Add(new Book { Author = "Abbas Sehet" });
            list.Add(new Book { Author = "Nizami Gencevi" });
            list.Add(new Book { Author = "Mirze Elekber Sabir" });
            list.Add(new Book { Author = "Nizami Gencevi" });
            list.Add(new Book { Author = "Xaqani Sirvani" });
            list.Add(new Book { Author = "Semed Vurgun" });
            list.Add(new Book { Author = "Nizami Gencevi" });
        }



        public static bool CheckAgesOfEmployees(Employee employee)
        {
            return employee.Age > 20 && employee.Age < 40;
        }

        public static double FindAverageOfSalaryofEmployees(Predicate<Employee> predicate, List<Employee> list)
        {
            double sum = 0;
            int count = 0;
            foreach (Employee employee in list)
            {
                if (predicate(employee))
                {
                    sum += employee.Salary;
                    count++;
                }       
            }
            return sum / count;       
        }

        public static void AddEmployees(List<Employee> list)
        {
            list.Add(new Employee { Age = 45, Salary = 400 });
            list.Add(new Employee { Age = 25, Salary = 600 });
            list.Add(new Employee { Age = 38, Salary = 800 });
            list.Add(new Employee { Age = 50, Salary = 500 });
            list.Add(new Employee { Age = 39, Salary = 768 });
            list.Add(new Employee { Age = 42, Salary = 800 });
            list.Add(new Employee { Age = 30, Salary = 950 });
        }

    }
}
