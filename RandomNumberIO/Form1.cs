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
// Program    :   Random Number Generator/Reader/Writer
// Developer  :   Mikael Taylor
// Date       :   2/26/2016
// Description:   This program generates random numbers based on user input for the
//                quantity desired.  It also uses a Save dialog, as well as an Open
//                dialog in order to save a list of random numbers, or to open a list
//                of random numbers.
namespace RandomNumberIO
{
    public partial class RandomNumberIOForm : Form
    {//Load the form, and get everything ready.
        int quantityInput;//Variable for quantity user input for the random numbers.
        Random random = new Random();//Random variable for our random number.
        int randomNumber;//Variable to hold the random number until it's written.
        public RandomNumberIOForm()
        {
            InitializeComponent();
        }//Initialize the form's components
        private void btnSave_Click(object sender, EventArgs e)
        {//On clicking submit..
            if (txtQuantityInput.Text != null && int.Parse(txtQuantityInput.Text) > 0)
            {
                try
                {//Try to..
                    quantityInput = int.Parse(txtQuantityInput.Text);
                    //Bring in user input for the quantity to be written.
                    int x = 0;
                    //Start x at zero, so that during our while loop it will continue to generate and write the random numbers into a file.
                    saveFileDialog.Filter = "Text Files(TXT)|*.TXT";
                    saveFileDialog.ShowDialog();
                    //Ask the user where to save the file, and what to name it.
                    string file = saveFileDialog.FileName + ".txt";
                    //Put the filename in a variable so that we can use it.
                    StreamWriter writer = new StreamWriter(file);
                    //Use StreamWriter so that we can write to the file.
                    while (++x < quantityInput + 1)
                    {//begin while
                        //Generate Random Number
                        randomNumber = random.Next(0, 100);
                        //Write Random Number to Specified File
                        writer.WriteLine(randomNumber);
                    }//end while
                    writer.Close();
                }//end try
                catch (Exception ex)
                {//If an exception occurs..
                    MessageBox.Show("Error Code: " + ex);
                    //Tell me what happened.
                }//close catch
            }//end if
            else
            {//Otherwise, if the quantity is null, or less than 1
                MessageBox.Show("Please enter a valid, non-negative quantity.");
                txtQuantityInput.Text = "";
            }//end else
        }//end btnSave_Click
        private void btnOpen_Click(object sender, EventArgs e)
        {//When the user clicks the open button..
            openFileDialog1.Filter = "Text Files (TXT)|*.TXT";
            openFileDialog1.ShowDialog();
            //Ask the user where to open the file..
            string file = openFileDialog1.FileName;
            //Keep the file name in a variable so we can use it.
            if (file != null)
            {
                StreamReader reader = new StreamReader(file);
                //Set up our stream reader to the file's location.
                string line = reader.ReadLine();
                //Read the first line of the file.
                while (line != null)
                {//While the line isn't empty
                    lstFileOutput.Items.Add(line);
                    //Write the line into our listbox control for output.
                    line = reader.ReadLine();
                    //Check to see if the next line is empty or not.
                }//end while
            }
            else
            {
                MessageBox.Show("If you don't select a file, we cannot open it.");
            }
        }//end btnOpen_Click
        private void txtQuantityInput_KeyPress(object sender, KeyPressEventArgs e)
        {//Keypress validation for our txtQuanityInput textbox.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {//If the key pressed isn't a number, or a control key(e.g. backspace, enter, etc.
                e.Handled = true;//Then we have an error.
                MessageBox.Show("You'll need to enter a valid, non-negative whole number.");
            }//end if
        }//end keypress validation
        private void btnClear_Click(object sender, EventArgs e)
        {//On clicking the clear button..
            lstFileOutput.Items.Clear();
            //Clear the list box
        }//end Clear button
    }//end RandomNumberIO form.
}//end program
