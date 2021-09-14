using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ka tevi sauc?");

            string userName = Console.ReadLine();

            Console.WriteLine("Sveiks, " + userName);


            //---------------------------------------------------------


            
            

            Console.WriteLine("Kads ir tavs vecums?");
            string ageText = Console.ReadLine();
            int age = int.Parse(ageText);
            int nextYearAge = age + 1;

            Console.WriteLine("Nakamgad tev paliks " + nextYearAge + ", Tu esi pilngadigs");



            //--------------------------------------------------------

            Console.WriteLine("===================================================");

            int maxNumber4 = 9;
            int maxNumber5 = 20;

            int maxResult = Math.Max(maxNumber4, maxNumber5);

            Console.WriteLine(maxResult);


            //------------------------------------------------------

            Console.WriteLine("=====================================================");

            int minNumber6 = 15;
            int maxNumber7 = 30;

            int minResult = Math.Min(minNumber6, maxNumber7);

            Console.WriteLine(minResult);


            //------------------------------------------------------

            Console.WriteLine("===================================================");

            int divisionremainder3 = 16;

            int divisionremainder4 = 4;

            int divisionremainderResult = divisionremainder3 % divisionremainder4;

            Console.WriteLine(divisionremainderResult);


            //-----------------------------------------------------


            

          
            



            







                

         




           












            



            







        }


        
    }
}
