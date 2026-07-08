using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface
{
    internal interface ITracable
    {
        void StartTracking()
        {
            Console.WriteLine("Tracking started");
        }

        void StopTracking();
    }
}
