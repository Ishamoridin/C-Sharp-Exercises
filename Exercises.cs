// https://www.w3resource.com/csharp-exercises/basic/index.php
// C# Exercises

//*********************************************************************************************************************
// Basic - 1: Write a C# Sharp program to print Hello and your name in a separate line. 

// Console.WriteLine("What is your name?");
// string? name = Console.ReadLine();
// Console.WriteLine($"Hello: \n {name}");

//*********************************************************************************************************************
//Basic - 2: Write a C# Sharp program to print the sum of two numbers. 

// Console.WriteLine("Give me a number");
// int? firstNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Give me another number");
// int? secondNumber = int.Parse(Console.ReadLine());
// Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {firstNumber + secondNumber}");

//*********************************************************************************************************************
//Basic - 3: Write a C# Sharp program to print the result of dividing two numbers. 

// Console.WriteLine("Give me a number");
// int? firstNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Give me another number");
// int? secondNumber = int.Parse(Console.ReadLine());
// Console.WriteLine($"{firstNumber} divided by {secondNumber} is {(double)firstNumber/secondNumber}");

//*********************************************************************************************************************
//Basic - 4: Write a C# Sharp program to print the results of the specified operations. 

// Console.WriteLine(-1 + 4 * 6);
// Console.WriteLine(( 35+ 5) % 7);
// Console.WriteLine(14 + -4 * 6 / 11);
// Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

//*********************************************************************************************************************
// Basic - 5: Write a C# Sharp program to swap two numbers. 

// Console.WriteLine("Give me a number");
// int? firstNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Give me another number");
// int? secondNumber = int.Parse(Console.ReadLine());
// Console.WriteLine($"First number: {firstNumber}\nSecond number: {secondNumber}");
// int? temp = firstNumber;
// firstNumber = secondNumber;
// secondNumber = temp;
// Console.WriteLine($"First number: {firstNumber}\nSecond number: {secondNumber}");

//*********************************************************************************************************************
// Basic - 6: Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user. 

// Console.WriteLine("Give me a number");
// int? firstNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Give me another number");
// int? secondNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Give me one last number");
// int? thirdNumber = int.Parse(Console.ReadLine());
// Console.WriteLine($"{firstNumber} times {secondNumber} times {thirdNumber} equals {firstNumber * secondNumber * thirdNumber}");

//*********************************************************************************************************************
// Basic - 7: Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user. 

// Console.WriteLine("Give me a number");
// int? firstNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Give me another number");
// int? secondNumber = int.Parse(Console.ReadLine());
// Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}\n{firstNumber} - {secondNumber} = {firstNumber - secondNumber}\n{firstNumber} x {secondNumber} = {firstNumber * secondNumber}\n{firstNumber} / {secondNumber} = {firstNumber / secondNumber}\n{firstNumber} mod {secondNumber} = {firstNumber % secondNumber}");


//*********************************************************************************************************************
// Basic - 8: Write a C# Sharp program that prints the multiplication table of a number as input.

// Console.WriteLine("Give me a number");
// int? number = int.Parse(Console.ReadLine());
// for (int i = 1 ; i <= 10 ; i++)
// {
//     Console.WriteLine($"{number} x {i} = {number * i}");
// }

//*********************************************************************************************************************
// Basic - 9: Write a C# Sharp program that takes four numbers as input to calculate and print the average. 

// int[] numbers = new int[4];
// for (var i = 0;i<4;i++)
// {
//     Console.WriteLine("Please enter a number");
//     numbers[i] = int.Parse(Console.ReadLine());
// }

// var sum = 0;

// void SumArrayEntries(int val)
// {
//     sum += val;
// }

// Array.ForEach(numbers, SumArrayEntries);

// Console.WriteLine($"The mean of {numbers[0]}, {numbers[1]}, {numbers[2]}, and {numbers[3]} is {(double) sum/4}");

//*********************************************************************************************************************
// Basic - 10: Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z. 

// int[] numbers = new int[3];

// for (var i=0;i<numbers.Length;i++)
// {
//     Console.WriteLine($"Please enter number {i+1}");
//     numbers[i] = int.Parse(Console.ReadLine());
// }

