using System;

namespace QuamocoHelloWorldAllFindings
{
    /// <summary>
    /// Project that triggers 3 findings according to the Quamoco
    /// Hello World quality model.
    /// </summary>
    public static class QuamocoHelloWorldAllFindings
    {
        /// <summary>
        /// Run the three static methods of FindingsCollectionException class
        /// that generate the three findings.
        /// </summary>
        public static void Main(String[] args)
        {
            FindingsCollectionException.S134Finding();
            FindingsCollectionException.S1067Finding();
        }
    }
}
