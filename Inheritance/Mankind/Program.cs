namespace Mankind
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] studentData = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string studentFirstName = studentData[0];
            string studentLastName = studentData[1];
            string studentFacultyNumber = studentData[2];

            Student newStudent;

            try
            {
                newStudent = new Student(
                    studentFirstName,
                    studentLastName,
                    studentFacultyNumber);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            string[] workerData = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string workerFirstName = workerData[0];
            string workerLastName = workerData[1];
            decimal workerWeekSalary = decimal.Parse(workerData[2]);
            int workerHoursPerDay = int.Parse(workerData[3]);

            Worker newWorker;

            try
            {
                newWorker = new Worker(
                    workerFirstName,
                    workerLastName,
                    workerWeekSalary,
                    workerHoursPerDay);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine(newStudent.ToString());
            Console.WriteLine(newWorker.ToString());
        }
    }
}
