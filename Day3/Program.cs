namespace Day3
{
     class Program
    {
        static void Main()
        {
            //string s1 = "hello there";
            //string s2 = s1;
            //s1 = "joonguini";
            //Console.WriteLine("s1 value :" +s1);
            //Console.WriteLine("s1 value :" + s1.GetHashCode());
                                                                 
            //Console.WriteLine("s2 value :" + s2);
            //Console.WriteLine("s2 value :" + s2.GetHashCode());
            int x = 10;

            string re = (x%2 == 0) ? "Is even number " : "Is odd Number "; // if the number is can divided by 2  and the result =0 it will be even number if not will be odd number ( the result  after divided =1)
            Console.WriteLine(re);


            //---------------------------------------
            string s1 = "hello", s2 = "Khloud";
            Console.WriteLine($"s1 value : {s1} \nThe s2 value=  {s2}");

            //-------------------
            /* create a program the will if the num is divisible by 3 or not if 
             * if divisible print divisible 
             if not print not divisible*/
            int y = 10;

            string de = (y % 3 == 0) ? "Is divisible number " : "Is not divisible Number "; // if the number is can divided by 3   if not will be not divisible number ( the result  after divided =1)
            Console.WriteLine(de);


            //------------------------------------------
            int w = 1, h = 1;
            // postfix ==> 
            Console.WriteLine("Increment with postfix");
            Console.WriteLine(w++);
            Console.WriteLine(w);


            // postfix ==> 
            Console.WriteLine("Increment with prefix");
            Console.WriteLine(++h);
            Console.WriteLine(h);
        }
    }
}