using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

public class arithmatic

{
    public static void main(string[] args)
    {
        int num1, num2, operat, result;

        Console.Write("Enter first number: "); 
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter SECOND number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter operator number as 1/2/3/4: ");
        operat = Convert.ToInt32(Console.ReadLine());

        if (operat == 1)
        {
            result = num1 + num2;
            Console.Write("addition: ", result);
        }
        
        else if(operat == 2)
        {
            result = num1 - num2;
            Console.Write("subtract: ", result);
        }

        else if (operat == 3)
        {
            result = num1 * num2;
            Console.Write("multiply: ", result);
        }
        
        else if(operat == 4)
        {
            result = (num1 / num2);
            Console.Write("divide: ", result);
        }

        else
        {
            Console.Write("Wrong operator used");
        }
        Console.ReadLine();
    }
}




