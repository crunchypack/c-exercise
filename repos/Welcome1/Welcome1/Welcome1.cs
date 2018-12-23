using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Welcome1{
    static void Main(string[] args){
        int ch;
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Comparison");
        Console.WriteLine("3. BMI Calculator");
        Console.WriteLine("0. Exit");

        Console.Write("Choose program: ");
        ch = Convert.ToInt32(Console.ReadLine());

        do
        {
            switch (ch)
            {
                case 1:
                    Welcome1.Add();
                    break;
                case 2:
                    Comparison();
                    break;
                case 3:
                    BMI();
                    break;
                default:
                    Console.WriteLine("No such program");
                    break;
            }
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Comparison");
            Console.WriteLine("3. BMI Calculator");
            Console.WriteLine("0. Exit");

            Console.Write("Choose program: ");
            ch = Convert.ToInt32(Console.ReadLine());
        } while (ch != 0);



    }//end Main
    public static void Add(){
        int n1;
        int n2;
        int sum;

        Console.Write("Enter first integer: "); // promt user
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second integer: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        sum = n1 + n2;

        Console.WriteLine("Sum is {0}", sum); // Display number
        

    }//End Add
    public static void Comparison(){
        int nr1;
        int nr2;
        Console.Write("Enter first integer: "); // promt user
        nr1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second integer: "); // promt user
        nr2 = Convert.ToInt32(Console.ReadLine());

        if (nr1 == nr2) Console.WriteLine("{0} == {1}", nr1, nr2);

        if (nr1 != nr2) Console.WriteLine("{0} != {1}", nr1, nr2);

        if (nr1 < nr2) Console.WriteLine("{0} < {1}", nr1, nr2);

        if (nr1 > nr2) Console.WriteLine("{0} > {1}", nr1, nr2);

        if (nr1 <= nr2) Console.WriteLine("{0} <= {1}", nr1, nr2);

        if (nr1 >= nr2) Console.WriteLine("{0} >= {1}", nr1, nr2);


    }//End Comparison

    public static void BMI() {
        double weight;
        double height;

        Console.Write("Enter your weight in KG: ");
        weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your height in Meters: ");
        height = Convert.ToDouble(Console.ReadLine());

        double BMI = Math.Round(weight / (height * height),1);
        if (BMI < 18.5) Console.WriteLine("You're underweight, your BMI = {0}", BMI);
        else if (BMI >= 18.5 && BMI <= 24.9) Console.WriteLine("Your weight is normal your BMI = {0}", BMI);
        else if (BMI >= 25 && BMI <= 29.9) Console.WriteLine("You're overweight, your BMI = {0}", BMI);
        else Console.WriteLine("You're obese, your BMI = {0}", BMI);

    }
}//End Class Welcome 1

