using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarCSharpFindings
{
    class FindingsCollection
    {
        /// <summary>
        /// S134:
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
        /// S2757: "=+" should not be used instead of "+="
        /// </summary>
        public void S2757Finding()
        {
            int target = -5;
            int num = 3;

            target = -num;  // Noncompliant; target = -3. Is that really what's meant?
            target = +num; // Noncompliant; target = 3

            Console.WriteLine("Finished running S2757Finding()");
        }
    }
}
