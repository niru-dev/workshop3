namespace Task6
{
    class Program
    {
        public static void Main() // Fixed method name to 'Main' and made it static
        {
            Program program = new Program(); // Create an instance to call non-static methods
            program.ConvertInput();

            program.CheckPassword();
        }
        public void ConvertInput()
        {
            try
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You entered: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }
        }

        public void CheckPassword()
        {
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (password.Length < 6)
            {
                throw new Exception("Password must be at least 6 characters.");
            }
            else
            {
                Console.WriteLine("Password satisfied the requirement");
            }
        }
    }
}