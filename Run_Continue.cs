// Run/Continue Program Shell Snippet for C#
// Author: Justin P. Dickerson ©2018

using System.Text.RegularExpressions; // Important! Insert statement above the namespace!!!!

/* 
Instructions on how to use Snippet

Complete Shell: Program Start, Validated Continue, and Manual Exit and Close with customizable User Input Prompts (UIPs) 
1)Copy & Paste the snippet below outside the Main method but within the class Program
2)Then call inside the Main method the RunProgram & ContinueProgram methods in the following order: RunProgram(); ContinueProgram();

OOP Additions: Do this when engaging in OOP!
3) Pass instantiated variable name from the Main method into the RunProgram and ContinueProgram methods located in the Main method
4) Pass instantiated variable name and type from the Main method into RunProgram and ContinueProgram methods

Customization: 
1) Console.WriteLine() strings can be customized to fit the needs of the program
2) Code (Particularly non OOP in nature) should go into the RunProgram method under the Console.WriteLine(Input), however it is not necessary
3) Related method calls should go into the RunProgram method, however not required
4) Custom Methods need to be created outside of the Main, RunProgram, and ContinueProgram methods yet inside the Program class

Developer Note: Snippet contains no recursion
 */	
 
	public static void RunProgram()
	{
        Console.WriteLine("Enter Custom Text Here");
        string Input = Console.ReadLine();
        Console.WriteLine($"Enter Custom Text Here {Input}");
		
		// Code
		// Method calls
	}
	public static void ContinueProgram()
    {
        Console.WriteLine("Enter Custom Text Here? Y/N");
        string Continue = Console.ReadLine();

        while (Regex.Match(Continue, @"^[Y|y]$").Success)
        {
            RunProgram();
            Continue = "";
            Console.WriteLine("Enter Custom Text Here? Y/N");
            Continue = Console.ReadLine();
        }
			Console.WriteLine("Enter Custom Text Here");
            Console.ReadLine();
    }