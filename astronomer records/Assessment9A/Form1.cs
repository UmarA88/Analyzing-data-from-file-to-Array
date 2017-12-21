/*Ahmed Matoussi
 * email: ahmedgeek1@gmail.com
 * This application is to read the data from a file and store it in a list of the appropriate size,
 *  and then analyze its data
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assessment9A
{
    public partial class StarsBrightnessAnalysisApplicationForm : Form
    {
        public StarsBrightnessAnalysisApplicationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //clearing the label and the listboxes
            lblNumberOfMatches.Text = "";
            listBoxBrighterStars.Items.Clear();
            listBoxDimmerStars.Items.Clear();
            //declare an empty list
            List<double> recordsList = new List<double>();
            String nameOfStar = openStarsFile(recordsList); //declare a string variable to store the firstLine of the file which is the name of the star
            String[,] knownValues = fileDataKnownValues(); //declare a 2D array and store the reference array given
            Boolean error1 = false;
            Boolean error2 = true; //booleans to verify the error type

            foreach (string knownValue in knownValues)
            {

                if (knownValue != nameOfStar)
                {
                    error2 = true;
                }
                else
                {
                    error2 = false;
                    break;
                }
            }
            if (recordsList.Count == 0)
            { //if there are no records in the file
                MessageBox.Show("Sorry, there are no valid records to analyse!");
            }
            else if (error2)
            {
                MessageBox.Show("Star name does not exist in our known values records!");
            }
           /* else if (recordsList.Count > 1000)  //we can add this option if it were reauired, but in the assignment it doesn't say that it is required
            {
                MessageBox.Show("Your file contains more than 1000");
            }*/
            else
            { //run a loop to verify if every record is valid or not
                foreach (double record in recordsList)
                {
                    foreach (String knownValue in knownValues)
                    {
                        if (record < 0)
                        { //if there is at least one negative record
                            error1 = true;
                            break;
                        }
                        if (nameOfStar != knownValue)
                        {
                            error2 = true;
                        }

                    }

                    if (error1)
                    { //throw error message
                        MessageBox.Show("All the records in the file should be positive!");
                        break;
                    }
                }
            }
            double exactValueMatching = findTheMatchingValueWithTheExactStar(nameOfStar, knownValues); //find the reference value from the reference manually entered table based on the star name
            String numOfMatchesString = numberOfMatches(exactValueMatching, recordsList).ToString(); //declare a variable and store the number of matches in it   
            if (numOfMatchesString == "0")
            {
                lblNumberOfMatches.Text = "No Matches";
            }
            else
            { //display results in the label and listboxes
                lblNumberOfMatches.Text = numOfMatchesString;
                brighterList(exactValueMatching, recordsList);
                dimmerList(exactValueMatching, recordsList);
            }
        }

        private String openStarsFile(List<double> recordsList)
        {
            String firstLine = ""; //declare variable to be returned later
            try
            {

                // Declare a StreamReader variable.
                StreamReader inputFile;
                // set up initial open directory! 
                String UN = Environment.UserName; //variable for the username
                String FilePath = @"C:\Users\" + UN + @"\Documents\ "; //concatinating the username with the path
             openStarsFileDialog.InitialDirectory = FilePath; //this folder is getting showed in the second replicate of the save dialogue window
                                                     // show only files with .txt extension
                openStarsFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                //if the uyser click on open and open a file then
                if (openStarsFileDialog.ShowDialog() == DialogResult.OK)
                { //on success and choosing a file
                    try
                    {
                        inputFile = File.OpenText(openStarsFileDialog.FileName);
                        var lineCount = File.ReadAllLines(openStarsFileDialog.FileName).Length; //number of lines in the file
                                                                                                //  MessageBox.Show("here");
                        firstLine = inputFile.ReadLine(); //read the first line, the star name and store it in firstLine variable
                        if (firstLine.GetType() == typeof(String))
                        {
                            //if firstLine is string then it could be a valid star name
                            while (!inputFile.EndOfStream)
                            { //add the lines to the list
                                recordsList.Add(double.Parse(inputFile.ReadLine()));
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please chose another valid file!");
                            firstLine = "";
                        }
                        inputFile.Close(); //close the file
                        return firstLine; //return the value of the firstLine as a string
                    }
                    catch (Exception ex)
                    { //throw an error message in case the user chosed a non valid file
                        MessageBox.Show("Unable to open the selected file! Please chose another file! \n \n  Error: " + ex.Message);
                        return firstLine;
                    }
                }
                else
                { //in case the user clicked on ancel and didn't choose any file
                    MessageBox.Show("Operation canceled!");
                    return firstLine;
                }

            }
            catch (Exception ex)
            {
                //throw the error message in case there is any
                MessageBox.Show(ex.Message);
                return firstLine;
            }

        }

        private String[,] fileDataKnownValues()
        { //method that returns the default reference 2D table entered manually
            String[,] knownValues = {
    {
     "OV Boo",
     "14.95"
    },
    {
     "LV 426",
     "9.91"
    },
    {
     "Fury 161",
     "6.32"
    },
    {
     "XS Dra",
     "8.00"
    },
    {
     "Hip 23429",
     "12.19"
    },
    {
     "52 Eridani",
     "12.11"
    },
    {
     "Hip 43213",
     "11.99"
    },
    {
     "Chi UMa",
     "10.45"
    },
    {
     "Xi UMa",
     "3.27"
    },
    {
     "Dubhe",
     "2.81"
    },
    {
     "Asnin 491",
     "0.14"
    },
    {
     "Beta Umi",
     "8.85"
    },
    {
     "Centaurus B",
     "6.02"
    },
    {
     "YZ Cnc",
     "15.07"
    },
    {
     "Gliese 754",
     "18.50"
    },
    {
     "Epsilon Scorpii",
     "10.00"
    },
    {
     "Markab",
     "9.33"
    },
    {
     "Phecda",
     "11.68"
    },
    {
     "Tau Ceti",
     "19.23"
    },
    {
     "Spica",
     "2.10"
    }
   };

            return knownValues; //return table

        }

        private double findTheMatchingValueWithTheExactStar(String starName, String[,] knownValues)
        {
            int lengthoftable = knownValues.Length - 1;
            double knownValue = 0; //declare a variable that will hold the value of the default brightness of the star
            for (int j = 0; j <= 19; j++)
            { //for loop from the begining of the list to the end
                if (starName == knownValues[j, 0])
                { //if there is a match or the name of the star exists then the variable get the value of the brightness corresponding to that name
                    knownValue = double.Parse(knownValues[j, 1]);
                    break; //breaking the loop because no need to keep looking for a match, as we already found it
                }
            }
            //return the brightness value
            return knownValue;

        }

        private int numberOfMatches(double exactValueMatching, List<double> recordsList)
        {
            //method that returns the number of matches the star had
            int numberOfMatches = 0; //incrementer setted to 0

            foreach (double record in recordsList)
            { //for every record there is a match the variable increment
                if (record == exactValueMatching)
                {
                    numberOfMatches++; //incrementing
                }
            }
            //return the incrementer
            return numberOfMatches;
        }

        private void dimmerList(double exactMatch, List<double> recordsList)
        { //method that returns the dimmer values for the analysed star compared to the default brightness
            List<double> immerList = new List<double>();

            foreach (double record in recordsList)
            {
                if (record > exactMatch)
                {
                    immerList.Add(record);
                }
            }

            immerList.Sort(); //sorting the list asc
            immerList.Reverse(); //reverse the soring - now its sorted desc

            foreach (double record2 in immerList)
            { //for every record in the list add them to the listbox
                listBoxDimmerStars.Items.Add(record2.ToString());
            }

        }

        private void brighterList(double exactMatch, List<double> recordsList)
        { //method that returns the brighter values for the analysed star compared to the default brightness
            List<double> brighterList = new List<double>();

            foreach (double record in recordsList)
            {
                if (record < exactMatch)
                {
                    brighterList.Add(record);
                }
            }

            brighterList.Sort(); //sorting the list asc


            foreach (double record2 in brighterList)
            { //for every record in the list add them to the listbox
                listBoxBrighterStars.Items.Add(record2.ToString());
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear the labels and the listBoxes
            lblNumberOfMatches.Text = "";
            listBoxBrighterStars.Items.Clear();
            listBoxDimmerStars.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        { //close the form
            this.Close();
        }
    }
}