// Console.Write("Calculating");
// for (var i=0;i<=2;i++){
//     Console.Write(".");
//     System.Threading.Thread.Sleep(1000);
// }
// Console.WriteLine(".");

// Console.WriteLine($"Result of specified numbers {numbers[0]}, {numbers[1]} and {numbers[2]}, (x+y).z is {(numbers[0]+numbers[1])*numbers[2]} and x.y + y.z is {numbers[1]*(numbers[0]+numbers[2])}");

//*********************************************************************************************************************
// Basic - 11: Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20". 

// Console.Write("Enter your age: ");
// int age = int.Parse(Console.ReadLine());
// Console.WriteLine($"You look older than {age}");

// *********************************************************************************************************************
// Basic - 12: Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. 
//             You should do it twice: Use the Console.Write and use {0}. 

// Console.Write("Enter a digit: ");
// int digit = int.Parse(Console.ReadLine());
// for (int i = 0 ; i < 2 ; i++)
// {
//     for (int j = 0 ; j < 4 ; j++)
//     {
//         Console.Write("{0} ", digit);
//     }
//     Console.Write("\n");
//     for (int j = 0 ; j < 4 ; j++)
//     {
//         Console.Write("{0}", digit);
//     }
//     Console.Write("\n");
// }

// *********************************************************************************************************************
// Basic - 13:  Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit. 

// Console.WriteLine("Give me a number");
// int? number = int.Parse(Console.ReadLine());
// Console.WriteLine($"{number}{number}{number}");
// Console.WriteLine($"{number} {number}");
// Console.WriteLine($"{number} {number}");
// Console.WriteLine($"{number} {number}");
// Console.WriteLine($"{number}{number}{number}");

//*********************************************************************************************************************
// Basic - 14: Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit. 

// Console.WriteLine("Give me a temperature in degrees Celcius");
// int? temperature = int.Parse(Console.ReadLine());
// Console.WriteLine($"Kelvin = {temperature + 273}\nFahrenheit = {32 + (temperature * 9 / 5)}");

//*********************************************************************************************************************
// Basic - 15: Write a C# program that removes a specified character from a non-empty string using the index of a character. 

// Console.WriteLine("Give me a word or phrase");
// string? s = Console.ReadLine();
// Console.WriteLine("Give me a number, shorter than the number of characters in what you just gave me");
// int? index = int.Parse(Console.ReadLine());
// Console.WriteLine($"{(s!=null ? s[..(int)(index-1)] + s[(int)index..] : "")}");

//*********************************************************************************************************************
// Basic - 16: Write a C# program to create a new string from a given string where the first and last characters change their positions. 

// Console.Write("Give me a word to swap about: ");
// string s = Console.ReadLine();
// char[] letters = s.ToCharArray();
// string word =  "";
// word += letters[^1];
// int[] hash = [1,0];
// for (int i = 1 ; i < letters.Length-1 ; i++)
// {
//     word += letters[i];
// }
// word += letters[0];
// Console.WriteLine(word);

// *********************************************************************************************************************
// Basic - 17: Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back. 

// Console.Write("Enter a sentence for the program to use:  ");
// string sentence = Console.ReadLine();
// Console.WriteLine($"{sentence[..1]}{sentence}{sentence[..1]}");

// *********************************************************************************************************************
// Basic - 18: Write a C# program to check a pair of integers and return true if one is negative and one is positive. 

// Console.WriteLine("Give me a number");
// int? firstNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Give me another number");
// int? secondNumber = int.Parse(Console.ReadLine());
// Console.WriteLine($"{( (secondNumber * firstNumber < 0) ? "One of those numbers is negative!" : "Both or neither of those numbers are negative!")}");

//*********************************************************************************************************************
// Basic - 19: Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum. 

// Console.WriteLine("Give me a number");
// int? firstNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Give me another number");
// int? secondNumber = int.Parse(Console.ReadLine());
// Console.WriteLine($"{(firstNumber == secondNumber ? (firstNumber + secondNumber) * 3 : firstNumber + secondNumber)}");

