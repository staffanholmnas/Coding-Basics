namespace OuterNamespace
{
    using static System.Console;
    class Example
    {
        public void ExampleMethod()
        {
            WriteLine("ExampleMethod in OuterNamespace");
        }
    }

    // Create a nested namespace, and define another class.
    namespace InnerNamespace
    {
        class Example
        {
            public void ExampleMethod()
            {
                WriteLine("ExampleMethod in InnerNamespace");
            }
        }
    }
}