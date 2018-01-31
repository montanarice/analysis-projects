using System;
using System.Runtime.Serialization;

namespace QuamocoHelloWorldAllFindings
{
    /// <summary>
    /// Concrete class containing three methods that trigger
    /// three findings as defined by the Quamoco Quality Model:
    /// "helloworld.qm"
    /// </summary>
    [Serializable]
    public class FindingsCollectionException : Exception
    {
        /// <summary>
        /// S3693: Exception Constructor Throwing Exception
        /// This method shows as a Bug finding
        /// </summary>
        public FindingsCollectionException()
        {
            throw new Exception("A bad thing happened"); // Noncompliant
        }

        public FindingsCollectionException(string message)
          : base(message) { }

        public FindingsCollectionException(string message, Exception innerException)
            : base(message, innerException) { }

        protected FindingsCollectionException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }

        /// <summary>
        /// S134: Control Flow Statements Too Deeply Nested
        /// This method shows as a Code Smell - Brain Overload finding
        /// </summary>
        public static void S134Finding()
        {
            int first = 1;
            if (first == 1) // Compliant - depth = 1
            {
                int second = 2;
                if (second == 2) // Compliant - depth = 2
                {
                    int third = 3;
                    for (int i = 0; i < third; i++) // Compliant - depth = 3, not exceeding the limit
                    {
                        int fourth = 4;
                        if (fourth == 4) // Noncompliant - depth = 4
                        {
                            return;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// S1067: Expressions should not be too complex.
        /// This method shows as a Code Smell - Brain Overload finding
        /// </summary>
        public static void S1067Finding()
        {
            bool condition1 = true;
            bool condition2 = true;
            bool condition3 = false;
            bool condition4 = true;
            bool condition5 = true;

            if (((condition1 && condition2) || (condition3 && condition4)) && condition5)
            {
                // Do nothing
            }
        }
    }
}