//*********************************************************************************************************************
// Basic - 20: Write a C# program to get the absolute value of the difference between two given numbers. 
// Return double the absolute value of the difference if the first number is greater than the second number. 

// Console.WriteLine("Give me a number");
// int? firstNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Give me another number");
// int? secondNumber = int.Parse(Console.ReadLine());
// Console.WriteLine($"{(firstNumber > secondNumber ? 2 * (firstNumber - secondNumber) : secondNumber - firstNumber)}");

//*********************************************************************************************************************
// Basic - 21: Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20 or if their sum is 20. 

// Console.WriteLine("Give me a number");
// int? firstNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Give me another number");
// int? secondNumber = int.Parse(Console.ReadLine());
// Console.WriteLine($"{firstNumber == 20 || secondNumber == 20 || firstNumber + secondNumber == 20}");

//*********************************************************************************************************************
// Basic - 22: Write a C# program to check if the given integer is within 20 of 100 or 200. 

// Console.WriteLine("Give me a number");
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine($"{Math.Abs((decimal) 100 - number) <= 20 || Math.Abs((decimal) 200 - number) <= 20}");

//*********************************************************************************************************************
// Basic - 23: Write a C# program to convert a given string into lowercase. 

// Console.WriteLine("String me up son");
// string? s = Console.ReadLine();
// Console.WriteLine($"{s.ToLower()}");

//*********************************************************************************************************************
// Basic - 24: Write a C# program to find the longest word in a string.

// Console.WriteLine("Give me a sentence");
// string? sentence = Console.ReadLine();
// var stringArray = sentence.Split(" ");
// string longestWord = stringArray[0];
// List<string> words = new List<string>();
// for (var i = 0 ; i < stringArray.Length ; i++)
// {
//     words.Add(stringArray[i]);
// }
// words.ForEach(delegate(string word)
// {
//     if (word.Length > longestWord.Length)
//     {
//         longestWord = word;
//     }
// });
// Console.WriteLine(longestWord);

//*********************************************************************************************************************
// Basic - 25: Write a C# program to print odd numbers from 1 to 99. Prints one number per line. 

// for (int i = 0 ; 2 * i <= 100 ; i++)
// {
//     Console.WriteLine(1 + (2 * i));
// }

//*********************************************************************************************************************
// Basic - 26: Write a C# program to compute the sum of the first 500 prime numbers. 

// var primes = new int[500];
// int count = 0;

// for (var i = 2 ; count < 500 ; i++)
// {
//     bool isPrime = true;
//     for (var j = 2 ; j * j < i ; j++)
//     {
//         if (i%j==0)
//         {
//             isPrime = false;
//         }
//     }
//     if (isPrime)
//     {
//         primes[count] = i;
//         count++;
//     }


// }
// int sum = 0;
// foreach (var prime in primes)
// {    
//     sum += prime;
// }
// Console.WriteLine(sum)

//*********************************************************************************************************************
// Basic - 27: Write a C# program and compute the sum of an integer's digits.

// int sum = 0;
// Console.WriteLine("Give me a number");
// int? num = int.Parse(Console.ReadLine());
// while (num > 0)
// {
//     sum  += (int)num % 10;
//     num /= 10;
// }
// Console.WriteLine("The sum of that number's digits is {0}", sum);

//*********************************************************************************************************************
// Basic - 28: Write a C# program to reverse the words of a sentence. 

// Console.WriteLine("Give me a sentence");
// string? sentence = Console.ReadLine();
// string reversedSentence = "";
// var words = sentence.Split(" ");
// var reversedWords = words.Reverse();
// foreach (var word in reversedWords)
// {
//     reversedSentence += word;
//     reversedSentence += " ";
// }
// Console.WriteLine("{0}", reversedSentence[..^1]);

//*********************************************************************************************************************
// Basic - 29: Write a C# program to find the size of a specified file in bytes.

// FileInfo file = new FileInfo("C:/Users/Isham/Desktop/C# Stuff/Learning/Exercises/Exercises/Exercises.csproj");
// Console.WriteLine("{0}", file.Length);

//*********************************************************************************************************************
// Basic - 30: Write a C# program to convert a hexadecimal number to a decimal number. 

