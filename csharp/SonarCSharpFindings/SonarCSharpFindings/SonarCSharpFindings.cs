using System;

namespace SonarCSharpFindings
{
    public class SonarCSharpFindings
    {
        public static void Main(string[] args)
        {
            FindingsCollection findings = new FindingsCollection();
            findings.S134Finding();
            findings.S2757Finding();
            findings.S3420Finding();
        }
    }
}
