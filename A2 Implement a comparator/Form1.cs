
//**********************************************************************
// Programmer: Kamolchanok Pornleesangsuwan
// Date: 29 May 2020
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64­bit
// Purpose: A2_Implement_a_comparator
// 
//
//***********************************************************************

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

        // Songs string array.

        string[] songs = { "Zbra", "SourCandy", "VersaceOnTheFloor", "WatermelonSugar", "Daisies", "Sugar", "HighHope" };
        


        public class StringLengthComparer : IComparer<string>
        {
            public int Compare(string r, string s)
            {
                if (r.Length > s.Length)
                    return 1;

                if (r.Length < s.Length)
                    return -1;

                return 0;
            }
        }




        private void FrmMain_Load(object sender, EventArgs e)
        {
  
            // Display the array values.
            lblText.Text = "All Songs in array :";

            // Sort the array values using the reverse case-insensitive comparer.

            lblText3.Text = "Sorting array values by length comparer:";
           
        }


        public string PrintSongs()
        {
            string details = "";

            for (int i = 0; i < 7; i++)
            {

                details += songs[i].ToString() + "\n";
            }

           
            return details;

        }
        //
        public string PrintSortedByLength()
        {
            string details = "";

            for (int i = 0; i < 7; i++)
            {

                details += songs[i].ToString() + "\n";
                Array.Sort(songs, new StringLengthComparer());
            }
            
            //Array.Sort(songs, new StringLengthComparer());
            return details;
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            lblPrint1.Text = PrintSongs();
        }

     
        private void btnPrint3_Click(object sender, EventArgs e)
        {

            lblPrint3.Text = PrintSortedByLength();
        }

       
    }
    }

