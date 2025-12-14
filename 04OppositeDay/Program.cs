using System;

class Program
{
    static void Main()
    {
        bool todayIsOppositeDay = true;
        bool sayItIsOppositeDay;

        if(todayIsOppositeDay == true)
        {
            sayItIsOppositeDay = true;
        }
        else
        {
           sayItIsOppositeDay = false; 
        }
        
        //if today_is_opposite_day is set to True the code will be Toggle(opposite Boolean Value)
        if(todayIsOppositeDay == true)
        {
            sayItIsOppositeDay =! sayItIsOppositeDay; 
            //sayItIsOpposite = false;
        }
        
        
        if(sayItIsOppositeDay == true)
        {
           Console.WriteLine("Today is opposite day"); 
        }
        else
        {
            Console.WriteLine("Today is not opposite day");
        }
    }
}