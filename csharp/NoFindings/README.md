# Analysis Projects - C# - NoFindings

Run SonarQube C# analaysis on this project to have no bugs, vulnerabilities, or code smells appear as issues using the 'Sonar Way' Quality Profile. Remove the rule 'Track lack of copyright and license headers' from the Sonar Way rules before running analysis.

To run sonar scanning on C# projects:
```bash
SonarQube.Scanner.MSBuild.exe begin /k:"org.sonarqube:sonarqube-scanner-msbuild" /n:"Project Name" /v:"1.0"
MSBuild.exe /t:Rebuild
SonarQube.Scanner.MSBuild.exe end
```

[See the SonarQube documentation for more information on scanning and running analysis for C#](https://docs.sonarqube.org/pages/viewpage.action?pageId=8520120)