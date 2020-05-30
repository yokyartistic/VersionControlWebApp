
//*****************************************************************************
// Programmer: Kamolchanok Pornleesangsuwan
// Date: 24 May 2020
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64­bit
// Purpose: A2_Implement_a_comparator
// Adapted from https://www.jonasjohn.de/snippets/csharp/drag­anddrop­example.htm
//
//*****************************************************************************


using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2_Implement_a_comparator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public class ReverserClass : IComparer
        {
            // Call CaseInsensitiveComparer.Compare with the parameters reversed.
            int IComparer.Compare(Object x, Object y)
            {
                return ((new CaseInsensitiveComparer()).Compare(y, x));
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

           
                // Initialize a string array.
                string [] words = { "The", "quick", "brown", "fox", "jumps", "overrr",
                         "the", "lazy", "dog" };

            // Display the array values.
            lblText.Text = "The array initially contains the following values";
            // lstBox.Text = PrintIndexAndValues(words);

            //PrintIndexAndValues(words));

            // Sort the array values using the default comparer.
            Array.Sort(words);
            Console.WriteLine("After sorting with the default comparer:");
            PrintIndexAndValues(words);

            // Sort the array values using the reverse case-insensitive comparer.
            Array.Sort(words, new ReverserClass());
            Console.WriteLine("After sorting with the reverse case-insensitive comparer:");
            Console.WriteLine("After sorting with the reverse case-insensitive comparer TEST:");
            PrintIndexAndValues(words);
        }

       


            public static void PrintIndexAndValues(IEnumerable list)
            {
                
                int i = 0;
                foreach (var item in list)
                Console.WriteLine($"   [{i++}]:  {item}");

            }
        }
    }




    /*  
     *   [STAThread]
            static void Main(string[] args)
            {
                // Create an arary of objects.      
                int fruit[] arrayOfFruits = new fruit[3]
                 {
                new fruit("Apple",5),
                new fruit("Banana",2),
                new fruit("Grapes",6),

                 };

                // Write out a header for the output.
                Console.WriteLine("Array - Unsorted\n");

                foreach (fruit f in arrayOfFruits)
                    Console.WriteLine(f.Type + "\t\t" + f.Price);

                // Demo IComparable by sorting array with "default" sort order.
                Array.Sort(arrayOfFruits);
                Console.WriteLine("\nArray - Sorted by Type (Ascending - IComparable)\n");

                foreach (fruit f in arrayOfFruits)
                    Console.WriteLine(f.Type + "\t\t" + f.Price);

                // Demo ascending sort of numeric value with IComparer.
                Array.Sort(arrayOfFruits, fruit.sortYearAscending());
                Console.WriteLine("\nArray - Sorted by Price (Ascending - IComparer)\n");

                foreach (fruit f in arrayOfFruits)
                    Console.WriteLine(f.Type + "\t\t" + f.Price);

                // Demo descending sort of string value with IComparer.
                Array.Sort(arrayOfFruits, fruit.sortMakeDescending());
                Console.WriteLine("\nArray - Sorted by Make (Descending - IComparer)\n");

                foreach (fruit f in arrayOfFruits)
                    Console.WriteLine(f.Type + "\t\t" + f.Price);

                // Demo descending sort of numeric value using IComparer.
                Array.Sort(arrayOfFruits, fruit.sortYearDescending());
                Console.WriteLine("\nArray - Sorted by Price (Descending - IComparer)\n");

                foreach (fruit f in arrayOfFruits)
                    Console.WriteLine(f.Type + "\t\t" + f.Price);

                Console.ReadLine();
            }
        }
    }

    */


