using System;

class Program
{
    static void Main()
    {
        int[,] grades = new int[5, 3];

        for (int student = 0; student < 5; student++)
        {
            for (int subject = 0; subject < 3; subject++)
            {
                grades[student, subject] = (student + 1) * 10 + subject * 5; 
            }
        }

        Console.WriteLine("Grades of 5 students in 3 subjects:");
        for (int student = 0; student < 5; student++)
        {
            Console.Write("Student " + (student + 1) + ": ");
            for (int subject = 0; subject < 3; subject++)
            {
                Console.Write(grades[student, subject] + "\t");
            }
            Console.WriteLine();
        }
    }
}
