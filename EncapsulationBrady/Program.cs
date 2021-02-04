//Big O: O(1)
/**************************************************************
* Name        : EncapsulationBrady
* Author      : Kabrina Brady
* Created     : 1/19/2021
* Course      : Data Structures
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access to
* my program.         
***************************************************************/

using System;

namespace EncapsulationBrady
{
    class Program
    {
        static void Main(string[] args)
        {
            CanBrady can = new CanBrady
            {
                Company = "Field Day",
                Content = "Black Beans",
                Size = 13.0,
                Price = 0.99
            };

            CanBrady can2 = new CanBrady
            {
                Company = "S&W",
                Content = "Peaches",
                Size = 12.0,
                Price = 2.39
            };

            CanBrady can3 = new CanBrady
            {
                Company = "Green Giant",
                Content = "Green Beans",
                Size = 11.9,
                Price = 1.79
            };

            CanBrady can4 = new CanBrady
            {
                Company = "Del Monte",
                Content = "Creamed Corn",
                Size = 13.4,
                Price = 2.49
            };

            can.DisplayCan();
            can2.DisplayCan();
            can3.DisplayCan();
            can4.DisplayCan();
        }
    }
}