// Console.WriteLine("Give me a number in hexadecimal");
// string num = Console.ReadLine();
// Console.WriteLine(num);
// num = num.ToUpper();
// int sum = 0;
// void fromHex(char hex)
// {
//     switch (hex)
//     {
//         case '1': sum += 1;
//         break;
//         case '2': sum += 2;
//         break;
//         case '3': sum += 3;
//         break;
//         case '4': sum += 4;
//         break;
//         case '5': sum += 5;
//         break;
//         case '6': sum += 5;
//         break;
//         case '7': sum += 6;
//         break;
//         case '8': sum += 7;
//         break;
//         case '9': sum += 9;
//         break;
//         case 'A': sum += 10;
//         break;
//         case 'B': sum += 11;
//         break;
//         case 'C': sum += 12;
//         break;
//         case 'D': sum += 13;
//         break;
//         case 'E': sum += 14;
//         break;
//         case 'F': sum += 15;
//         break;

//         default: Console.WriteLine("Invalid character detected");break;
//     };
// }
// var chars = num.ToCharArray();
// foreach (var digit in chars)
// {   
//     Console.WriteLine("Converting {0}", digit);
//     fromHex(digit);
// }
// Console.WriteLine(sum);

//*********************************************************************************************************************
// Basic - 31: Write a C# program to multiply the corresponding elements of two integer arrays. 

// int[] array1 = [1,3,-5,4];
// int[] array2 = [1,4,-5,-2];

// var productArray = new int[array1.Length];

// for (int i = 0 ; i < productArray.Length ; i++)
// {
//     productArray[i] = array1[i] * array2[i];
// }

// foreach(var prod in productArray)
// {
//     Console.Write("{0} ", prod);
// }

//*********************************************************************************************************************
// Basic - 32: Write a C# program to create a string of four copies, taking the last four characters from a given string. 
//             If the given string is less than 4, return the original one. 

// Console.Write("Give me a sentence: ");
// string? sentence = Console.ReadLine();
// int length = sentence.Length;
// string subString = sentence != null ? sentence.Length>=4 ? sentence.Substring(length-5) : sentence : "";
// for (int i = 0 ; i < 4 ; i++)
// {
//     Console.Write(subString);
// }

//*********************************************************************************************************************
// Basic - 33: Write a C# program to check if a given positive number is a multiple of 3 or 7. 

// Console.Write("Give me a positive number: ");
// int num = int.Parse(Console.ReadLine());
// if (num <= 0)
// {
//     Console.WriteLine("I said a positive number, dickhead");
// }
// else
// {
//     Console.WriteLine($"That number is {(num % 3 == 0 || num % 7 == 0 ? "" : "not " )}divisible by 3 or 7");
// }

//*********************************************************************************************************************
// Basic - 34: Write a C# program to check if a string starts with a specified word. 

// Console.Write("Give me a sentence: ");
// string? sentence = Console.ReadLine();
// Console.Write("Give me a word: ");
// string? word = Console.ReadLine();
// if (sentence != null && word != null)
// {
// string firstWord = sentence.Split(" ")[0];
// Console.WriteLine($"\"{word}\" {(firstWord == word ? "is" : "is not")} the first word of \"{sentence}\"");
// }

//*********************************************************************************************************************
// Basic - 35: Write a C# program to check two given numbers where one is less than 100 and the other is greater than 200. 

// Console.Write("Give me a number: ");
// int? firstNumber = int.Parse(Console.ReadLine());
// Console.Write("Give me another: ");
// int? secondNumber = int.Parse(Console.ReadLine());
// Console.WriteLine(firstNumber < 100 && secondNumber > 200);

//*********************************************************************************************************************
// Basic - 36: Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10. 

// Console.Write("Give me a number: ");
// int? firstNumber = int.Parse(Console.ReadLine());
// Console.Write("Give me another number: ");
// int? secondNumber = int.Parse(Console.ReadLine());
// Console.WriteLine((secondNumber > -10 && secondNumber < 10) || (firstNumber > -10 && firstNumber < 10));

//*********************************************************************************************************************
// Basic - 37: Write a C# program to check if "HP" appears at the second position in a string and return the string without "HP"

