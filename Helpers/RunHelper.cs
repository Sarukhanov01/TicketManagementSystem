using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagementSystem.Helpers
{
    class RunHelper
    {
        public enum ComparisonType
        {
            OR,
            ALL
        }
        // all hamsi duzduse true  || OR hamsi sehvdise false
        public static bool CheckValue(ComparisonType comparisonType, params object[] values)
        {
            bool checkIfValid = true;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] is String)
                {
                    checkIfValid = !String.IsNullOrEmpty(values[i].ToString());
                }
                else if (values[i] is int)
                {
                    checkIfValid = (int)values[i] > 0;
                }
                else if (values[i] != null)
                {
                    checkIfValid = true;
                }
                switch (comparisonType)
                {
                    case ComparisonType.OR:
                        if (!checkIfValid && i == values.Length - 1)
                        {
                            return false;
                        }       
                        break;
                    case ComparisonType.ALL:
                        if (!checkIfValid)
                        {
                            return false;
                        }
                        break;
                }

            }
            return checkIfValid;
        }
    }
}
