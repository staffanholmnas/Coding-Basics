using System;

namespace Randomizer
{
    public class WeatherMan
    {
        private Random random;

        public WeatherMan()
        {
            this.random = new Random();
        }

        public string Forecast()
        {
            double propability = this.random.NextDouble();
            int randomTemp = this.random.Next(15);
            int randomTemp2 = this.random.Next(20) - 20;
            int randomTemp3 = this.random.Next(50) - 20;
            if (propability <= 0.1)
            {
                return "It rains. It is " + randomTemp + " degrees.";
            }
            else if (propability <= 0.4)
            { // 0.1 + 0.3
                return "It snows. It is " + randomTemp2 + " degrees.";
            }
            else
            { // rest, 1.0 - 0.4 = 0.6
                return "The sun shines. It is " + randomTemp3 + " degrees.";
            }
        }
    }
}
