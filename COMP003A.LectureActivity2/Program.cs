namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Step 3

            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

            // Step 4

            double a = double.Parse(input1);
            double b = double.Parse(input2);

            // Step 5

            double sum = a + b;
            double average = (a  + b) / 2;

            // Step 6A 

            Console.WriteLine();
            Console.WriteLine("Using Concatenation");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);

            // Step 6B

            Console.WriteLine();
            Console.WriteLine("Using interpolation");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");

            // Step 7

            bool greaterThan = a > b;
            bool equalTo = a == b;

            Console.WriteLine();
            Console.WriteLine("Comparisions");
            Console.WriteLine($"{a} > {b}: {greaterThan}");
            Console.WriteLine($"{a} == {b}: {equalTo}");
        }
    }
}
