
using System;

public class LabOne
{
    enum Color
    {
        black,    // 0
        brown,   // 1
        red,      // 2
        orange,      // 3
        yellow,        // 4
        green,       // 5
        blue,        // 6
        violet,        // 7
        grey,        // 8
        white,        // 9
    }
    public static void Main(string[] args)
    {
        string colorVar;

        Console.Write("Please input a color... ");
        //read input
        colorVar = Console.ReadLine();

        //initialize array method
        string[] colors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

        for (int i = 0; i < colors.Length; i++)
        {
            if (colorVar == colors[i])
            {
                Console.Write("Array Resistor code: " + colorVar + " ");
                Console.WriteLine(i.ToString());
            }
        }
        
        //initialize ENUM method.
        if (colorVar == "black")
        {
            Console.Write("Enum Resistor code: " + colorVar + " ");
            int myNum = (int)Color.black;
            Console.WriteLine(myNum);
        }
        if (colorVar == "brown")
        {
            Console.Write("Enum Resistor code: " + colorVar + " ");
            int myNum = (int)Color.brown;
            Console.WriteLine(myNum);
        }
        if (colorVar == "red")
        {
            Console.Write("Enum Resistor code: " + colorVar + " ");
            int myNum = (int)Color.red;
            Console.WriteLine(myNum);
        }
        if (colorVar == "orange")
        {
            Console.Write("Enum Resistor code: " + colorVar + " ");
            int myNum = (int)Color.orange;
            Console.WriteLine(myNum);
        }
        if (colorVar == "yellow")
        {
            Console.Write("Enum Resistor code: " + colorVar + " ");
            int myNum = (int)Color.yellow;
            Console.WriteLine(myNum);
        }
        if (colorVar == "green")
        {
            Console.Write("Enum Resistor code: " + colorVar + " ");
            int myNum = (int)Color.green;
            Console.WriteLine(myNum);
        }
        if (colorVar == "blue")
        {
            Console.Write("Enum Resistor code: " + colorVar + " ");
            int myNum = (int)Color.blue;
            Console.WriteLine(myNum);
        }
        if (colorVar == "violet")
        {
            Console.Write("Enum Resistor code: " + colorVar);
            int myNum = (int)Color.violet;
            Console.WriteLine(myNum);
        }
        if (colorVar == "grey")
        {
            Console.Write("Enum Resistor code: " + colorVar);
            int myNum = (int)Color.grey;
            Console.WriteLine(myNum);
        }
        if (colorVar == "white")
        {
            Console.Write("Enum Resistor code: " + colorVar);
            int myNum = (int)Color.white;
            Console.WriteLine(myNum);
        }
    }
}
