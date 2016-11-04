// Program 2
//Alaa Hawsawi
// CIS 199-01
// Due: 11/19/2014
// The program will find the students early registering date and time by entering the fisrt letter of their last name



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog2
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void findRegTimeBtn_Click(object sender, EventArgs e)
        {
            string lastNameStr;       // Entered last name
            string lastNameLetterStr; // First letter of last name, as string
            char lastNameLetterCh;    // First letter of last name, as char
            string dateStr = "Error"; // Holds date of registration
            string timeStr = "Error"; // Holds time of registration
            lastNameStr = lastNameTxt.Text;
            lastNameLetterStr = lastNameStr.Substring(0, 1);  // 1 letter from position 0
            lastNameLetterStr = lastNameLetterStr.ToUpper();  // Ensure upper case
            lastNameLetterCh = char.Parse(lastNameLetterStr); // As a char
            char[] jun_sen_lastNameLetter = { 'A', 'E', 'J', 'P', 'S' }; //array for Juniors and Seniors
            char[] fre_soph_lastNameLetter = { 'A', 'C', 'E', 'G', 'J', 'M', 'P', 'S', 'U', 'W' }; // array for Sophomores and Freshmen
            string[] jun_sen_time = { "10:00 AM", "11:30 AM", "2:00 PM", "4:00 PM", "8:30 AM" }; //time for Juniors and Seniors
            string[] fre_soph_time = { "2:00 PM", "4:00 PM", "8:30 AM", "10:00 AM",
                                 "11:30 AM", "2:00 PM", "4:00 PM", "8:30 AM", "10:00 AM", "11:30 AM" };//time for Sophomores and Freshmen

            int a = jun_sen_lastNameLetter.Length - 1;
            while (a >= 0 && lastNameLetterCh < jun_sen_lastNameLetter[a])   //loop for Juniors and Seniors
                a--;
            int a2 = fre_soph_lastNameLetter.Length - 1;
            while (a2 >= 0 && lastNameLetterCh < fre_soph_lastNameLetter[a2])// loop for Sophomores and Freshmen
                a2--;

                // Juniors and Seniors share same schedule but different days
                if (juniorBtn.Checked || seniorBtn.Checked)
                {
                    if (seniorBtn.Checked)
                        dateStr = "November 7";
                    else // Must be juniors
                        dateStr = "November 10";

                    timeStr = jun_sen_time[a];

                    dateTimeLbl.Text = dateStr + " at " + timeStr;

                }
                    
                // Sophomores and Freshmen
                else // Must be soph/fresh
                {
                    if (sophBtn.Checked)
                    {
                        // C-O on one day
                        if ((lastNameLetterCh >= 'E') && // >= E and
                            (lastNameLetterCh <= 'R'))   // <= R
                            dateStr = "November 12";
                        else // All other letters on previous day
                            dateStr = "November 11";
                    }
                    else // must be freshman
                    {
                        // C-O on one day
                        if ((lastNameLetterCh >= 'E') && // >= E and
                            (lastNameLetterCh <= 'R'))   // <= R
                            dateStr = "November 14";
                        else // All other letters on previous day
                            dateStr = "November 13";
                    }
                    timeStr = fre_soph_time[a2];
                    dateTimeLbl.Text = dateStr + " at " + timeStr;
                }

        }
    }
}
