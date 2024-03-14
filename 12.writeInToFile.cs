using System;
using System.IO;

namespace LabReport_Csit_SijanKarki
{
    class Program
    {
        static void Main()
        {
            // Get input from the keyboard
            Console.Write("Enter text to write to the file: ");
            string inputText = Console.ReadLine();

            // Specify the file path (you can change the path as needed)
            string filePath = "D:\\TestFile.txt";

            // Write the input to the file
            WriteToFile(filePath, inputText);

            Console.WriteLine("Data has been written to the file successfully.");
             Console.WriteLine("\n Lab NO :8'c'");
            Console.WriteLine(" Name : Sijan Karki");
            Console.WriteLine(" Roll No:28");
        }

        static void WriteToFile(string filePath, string content)
        {
            try
            {
                // Use File.WriteAllText to write content to the file in one line
                File.WriteAllText(filePath, content);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
           
        }
    }
}
