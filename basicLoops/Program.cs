//Do while loop problem
bool wantsToPlayAgain = true;

do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue (y/n)?");

    Console.Write("<<");
    string userInput = Console.ReadLine();
    if (userInput.ToLower().Trim() == "n")
    {
        wantsToPlayAgain = false;
        Console.WriteLine("Goodbye!");
    }


}
while (wantsToPlayAgain == true);



//I was unable to get this to work. Ill be research for loops and trying to comeback to this

/*
//For loop problem
wantsToPlayAgain = true;
int userNumber = 0;

//do

    Console.Write(">>Enter a number: <<");
string userEnter = "";
userEnter = Console.ReadLine();
userNumber = int.Parse(userEnter);
    int previousNumber = userNumber;

    for (int i = userNumber; i == 0; i--)
    {
        Console.Write(userNumber);
        userNumber--;
    }

    Console.WriteLine("");

    for (int i = userNumber; i == previousNumber; i++)
    {
        Console.Write(userNumber);
        userNumber++;
    }
*/
/*
Console.Write("Enter a number:");
int userNumber = int.Parse(Console.ReadLine());
for (int i = userNumber; i == 0 ; i--) 
{
    
    Console.WriteLine( i );
}
*/


//while problem
int doorCombination = 13579;
bool doorLocked = true;
int wrongInput = 0;

while (doorLocked == true)
{
    Console.Write("Enter key code >>");
    int comboInput = int.Parse(Console.ReadLine());
    if (comboInput == doorCombination)
    {
        Console.WriteLine("Welcome Home!");
        doorLocked = false;
    }
    else 
    {
    wrongInput++;
    }

    if (wrongInput == 5)
    {
        Console.WriteLine("Too many incorrect attempts. Come back later.");
        doorLocked = false;
    }

}