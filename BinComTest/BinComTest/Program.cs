
string name = "John Doe";
int age = 25;
bool isAdmin = true;

int[] intArray = new int[] { 2, 4, 6, 8, 10 };


//Program that prints the values of variables declared to the console
TaskOne(name,age,isAdmin);

//Program that takes an integer input from the user and prints out whether the number is even or odd
TaskTwoIsEvenOrOdd();

//Program that prints out one to 10 using a for loop
TaskThreePrintOneToTen();

//Print the sum of all elements in the array to the console.
TaskFourPrintSumArray(intArray);

//Use a foreach loop to iterate over the array and print each element to the console.
TaskFourPrintEachNumberArray(intArray);

//Write a method named Greet that takes a string parameter name and prints out a personalized greeting message
TaskFiveGreet("Alice");



void TaskOne(string name, int age, bool isAdmin)
{
    Console.WriteLine(name);
    Console.WriteLine(age);
    Console.WriteLine(isAdmin);

    Console.WriteLine("---------- End of task one -----------\n");    
} 

void TaskTwoIsEvenOrOdd()
{
    Console.Write("Enter a number to know whether it is even or odd: ");
    int.TryParse(Console.ReadLine(), out int userNumber);
    if (userNumber <= 0)
    {
        Console.WriteLine("Enter a number greater than zero");
        Console.WriteLine("--------- Repeating task two ---------\n");
        TaskTwoIsEvenOrOdd();
    }
    else
    {
        if (userNumber % 2 == 0)
        {
            Console.WriteLine($"Even");
            Console.WriteLine("---------- End of task two -----------\n");
        }
        else
        {
            Console.WriteLine($"Odd");
            Console.WriteLine("---------- End of task two -----------\n");
        }
    }
    
}

void TaskThreePrintOneToTen()
{
    for(int i = 1; i < 11; i++)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("---------- End of task three -----------\n");
}

void TaskFourPrintSumArray(int[] array)
{
    int sum = 0;
    foreach(var numb in array)
    {
        sum += numb;
    }

    Console.WriteLine($"The sum of the array is: {sum}");
}

void TaskFourPrintEachNumberArray(int[] array)
{
    foreach (var numb in array)
    {
        Console.WriteLine($"{numb}\t");
    }

    Console.WriteLine("---------- End of task four -----------\n");

}

void TaskFiveGreet(string name)
{
    Console.WriteLine($"Hello, {name}!");
    Console.WriteLine("---------- End of task whole program -----------\n");
}

