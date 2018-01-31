using System;

namespace QuamocoHelloWorldAllFindings
{
    public class FindingsCollection : Exception
    {
        /// <summary>
        /// S134: Control Flow Statements Too Deeply Nested
        /// This method shows as a Code Smell - Brain Overload finding
        /// </summary>
        public void S134Finding()
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
                            bool fifth = true;
                            if (fifth) // Depth = 5, exceeding the limit, but issues are only reported on depth = 4
                            {
                                Console.WriteLine("Reached too nested control flow.");
                                Console.WriteLine("Finished running S134Finding()");
                            }
                            return;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// S3693: Exception Constructor Throwing Exception
        /// This method shows as a Bug finding
        /// </summary>
        public void S3693Finding()
        {
            bool exception_thing = true;
            if (exception_thing)
            {
                try
                {
                    throw new InvalidCastException("An exception thing happened"); // Noncompliant
                }
                catch (InvalidCastException)
                {
                    // Do nothing
                }
            }
            Console.WriteLine("Finished running S3693Finding()");
        }

        /// <summary>
        /// S1067: Expressions should not be too complex.
        /// This method shows as a Code Smell - Brain Overload finding
        /// </summary>
        public void S1067Finding()
        {
            bool condition1 = true;
            bool condition2 = true;
            bool condition3 = false;
            bool condition4 = true;
            bool condition5 = true;

            if (((condition1 && condition2) || (condition3 && condition4)) && condition5)
            {
                Console.WriteLine("Entered overly complex expression.");
            }
            Console.WriteLine("Finished running S1067Finding()");
        }
    }
}
