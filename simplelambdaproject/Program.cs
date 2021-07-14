using System;

namespace simplelambdaproject
{
    class Program
    {
        //Variables
        delegate void myDelegate(int a, int b);
        static myDelegate MyDelegate;

        static void Main(string[] args)
        {
            //Lambda expression
            MyDelegate = (num1, num2) =>
            {
                //Result is adding the value of 'a' 2 times aswell with the 'b'
                var result = (num1 + num1) + (num2 + num2);
                Console.WriteLine(result);
            };
            
            //a is set to 5 and b is set to 10.
            MyDelegate(5, 10);

            //to make sure the console doesnt close unless a key is pressed
            Console.ReadKey();
        }
    }
}
