/* 
Josh Bartlett
20July2019
Assignment 5.3
Declare several Shirt objects and includes a display method to which you 
can pass different numbers of Shirt objects in successive method calls.  
The Shirt class contains auto-implemented properties for a material, color, and size.
*/

using System;
using static System.Console;

class ShirtDemo
{
    static void Main()
    {
        // create 6 shirt objects
        Shirt shirt1 = new Shirt();
        shirt1.Material = "polyester";
        shirt1.Color = "red";
        shirt1.Size = "small";

        Shirt shirt2 = new Shirt();
        shirt2.Material = "cotton";
        shirt2.Color = "blue";
        shirt2.Size = "medium";

        Shirt shirt3 = new Shirt();
        shirt3.Material = "satin";
        shirt3.Color = "green";
        shirt3.Size = "large";

        Shirt shirt4 = new Shirt();
        shirt4.Material = "silk";
        shirt4.Color = "white";
        shirt4.Size = "small";

        Shirt shirt5 = new Shirt();
        shirt5.Material = "linen";
        shirt5.Color = "black";
        shirt5.Size = "medium";

        Shirt shirt6 = new Shirt();
        shirt6.Material = "denim";
        shirt6.Color = "blue";
        shirt6.Size = "large";

        Shirt[] shirts;
        // add 1 shirt object to an array and call display method
        shirts = new Shirt[1]{shirt1};
        Display(shirts);
        WriteLine();
        // add 3 shirt objects to an array and call display method
        shirts = new Shirt[3]{shirt2, shirt3, shirt4};
        Display(shirts);
        WriteLine();
        // add 6 shirt objects to an array and call display method
        shirts = new Shirt[6]{shirt5, shirt6, shirt1, shirt2, shirt3, shirt4};
        Display(shirts);
        // Console stays open until key is pressed 
        ReadKey(true);
    }
    // Display method accepts Shirt array
    static void Display(Shirt[] shirts)
    {
        // I added a count to add a number to the displayed shirt's properties
        int count = 1;
        // loop through shirts array and displays the properties of each shirt
        foreach (Shirt shirt in shirts)
        {
            WriteLine("Shirt {0}: Material {1}, Color {2}, Size {3}", count, shirt.Material, shirt.Color, shirt.Size);
            count ++;
        }
    }
}
// Shirt class that contains auto-implemetation for the proterties 
class Shirt
{
    public string Material { get; set; }
    public string Color { get; set; }
    public string Size { get; set; }
}