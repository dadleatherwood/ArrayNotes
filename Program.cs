using System;

namespace ArrayNotes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var numbers = new [] { 3, 5, 7, 6, 2, 9 };

            //Length
            Console.WriteLine("The length of numbers is " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("The index of 9 is: " + index);

            //Clear
            Array.Clear(numbers, 0, 2);
                 Console.WriteLine("The effect of the Clear(): ");
                 foreach (var num in numbers) 
                   Console.WriteLine(num);


            //Copy
            var another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("The effect of the Copy():" );
            foreach (var num in another)
                Console.WriteLine(num);

            //Sort 
            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort()");
            foreach(var num in numbers)
                Console.WriteLine(num);

            //Reverse
            Array.Reverse(numbers);


	        Console.WriteLine("Effect of Reverse()");
			foreach (var num in numbers)
				Console.WriteLine(num);



        }
    }
}
