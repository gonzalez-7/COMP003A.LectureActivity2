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
        }
    }
}
