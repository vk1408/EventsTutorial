namespace EventHandlerTutorial
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
        //public Action Smt = () => { };
        public event EventHandler<CustomEventArgs> Something;

        public ExampleClass()
        {
            // Event handler takes two variables:
            // 1.object that fairing the event 2. custom data to send
            Something += FunctionOne;
            Something += FunctionTwo;

            Something?.Invoke(this, new(3));
        }
        private void FunctionOne(object sender, CustomEventArgs args)
        {
            Console.WriteLine($"Function one called with value {args.Val}!");
        }
        private void FunctionTwo(object sender, CustomEventArgs args)
        {
            Console.WriteLine($"Function two called with value {args.Val}!");
        }
    }
    public class CustomEventArgs : EventArgs
    {
        public readonly int Val;
        public CustomEventArgs(int val)
        {
            Val = val;
        }
    }
}