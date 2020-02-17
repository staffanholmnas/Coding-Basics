using System;

namespace exercise_121
{

    public class Fitbyte
    {
        int age {get; set;}
        int restingHeartRate {get; set;}

        public Fitbyte(int age, int restingHeartRate)
        {
            this.age = age;
            this.restingHeartRate = restingHeartRate;
        }

        public double TargetHeartRate(double percentageOfMaximum)
        {
            double maxHeartRate = 206.3 - (0.711 * this.age); // Calculates the maximum heart rate.
            return (maxHeartRate - this.restingHeartRate) * percentageOfMaximum + this.restingHeartRate; // Returns the target heart rate.
        }



    }
}