// Console.Write("Give me a string: ");
// string? s = Console.ReadLine();
// Console.WriteLine(s.Substring(1,2) == "HP");

//*********************************************************************************************************************
// Basic - 38: Write a C# program to get a string of two characters from a given string. 
//             The first and second characters of the given string must be "P" and "H", so PHP will be "PH". 

// Console.Write("Give me a string: ");
// string? s = Console.ReadLine();
// for (var i = 0 ; i < s.Length - 2 ; i++)
// {
//     if (s.Substring(i,2)=="PH"){
//         Console.WriteLine("PH");
//     }
// }

//*********************************************************************************************************************
// Basic - 39: Write a C# program to find the largest and lowest values from three integer values. 

// string[] greetings = ["Give me a number: ", "Give me another number: ", "Give me one last number: "];
// int[] numbers = new int[3];
// for (var i = 0 ; i < 3 ; i++)
// {
//     Console.Write(greetings[i]);
//     numbers[i] = int.Parse(Console.ReadLine());
// }
// Array.Sort(numbers);

// Console.WriteLine($"The highest number is {numbers[^1]} and the lowest is {numbers[0]}");

//*********************************************************************************************************************
// Basic - 40: Write a C# program that checks the nearest value of 20 of two given integers and return 0 if two numbers are same. 

// Console.Write("Give me a number: ");
// int? firstNumber = int.Parse(Console.ReadLine());
// Console.Write("Give me another number: ");
// int? secondNumber = int.Parse(Console.ReadLine());
// int first =  Math.Abs(int.Parse($"{20-firstNumber}"));
// int second = Math.Abs(int.Parse($"{20-secondNumber}"));
// Console.WriteLine($"{(first == second ? 0 : first > second ? secondNumber : firstNumber)}");

//*********************************************************************************************************************
// Basic - 41: Write a C# program to check if a given string contains the 'w' character between 1 and 3 times. 

// Console.Write("Give me a string: ");
// string? s = Console.ReadLine().ToLower();
// char[] letters = s != null ? s.ToCharArray() : "".ToCharArray();
// int count = 0;
// foreach (var letter in letters)
// {
//     if (letter == 'w')
//     {
//         count++;
//     }
// }
// Console.WriteLine(count >= 1 && count <= 3);

//*********************************************************************************************************************
// Basic - 42: Write a C# program to create a string where the first 4 characters are in lower case. If the string is less than 4 letters, make the whole string in upper case.

// Console.Write("Give me a string: ");
// string? s = Console.ReadLine();
// Console.WriteLine($"{(s.Length >= 4 ? s.Substring(0,4).ToLower() + s.Substring(4) : s.ToUpper() )}");

//*********************************************************************************************************************
// Basic - 43: Write a C# program to check if a given string starts with "w" and is immediately followed by two "ww". 

// Console.Write("Give me a string: ");
// string? s = Console.ReadLine();
// string www = "www";
// Console.WriteLine($"{s.Substring(0,3) == www}");

//*********************************************************************************************************************
// Basic - 44: Write a C# program to create a string of every other character (odd position) from the first position of a given string.

// Console.WriteLine("Give me a string: ");
// string? s = Console.ReadLine();
// var letters = s.ToCharArray();
// string odds = "";
// for (var i = 0 ; i < letters.Length ; i++)
// {
//     if (i%2==0)
//     {
//         odds += letters[i];
//     }
// }
// Console.WriteLine(odds);

//*********************************************************************************************************************
// Basic - 45: Write a C# program to count a specified number in a given array of integers. 

// var integers = new int[10];
// var rnd = new Random();
// string end = "\n";
// string mid = ", ";
// Console.WriteLine("For the following array: ");
// for (var i = 0 ; i < 10 ; i++)
// {
//     integers[i] = rnd.Next(1,10);
//     Console.Write($"{integers[i]}{(i==9 ? end : mid)}");
// }
// Console.Write("Give me an integer: ");
// int? num = int.Parse(Console.ReadLine());
// int count = 0;
// for (var i = 0 ; i < 10 ; i++)
// {
//     if (num == integers[i])
//     {
//         count++;
//     }
// }
// Console.WriteLine($"There are {count} instances of {num} in the array.");

