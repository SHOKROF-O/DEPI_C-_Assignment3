using System;

class Program
{
    static void Main()
    {

    }

    // Q1: check if a number is divisible by 3 and 4
    static void Q1()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 3 == 0 && num % 4 == 0)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }

    // Q2: positive or negative
    static void Q2()
    {
        Console.Write("Enter an integer: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num < 0)
            Console.WriteLine("negative");
        else
            Console.WriteLine("positive");
    }

    // Q3: max and min of 3 numbers
    static void Q3()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;

        int min = a;
        if (b < min) min = b;
        if (c < min) min = c;

        Console.WriteLine("max element = " + max);
        Console.WriteLine("min element = " + min);
    }

    // Q4: even or odd
    static void Q4()
    {
        Console.Write("Enter an integer: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
    }

    // Q5: vowel or consonant
    static void Q5()
    {
        Console.Write("Enter a character: ");
        char ch = Convert.ToChar(Console.ReadLine());
        ch = char.ToLower(ch);

        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            Console.WriteLine("vowel");
        else
            Console.WriteLine("Consonant");
    }

    // Q6: print numbers from 1 to n
    static void Q6()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i < n)
                Console.Write(i + ", ");
            else
                Console.Write(i);
        }
    }

    // Q7: multiplication table up to 12
    static void Q7()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 12; i++)
        {
            Console.Write((n * i) + " ");
        }
    }

    // Q8: even numbers from 1 to n
    static void Q8()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i <= n; i += 2)
        {
            Console.Write(i + " ");
        }
    }

    // Q9: power of a number using loop
    static void Q9()
    {
        Console.Write("Enter the base: ");
        int baseNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the power: ");
        int power = Convert.ToInt32(Console.ReadLine());

        int result = 1;
        for (int i = 1; i <= power; i++)
        {
            result *= baseNum;
        }

        Console.WriteLine("Result = " + result);
    }

    // Q10: total, average and percentage of 5 subjects
    static void Q10()
    {
        Console.Write("Enter Marks of five subjects: ");
        string[] marksInput = Console.ReadLine().Split(' ');

        int total = 0;
        for (int i = 0; i < 5; i++)
        {
            total += Convert.ToInt32(marksInput[i]);
        }

        double average = total / 5.0;
        double percentage = (total / 500.0) * 100;

        Console.WriteLine("Total marks = " + total);
        Console.WriteLine("Average Marks = " + average);
        Console.WriteLine("Percentage = " + percentage);
    }

    // Q11: number of days in a month
    static void Q11()
    {
        Console.Write("Enter Month Number: ");
        int month = Convert.ToInt32(Console.ReadLine());
        int days = 0;

        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                days = 31;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                days = 30;
                break;
            case 2:
                days = 28;
                break;
            default:
                Console.WriteLine("Invalid month");
                return;
        }

        Console.WriteLine("Days in Month: " + days);
    }

    // Q12: simple calculator
    static void Q12()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter operator (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;
        switch (op)
        {
            case '+': result = num1 + num2; break;
            case '-': result = num1 - num2; break;
            case '*': result = num1 * num2; break;
            case '/': result = num1 / num2; break;
            default:
                Console.WriteLine("Invalid operator");
                return;
        }

        Console.WriteLine("Result = " + result);
    }

    // Q13: reverse a string
    static void Q13()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        string reversed = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversed += str[i];
        }

        Console.WriteLine("Reversed: " + reversed);
    }

    // Q14: reverse an integer
    static void Q14()
    {
        Console.Write("Enter an integer: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int reversed = 0;

        while (num != 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }

        Console.WriteLine("Reversed: " + reversed);
    }

    // Q15: prime numbers within a range
    static void Q15()
    {
        Console.Write("Input starting number of range: ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input ending number of range: ");
        int end = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The prime numbers between " + start + " and " + end + " are:");

        for (int num = start; num <= end; num++)
        {
            if (num < 2) continue;

            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.Write(num + " ");
        }
    }

    // Q16: decimal to binary without using an array
    static void Q16()
    {
        Console.Write("Enter a number to convert: ");
        int num = Convert.ToInt32(Console.ReadLine());
        string binary = "";

        if (num == 0)
            binary = "0";

        while (num > 0)
        {
            int remainder = num % 2;
            binary = remainder + binary;
            num /= 2;
        }

        Console.WriteLine("The Binary is " + binary);
    }

    // Q17: check if 3 points lie on one straight line
    static void Q17()
    {
        Console.Write("Enter x1 y1: ");
        string[] p1 = Console.ReadLine().Split(' ');
        Point point1 = new Point(Convert.ToDouble(p1[0]), Convert.ToDouble(p1[1]));

        Console.Write("Enter x2 y2: ");
        string[] p2 = Console.ReadLine().Split(' ');
        Point point2 = new Point(Convert.ToDouble(p2[0]), Convert.ToDouble(p2[1]));

        Console.Write("Enter x3 y3: ");
        string[] p3 = Console.ReadLine().Split(' ');
        Point point3 = new Point(Convert.ToDouble(p3[0]), Convert.ToDouble(p3[1]));

        if (Point.IsCollinear(point1, point2, point3))
            Console.WriteLine("The points are on a single straight line");
        else
            Console.WriteLine("The points are NOT on a single straight line");
    }

    // Q18: worker efficiency based on time
    static void Q18()
    {
        Console.Write("Enter time taken (hours): ");
        double time = Convert.ToDouble(Console.ReadLine());

        if (time >= 2 && time <= 3)
            Console.WriteLine("Highly efficient");
        else if (time > 3 && time <= 4)
            Console.WriteLine("Increase your speed");
        else if (time > 4 && time <= 5)
            Console.WriteLine("Training needed");
        else if (time > 5)
            Console.WriteLine("Leave the company");
        else
            Console.WriteLine("Invalid time");
    }

    // Q19: identity matrix n x n
    static void Q19()
    {
        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                    Console.Write("1 ");
                else
                    Console.Write("0 ");
            }
            Console.WriteLine();
        }
    }

    // Q20: sum of all elements of an array
    static void Q20()
    {
        Console.Write("Enter array size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];

        Console.WriteLine("Enter " + size + " elements:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;
        for (int i = 0; i < size; i++)
        {
            sum += arr[i];
        }

        Console.WriteLine("Sum = " + sum);
    }

    // Q21: merge two sorted arrays of the same size
    static void Q21()
    {
        Console.Write("Enter array size: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr1 = new int[size];
        Console.WriteLine("Enter elements of first array (sorted):");
        for (int i = 0; i < size; i++)
            arr1[i] = Convert.ToInt32(Console.ReadLine());

        int[] arr2 = new int[size];
        Console.WriteLine("Enter elements of second array (sorted):");
        for (int i = 0; i < size; i++)
            arr2[i] = Convert.ToInt32(Console.ReadLine());

        int[] merged = new int[size * 2];
        int x = 0, y = 0, k = 0;

        while (x < size && y < size)
        {
            if (arr1[x] <= arr2[y])
                merged[k++] = arr1[x++];
            else
                merged[k++] = arr2[y++];
        }
        while (x < size) merged[k++] = arr1[x++];
        while (y < size) merged[k++] = arr2[y++];

        Console.WriteLine("Merged array:");
        foreach (int val in merged)
            Console.Write(val + " ");
    }

    // Q22: frequency of each element in an array
    static void Q22()
    {
        Console.Write("Enter array size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];

        Console.WriteLine("Enter " + size + " elements:");
        for (int i = 0; i < size; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        bool[] counted = new bool[size];

        for (int i = 0; i < size; i++)
        {
            if (counted[i]) continue;

            int count = 1;
            for (int j = i + 1; j < size; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    counted[j] = true;
                }
            }

            Console.WriteLine(arr[i] + " occurs " + count + " times");
        }
    }

    // Q23: max and min element in an array
    static void Q23()
    {
        Console.Write("Enter array size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];

        Console.WriteLine("Enter " + size + " elements:");
        for (int i = 0; i < size; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        int max = arr[0], min = arr[0];
        for (int i = 1; i < size; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }

        Console.WriteLine("Max = " + max);
        Console.WriteLine("Min = " + min);
    }

    // Q24: second largest element in an array
    static void Q24()
    {
        Console.Write("Enter array size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];

        Console.WriteLine("Enter " + size + " elements:");
        for (int i = 0; i < size; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        int first = int.MinValue, second = int.MinValue;
        for (int i = 0; i < size; i++)
        {
            if (arr[i] > first)
            {
                second = first;
                first = arr[i];
            }
            else if (arr[i] > second && arr[i] != first)
            {
                second = arr[i];
            }
        }

        Console.WriteLine("Second largest = " + second);
    }

    // Q25: longest distance between two equal cells
    static void Q25()
    {
        Console.Write("Enter array size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];

        Console.WriteLine("Enter " + size + " elements:");
        for (int i = 0; i < size; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        int maxDistance = 0;
        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (arr[i] == arr[j])
                {
                    int distance = j - i - 1;
                    if (distance > maxDistance)
                        maxDistance = distance;
                }
            }
        }

        Console.WriteLine("Longest distance = " + maxDistance);
    }

    // Q26: reverse the order of words in a sentence
    static void Q26()
    {
        Console.Write("Enter words: ");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');

        string result = "";
        for (int i = words.Length - 1; i >= 0; i--)
        {
            result += words[i];
            if (i != 0)
                result += " ";
        }

        Console.WriteLine(result);
    }

    // Q27: copy a 2D array into another one and print it
    static void Q27()
    {
        Console.Write("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] arr1 = new int[rows, cols];

        Console.WriteLine("Enter elements of the array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int[,] arr2 = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr2[i, j] = arr1[i, j];
            }
        }

        Console.WriteLine("Second array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arr2[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Q28: print a 1D array in reverse order
    static void Q28()
    {
        Console.Write("Enter array size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];

        Console.WriteLine("Enter " + size + " elements:");
        for (int i = 0; i < size; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Array in reverse order:");
        for (int i = size - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
