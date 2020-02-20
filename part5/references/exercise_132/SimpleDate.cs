namespace exercise_132
{
    public class SimpleDate
    {
        private int day;
        private int month;
        private int year;

        public SimpleDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void Advance()
        {
            // Do something here
            // Adds 1 to days.
            this.day++;
        }

        public void Advance(int howManyDays)
        {
            // Do something here
            // Days advances by 1 for every loop. When days are over 30 then they are reset and 1 added to month.
            // When months exceeds 12 they are reset and 1 added to years. Choose the length of the loop when calling AfterNumberOfDays.

            for (int i = 0; i < howManyDays; i++)
            {
                // Calls the method that advances the date by 1.
                Advance();

                if (this.day > 30)
                {
                    this.month++;
                    this.day = 1;
                }

                if (this.month > 12)
                {
                    this.year++;
                    this.month = 1;
                } 
            }
        }

        public SimpleDate AfterNumberOfDays(int days)
        {
            // Creates a new object called newDate with the same values as the date.
            SimpleDate newDate = new SimpleDate(this.day, this.month, this.year);
            // Do something here

            // Calls the method that advances the days by the number of days specified when the method is called.
            newDate.Advance(days);

            return newDate;
        }


        public override string ToString()
        {
            return this.day + "." + this.month + "." + this.year;
        }

        // used to check if this date object (`this`) is before
        // the date object given as the parameter (`compared`)
        public bool Before(SimpleDate compared)
        {
            // first compare years
            if (this.year < compared.year)
            {
                return true;
            }

            // if the years are the same, compare months
            if (this.year == compared.year && this.month < compared.month)
            {
                return true;
            }

            // the years and the months are the same, compare days
            if (this.year == compared.year && this.month == compared.month &&
                this.day < compared.day)
            {
                return true;
            }

            return false;
        }
    }
}