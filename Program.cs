using System;

namespace wages_for_month
{
    class Program
    {
             public const int isPartTime = 1;
             public const int isFullTime = 2;
             public const int empRatePerHour = 20;
             public const int numOfWorkingDays = 20;

        static void Main(string[] args)
        {
            int empHrs = 0, empWage = 0, totalempWage = 0;
            for (int day = 0; day <= numOfWorkingDays; day++) 
            {
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case isPartTime:
                        empHrs = 4;
                        break;
                    case isFullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * empRatePerHour;
                totalempWage += empWage;
                Console.WriteLine("empWage : " + empWage );
            }
            Console.WriteLine("totalEmpWage :" + totalempWage );
        }
    }
}

    


        
    

