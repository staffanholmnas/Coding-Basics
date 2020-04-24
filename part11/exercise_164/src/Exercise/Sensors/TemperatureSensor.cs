namespace Exercise
{
    using System;
    public class TemperatureSensor : Sensor
    {
        private Random random;
        private Boolean onOffSwitch;

        public TemperatureSensor()
        {
            this.random = new Random();
            this.onOffSwitch = false;
        }

        public bool IsOn()
        {
            return this.onOffSwitch;
        }

        public void SetOn()
        {
            this.onOffSwitch = true;
        }

        public void SetOff()
        {
            this.onOffSwitch = false;
        }

        public int Read()
        {
            if (!IsOn())
            {
                throw new InvalidOperationException("Turn on the temperature sensor first!");
            }
            
            int randomTemp = this.random.Next(60) - 30;
            return randomTemp;
        }
    }
}