//*********************************************************************************************************************
// Basic - 46: Write a C# program to check if a number appears as the first or last element of an array of integers. The array length is 1 or more.

// var integers = new int[10];
// var rnd = new Random();
// string end = "\n";
// string mid = ", ";
// Console.WriteLine("For the following array: ");
// for (var i = 0 ; i < 10 ; i++)
// {
//     integers[i] = rnd.Next(1,10);
//     Console.Write($"{integers[i]}{(i==9 ? end : mid)}");
// }
// Console.Write("Give me an integer: ");
// int? num = int.Parse(Console.ReadLine());
// string y = "is";
// string n = "is not";
// Console.WriteLine($"{num} {((integers[0] == num || integers[^1] == num) ? y : n)} the first or last integer in the array");

//*********************************************************************************************************************
// Basic - 47: Write a C# program to compute the sum of all the elements of an array of integers. 

// var integers = new int[10];
// var rnd = new Random();
// int sum = 0;
// Console.WriteLine("For the following array: ");
// for (var i = 0 ; i < 10 ; i++)
// {
//     integers[i] = rnd.Next(1,10);
//     Console.Write($"{integers[i]} ");
//     sum += integers[i];
// }
// Console.WriteLine($"\nThe sum is {sum}");

//*********************************************************************************************************************
// Basic - 48: Write a C# program that checks if the first element and the last element of an array of integers are equal. The array length is 1 or more.

// var integers = new int[10];
// var rnd = new Random();
// Console.WriteLine("For the following array: ");
// for (var i = 0 ; i < 10 ; i++)
// {
//     integers[i] = rnd.Next(1,10);
//     Console.Write($"{integers[i]} ");
// }
// Console.WriteLine(integers[0] == integers[^1]);

//*********************************************************************************************************************
// Basic - 49: Write a C# program to check if the first or the last element of the two arrays (length 1 or more) are equal.

// var array1 = new int[10];
// var array2 = new int[10];
// var rnd = new Random();
// Console.WriteLine("For the following array: ");
// for (var i = 0 ; i < 10 ; i++)
// {
//     array1[i] = rnd.Next(1,10);
//     array2[i] = rnd.Next(1,10);
// }
// Console.Write("The first array is: ");
// foreach (int num in array1 )
// {
//     Console.Write($"{num} ");
// }
// Console.Write("\nThe second array is: ");
// foreach (int num in array2 )
// {
//     Console.Write($"{num} ");
// }
// Console.Write("\n");
// if (array1[0] == array2[0] || array1[^1] == array2[^1])
// {
//     Console.WriteLine("The first or last entries in these arrays are the same");
// }
// else
// {
//     Console.WriteLine("The first and last entries in these arrays are different");
// }

//*********************************************************************************************************************
// Basic - 50: Write a C# program to rotate an array (length 3) of integers in the left direction. 

// var integers = new int[3];
// var rnd = new Random();
// Console.WriteLine("For the following array: ");
// for (var i = 0 ; i < 3 ; i++)
// {
//     integers[i] = rnd.Next(1,10);
//     Console.Write($"{integers[i]} ");
// }
// var rotatedIntegers = new int[3];
// for (var i = 0 ; i < 3 ; i++)
// {
//     rotatedIntegers[i] = integers[(i+1)%3];
// }
// Console.WriteLine("Rotation creates the following array: ");
// foreach (var num in rotatedIntegers)
// {
//     Console.Write($"{num} ");
// }

//*********************************************************************************************************************
// Basic - 51: Write a C# program to get the largest value between the first and last element of an array (length 3) of integers. 

// var integers = new int[5];
// var rnd = new Random();
// Console.WriteLine("For the following array: ");
// for (var i = 0 ; i < integers.Length ; i++)
// {
//     integers[i] = rnd.Next(1,10);
//     Console.Write($"{integers[i]} ");
// }
// Console.Write("\nThe higher of the first and last elements is: ");
// Console.WriteLine(Math.Max(integers[0], integers[4]));

