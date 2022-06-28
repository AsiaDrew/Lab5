while (true)
{
    string[] studentName = { "Mara", "Krista", "Olukayode", "Robot", "Tolulope" };
    string[] homeTown = { "Rochester, MI", "Grosse Ile, MI", "Ibadan, Nigeria", "Green Bay, WI", "Asese, Nigeria" };
    string[] favoriteFood = { "Tacos", "Sushi", "Pounded Yam", "Bread", "Rice and Dodo" };
    int studentId;
    studentId = ListOfStudents(studentName);
    TownOrFood(studentName, homeTown, favoriteFood, studentId);
    Console.WriteLine("Would you like to run the program again? Please enter y/n");
    string choiceGoAgain = Console.ReadLine().ToLower();
    if (choiceGoAgain == "y")
    {
        Console.WriteLine("Awesome!");
        continue;
    }
    else if (choiceGoAgain == "n")
    {
        Console.WriteLine("Goodbye!");
        break;
    }
    else
    {
        Console.WriteLine("I'm sorry, I dont understand. Please choose y/n");
    }
}
static void TownOrFood(string[] studentName, string[] homeTown, string[] favoriteFood, int studentId)
{
    while (true)
    {
        Console.WriteLine($"You chose {studentName[studentId]}. What would you like to learn next about {studentName[studentId]}? Please enter hometown or favorite food. ");
        string hometownOrFood = Console.ReadLine().ToLower().Trim();

        if (hometownOrFood.Contains("town"))
        {
            Console.WriteLine($"{studentName[studentId]} is from {homeTown[studentId]}.");
            Console.WriteLine();
            break;
        }
        else if (hometownOrFood.Contains("food"))
        {
            Console.WriteLine($"{studentName[studentId]}'s favorite food is {favoriteFood[studentId]}.");

            break;
        }
        else
        {
            Console.WriteLine("I dont understand. Please enter hometown or favorite food.");

            continue;
        }
    }
}
//METHODS
static int ListOfStudents(string[] studentName)
{//option to see list of students
    int studentId;
    while (true)
    {
        Console.WriteLine("Would you like to see a list of all students? Enter y/n");
        string StudentList = Console.ReadLine().ToLower();
        if (StudentList == "y")
        {
            Console.WriteLine("Here is the Student List: ");
            foreach (var name in studentName)
            {
                Console.WriteLine(name);
            }
        }
        else if (StudentList == "n")
        {
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Thats not a valid input");
        }
        Console.WriteLine("Which student do you want to learn more about? Enter a number 1-5");
        int choice = int.Parse(Console.ReadLine());
        if (choice <= 0 || choice > studentName.Length + 1)
        {
            Console.WriteLine("Oops, enter a number between 1 and 5.");
            Console.WriteLine();
            continue;
        }
        else
        {
            studentId = choice - 1;
            break;
        }
    }
    return studentId;
}