﻿string[] students = {"Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily"};
Console.WriteLine("Enter a name’s student:");
string input_name =Convert.ToString(Console.ReadLine());
bool check = false;

for (int i = 0; i < students.Length; i++)
 {
     if (students[i]==input_name)
     {
          Console.WriteLine("Position of the students in the list " + input_name + " is: " + (i + 1));
          check =true;
          break;
     }
}
if (!check)
{
    Console.WriteLine("Not found " + input_name + " in the list.");
}
