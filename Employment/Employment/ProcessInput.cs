using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employment
{
    public class ProcessInput
    {
        public string ProcessMessage(int value)
        {
            if (value == 1)
            {
                return "List of Employees";
            }

            else if (value == 2)
            {
                return "Adding 5% of Salary to pension fund";
            }
            else

            {
                return "This is not a valid input. Please select either 1 or 2";
            }
        }
    }
}
