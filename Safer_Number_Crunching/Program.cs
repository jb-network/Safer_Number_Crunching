// This is challenge work for the "C# Players Guide"
// Level 34  "Safer Number Crunching" Challenge
//This is a challenge to use the TryParse Method

int IntNum;
double DoubleNum;
bool Bool;
bool Success;

//Int Test
do
{
    Console.WriteLine("Test 1: Int Test");
    Console.WriteLine("Please enter an integer");
    Success = int.TryParse(Console.ReadLine(), out IntNum);
    if (Success == true) Console.WriteLine($"The input value: {IntNum}, is a valid integer\n");
    else Console.WriteLine("The input value provided was not a valid interger, Please try again\n");
}while (Success == false);


//Double Test
do
{
    Console.WriteLine("Test 2: Double Test");
    Console.WriteLine("Please enter a number");
    Success = double.TryParse(Console.ReadLine(), out DoubleNum);
    if (Success == true) Console.WriteLine($"The input value: {DoubleNum}, is a valid number\n");
    else Console.WriteLine("The input value provided was not a valid number, Please try again\n");
} while(Success == false);

//Bool Test
do
{
    Console.WriteLine("Test 3: Bool Test");
    Console.WriteLine("Please type true of false");
    Success = bool.TryParse(Console.ReadLine(), out Bool);
    if (Success == true) Console.WriteLine($"The input value: {Bool}, is a valid bool\n");
    else Console.WriteLine("The input that was provided was not a valid bool, Please try again\n");
} while (Success == false);
