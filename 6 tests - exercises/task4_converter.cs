// task 4: converter
// DIRECTORY: C:\Users\Sunrise GW\Desktop\SOU\SU\homeWork11042021
// FILENAME: task4_converter.cs

// INPUT
// Първи ред: число за преобразуване - реално число
// Втори ред: входна мерна единица - текст
// Трети ред: изходна мерна единица (за резултата) - текст

double number = double.Parse(Console.ReadLine());
double result = 0;

string inputUnit = Console.ReadLine();
string outputUnit = Console.ReadLine();

if (inputUnit == "m")
	if (outputUnit == "cm")
		result = number * 100;
	else
		result = number * 1000;
else if (inputUnit == "cm")
	if (outputUnit == "m")
		result = number / 10;
	else
		result = number * 10;
else if (inputUnit == "mm")
	if (outputUnit == "m")
		result = number * 1000;
	else
		result = number * 10;

Console.WriteLine(result);

	