//*********************************************************************************************************************
// Basic - 52: Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.

// var array1 = new int[3];
// var array2 = new int[3];
// var array3 = new int[3];
// var rnd = new Random();
// Console.WriteLine("For the following array: ");
// for (var i = 0 ; i < 3 ; i++)
// {
//     array1[i] = rnd.Next(1,10);
//     array2[i] = rnd.Next(1,10);
//     array3[i] = rnd.Next(1,10);
// }
// foreach (var num in array1)
// {
//     Console.Write($"{num} ");
// }
// Console.Write("\n");
// foreach (var num in array2)
// {
//     Console.Write($"{num} ");
// }
// Console.Write("\n");
// foreach (var num in array3)
// {
//     Console.Write($"{num} ");
// }
// Console.Write("\n");
// int[] middleArray = new int[3];
// middleArray[0] = array1[1];
// middleArray[1] = array2[1];
// middleArray[2] = array3[1];
// Console.WriteLine("The middle entries form the following array:");
// foreach (var num in middleArray)
// {
//     Console.Write($"{num} ");
// }

//*********************************************************************************************************************
// Basic - 53: Write a C# program to check if an array contains an odd number. 

//*********************************************************************************************************************
// Basic - 54: Write a C# program to get the century of a year. 

//*********************************************************************************************************************
// Basic - 55: Write a C# program to find the pair of adjacent elements that has the largest product of the given array. 

//*********************************************************************************************************************
// Basic - 56: Write a C# program to check if a given string is a palindrome or not. 

//*********************************************************************************************************************
// Basic - 57: Write a C# program to find the pair of adjacent elements that has the highest product of an array of integers. 

//*********************************************************************************************************************
// Basic - 58: Write a C# program that accepts a list of integers and checks how many integers are needed to complete the range. 

//*********************************************************************************************************************
// Basic - 59: Write a C# program to check whether it is possible to create a strictly increasing sequence from a given sequence of integers as an array.

//*********************************************************************************************************************
// Basic - 60: Write a C# program to calculate the sum of all integers in a rectangular matrix. However, exclude those integers located below an integer of value 0. 

//*********************************************************************************************************************
// Basic - 61: Write a C# program to sort the integers in ascending order without moving the number -5.

//*********************************************************************************************************************
// Basic - 62: Write a C# program to reverse the strings contained in each pair of matching parentheses in a given string. 
//             It should also remove the parentheses from the given string. 

//*********************************************************************************************************************
// Basic - 63: Write a C# program to check if a given number is present in an array of numbers.

//*********************************************************************************************************************
// Basic - 64: Write a C# Sharp program to get the file name (including extension) from a given path.

//*********************************************************************************************************************
// Basic - 65: Write a C# Sharp program to multiply all elements of a given array of numbers by array length. 

//*********************************************************************************************************************
// Basic - 66: Write a C# Sharp program to find the minimum value from two numbers given to you, represented as a string. 

//*********************************************************************************************************************
// Basic - 67: Write a C# Sharp program to create a coded string from a given string, using a specified formula.
//             Replace all 'P' with '9', 'T' with '0', 'S' with '1', 'H' with '6' and 'A' with '8'.

//*********************************************************************************************************************
// Basic - 68: Write a C# Sharp program to count a specified character (both cases) in a given string. 

//*********************************************************************************************************************
// Basic - 69: Write a C# Sharp program to check if a given string contains only lowercase or uppercase characters. 

//*********************************************************************************************************************
// Basic - 70: Write a C# Sharp program to remove the first and last elements from a given string. 

//*********************************************************************************************************************
// Basic - 71: Write a C# Sharp program to check if a given string contains two similar consecutive letters. 

//*********************************************************************************************************************
// Basic - 72: Write a C# Sharp program to check whether the average value of the elements of a given array of numbers is a whole number or not. 

//*********************************************************************************************************************
// Basic - 73: Write a C# Sharp program to convert the letters of a given string (same case-upper/lower) into alphabetical order. 

//*********************************************************************************************************************
// Basic - 74: Write a C# Sharp program to check the length of a given string is odd or even. Return 'Odd length' if the string length is odd 

