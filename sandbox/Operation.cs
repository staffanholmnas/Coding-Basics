namespace Abstract_Class
{
    public abstract class Operation
    {

        public string name { get; }

        public Operation(string name)
        {
            this.name = name;
        }

        public abstract void Execute();
    }
}