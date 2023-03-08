/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    // Get the current date and time
    DateTime now = DateTime.Now;
    
    // Extract the components you want to store
    int month = now.Month;  // 1 byte
    int date = now.Day;     // 1 byte
    int year = now.Year % 100;  // 1 byte (only last 2 digits)
    int hours = now.Hour;   // 1 byte
    int minutes = now.Minute;  // 1 byte
    
    Console.WriteLine(month);
    Console.WriteLine(date);
    Console.WriteLine(year);
    Console.WriteLine(hours);
    Console.WriteLine(minutes);
    
    // month = 12;
    // // Pack the components into a single 32-bit integer
    // add zero's to the right
    int packedDateTime = (month << 28) | (date << 20) | (year << 12) | (hours << 6) | minutes; 
    
    // int packedDateTime = 50861852;
    Console.WriteLine(packedDateTime);
    // // To unpack the packedDateTime back to its individual components:
    month = (packedDateTime >> 28) & 0x0F;
    date = (packedDateTime >> 20) & 0xFF;
    year = (packedDateTime >> 12) & 0xFF;
    hours = (packedDateTime >> 6) & 0x3F;
    minutes = packedDateTime & 0x3F;

    Console.WriteLine(month);
    Console.WriteLine(date);
    Console.WriteLine(year);
    Console.WriteLine(hours);
    Console.WriteLine(minutes);
  }
}
