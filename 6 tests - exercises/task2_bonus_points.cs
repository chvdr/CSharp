

// task 2: Bonus points
// DIRECTORY: C:\Users\Sunrise GW\Desktop\SOU\SU\homeWork11042021
// FILENAME: task2_bonus_points.cs


// read input data
int number  = int.Parse(Console.ReadLine());
double bonus = 0.0;

// calculate the bonus 
if (number <= 100)
{
	bonus = 5;
}
else if (number > 1000)
{
	bonus = number * 0.1;
}
else
{
	bonus = number * 0.2;
}

if (number % 2 == 0)
{
	// bonus++;
	// bonus += 1;
	bonus = bonus + 1;
}

if (number % 10 == 5)
{
	bonus += 2;
}

// OUTPUT
Console.WriteLine(bonus);
Console.WriteLine(bonus + number);


