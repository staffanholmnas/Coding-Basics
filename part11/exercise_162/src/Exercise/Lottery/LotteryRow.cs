namespace Exercise
{
    using System;
    using System.Collections.Generic;

    public class LotteryRow
    {
        private List<int> numbers;

        public LotteryRow()
        {
            this.RandomizeNumbers();
        }

        public List<int> Numbers()
        {
            return this.numbers;
        }

        public bool ContainsNumber(int number)
        {
            // Tests whether the number is already among the randomized numbers
            if (this.numbers.Contains(number))
            {
                return true;
            }
            return false;
        }

        public void RandomizeNumbers()
        {
            // initialize the list for numbers
            this.numbers = new List<int>();
            // Implement the randomization of the numbers by using the method ContainsNumber() here
            Random lotto = new Random();
            for (int i = 0; i < 7; i++)
            {
                int lottoNumber = lotto.Next(1, 41);
                while (ContainsNumber(lottoNumber))
                {
                    lottoNumber = lotto.Next(1, 41);
                }
                this.numbers.Add(lottoNumber);
            }
            this.numbers.Sort();
        }
    }
}