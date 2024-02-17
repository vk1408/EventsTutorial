namespace EventsTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exampleClass = new ExampleClass();
          
        }
    }
    public class ExampleClass
    {
        // Delegate is a variable that stores function.
        public delegate void DoSomething(int num); // type
        public DoSomething Something; //  variable of type



        //public Action<int> SomethingAction;

        public ExampleClass() 
        {
            Something = FunctionOne;
            // Check delegates before calling them!
            if (Something != null)
                Something(123);
            // Check delegates before calling them with
            // null propagation operator
            Something?.Invoke(148);
            Something = FunctionTwo;
            Something?.Invoke(217);

            // "Subscribe" delegate to function
            Something += FunctionOne;
            Something += FunctionTwo;
            Something?.Invoke(123); // check delegate with null propagation operator


        }
        private void FunctionOne(int num) 
        {
            Console.WriteLine($"Function one called with value: {num}");
        }
        private void FunctionTwo(int num)
        {
            Console.WriteLine($"Function two called with value: {num}");
        }
    }
}