//*********************************************************************************************************************
// Basic - 75: Write a C# Sharp program that takes a positive number and returns the nth odd number. 

//*********************************************************************************************************************
// Basic - 76: Write a C# Sharp program to get the ASCII value of a given character. 

//*********************************************************************************************************************
// Basic - 77: Write a C# Sharp program to check whether a word is plural or not. 

//*********************************************************************************************************************
// Basic - 78: Write a C# Sharp program to find the sum of squares of elements in a given array of integers. 

//*********************************************************************************************************************
// Basic - 79: Write a C# Sharp program to convert an integer to a string and a string to an integer. 

//*********************************************************************************************************************
// Basic - 80: Write a C# Sharp program to convert all the values of a given array of mixed values to string values. 

//*********************************************************************************************************************
// Basic - 81: Write a C# Sharp program to swap a two-digit number and check whether the given number is greater than its swap value.

//*********************************************************************************************************************
// Basic - 82: Write a C# Sharp program to remove all non-letter characters from a given string.

//*********************************************************************************************************************
// Basic - 83: Write a C# Sharp program to remove all vowels from a given string.

//*********************************************************************************************************************
// Basic - 84: Write a C# Sharp program to get the index number of all lower case letters in a given string.

//*********************************************************************************************************************
// Basic - 85: Write a C# Sharp program to find the cumulative sum of an array of numbers.

//*********************************************************************************************************************
// Basic - 86: Write a C# Sharp program to get the number of letters and digits in a given string.

//*********************************************************************************************************************
// Basic - 87: Write a C# Sharp program to reverse a Boolean value. 

//*********************************************************************************************************************
// Basic - 88: Write a C# Sharp program to find the sum of the interior angles (in degrees) of a given polygon. Input the number of straight lines. 

//*********************************************************************************************************************
// Basic - 89: Write a C# Sharp program to count positive and negative numbers in a given array of integers. 

//*********************************************************************************************************************
// Basic - 90: Write a C# Sharp program to count the number of ones and zeros in the binary representation of a given integer. 

//*********************************************************************************************************************
// Basic - 91: Write a C# Sharp program to remove all values except integer values from a given array of mixed values. 

//*********************************************************************************************************************
// Basic - 92: Write a C# Sharp program to find the next prime number of a given number. If the given number is a prime number, return the number. 

//*********************************************************************************************************************
// Basic - 93: Write a C# Sharp program to calculate the square root of a given number. Return the integer part of the result instead of using any built-in functions. 

//*********************************************************************************************************************
// Basic - 94: Write a C# program that finds the longest common prefix from an array of strings. 

//*********************************************************************************************************************
// Basic - 95: Write a C# programme to check the said string is valid or not. The input string will be valid when open brackets and closed brackets are same type of brackets. 

//*********************************************************************************************************************
// Basic - 96: Write a C# Sharp program to check whether all characters in a string are the same. Return true if all the characters in the string are the same, otherwise false. 

//*********************************************************************************************************************
// Basic - 97: Write a C# Sharp program to check if a given string (floating point and negative numbers included) is numeric or not. 
//             Return True if the string is numeric, otherwise false. 

//*********************************************************************************************************************
// Basic - 98: Write a C# Sharp program to create and display all prime numbers in strictly descending decimal digit order. 

//*********************************************************************************************************************
// Basic - 99: Write a C# Sharp program to create and display all prime numbers in strict ascending decimal digit order. 

//*********************************************************************************************************************
// Basic - 100: Write a C# Sharp program to check the equality comparison (value and type) of two parameters. Return true if they are equal otherwise false. 

//*********************************************************************************************************************
// Basic - 101: Write a C# Sharp program to calculate the value of e. Note: e is also known as Euler's number and Napier's constant

//*********************************************************************************************************************
// Basic - 102: Write a C# Sharp program to create an identity matrix.

//*********************************************************************************************************************
// Basic - 103: Write a C# Sharp program to sort characters in a given string (uppercase/lowercase letters and numbers). Return the newly sorted string.

//*********************************************************************************************************************
// Basic - 104: Write a C# Sharp program to compare the equality of three integers and calculate how many integers have the same value.
