using System.Collections.Generic;
using System;
public class GradeRegister
{
    private List<int> grades;
    private List<int> points; // Added a list for points to instance variables.

    public GradeRegister()
    {
        this.grades = new List<int>();
        this.points = new List<int>(); // New list of points created when constructor is invoked.
    }

    public void AddGradeBasedOnPoints(int points)
    {
        this.grades.Add(PointsToGrades(points));
        this.points.Add(points); // Adds the points that are inserted by the user to a the list.
    }

    public int NumberOfGrades(int grade)
    {
        int count = 0;
        foreach (int received in this.grades)
        {
            if (received == grade)
            {
                count++;
            }
        }
        return count;
    }

    public static int PointsToGrades(int points)
    {
        int grade = 0;
        if (points < 50)
        {
            grade = 0;
        }
        else if (points < 60)
        {
            grade = 1;
        }
        else if (points < 70)
        {
            grade = 2;
        }
        else if (points < 80)
        {
            grade = 3;
        }
        else if (points < 90)
        {
            grade = 4;
        }
        else
        {
            grade = 5;
        }
        return grade;
    }

    public double AverageOfGrades()
    {
        // Adds all the grades from the list and calculates the average and then returns it.
        // If there are no grades on the list it returns -1. The average is rounded to two decimal points.
        double sum = 0;
        double avg = 0;
        foreach (int grade in grades)
        {
            sum = sum + grade;

        }
        avg = sum / grades.Count;

        if (sum == 0)
        {
            return -1;
        }
        // Hint! You don't need to round the -1, but you do need it for all the other results...
        return Math.Round(avg, 2);
    }

    public double AverageOfPoints()
    {
        // Adds all the points from the list and calculates the average and then returns it.
        // If there are no points on the list it returns -1. The average is rounded to two decimal points.
        double sum = 0;
        double avg = 0;
        foreach (int point in points)
        {
            sum = sum + point;

        }
        avg = sum / points.Count;

        if (sum == 0)
        {
            return -1;
        }

        return Math.Round(avg, 2);
    }
}
