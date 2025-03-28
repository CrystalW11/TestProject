// The following line of code outputs a simple string message to the console.
Console.WriteLine("Hello, C#!");  // Prints "Hello, C#!" to the console.

// Creating an instance of the Random class to generate random numbers.
Random dice = new Random();  // `dice` is an object of the `Random` class that we use to generate random numbers.

// Rolling three dice by generating random numbers between 1 and 6 for each dice roll.
int roll1 = dice.Next(1, 7);  // Generates a random number between 1 and 6 for the first die (inclusive of 1, exclusive of 7).
int roll2 = dice.Next(1, 7);  // Generates a random number between 1 and 6 for the second die.
int roll3 = dice.Next(1, 7);  // Generates a random number between 1 and 6 for the third die.

// Summing up the three dice rolls to calculate the total.
int total = roll1 + roll2 + roll3;  // The sum of roll1, roll2, and roll3 is stored in the `total` variable.

// Displaying the results of the dice rolls and the total to the console.
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");  // Prints the individual dice rolls and their total sum.

// Checking if the total of the dice rolls is greater than 14 and printing "You win!" if true.
if (total > 14)  // If the sum of the dice rolls is greater than 14, this block will execute.
{
    Console.WriteLine("You win!");  // Prints "You win!" to the console.
}

// Checking if the total of the dice rolls is less than 15 and printing "Sorry, you lose." if true.
if (total < 15)  // If the sum of the dice rolls is less than 15, this block will execute.
{
    Console.WriteLine("Sorry, you lose.");  // Prints "Sorry, you lose." to the console.
}
