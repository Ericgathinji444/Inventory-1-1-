/*
 * Name: Eric Gathinji
 * CST-150
 * Activity 1
 * 15/06/2025
 * Citation(s) 
Krill, P. (2023, February 17). Microsoft offers Visual Studio IDE extension for .NET upgrades. InfoWorld.Com.
Yan, N. (2024). Computer Software Programming based on C Language. 2024 Asian Conference on Intelligent Technologies (ACOIT), Intelligent Technologies (ACOIT), 2024 Asian Conference On, 1–5. https://doi.org/10.1109/ACOIT62457.2024.10941661
Tan, J., Chen, Y., & Jiao, S. (2023). Visual Studio Code in Introductory Computer Science Course: An Experience Report.
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

namespace CST_150_Activity_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Hide the weeight on Mars Labels
            lblMars.Visible = false;
            lblMarsWeight.Visible = false;
        }

        /// <summary>
        /// Handles the click event for the Convert button.
        /// </summary>
        /// <remarks>This method is triggered when the Convert button is clicked. It processes the event
        /// and performs the associated action. Ensure that the sender is the expected control before performing any
        /// operations.</remarks>
        /// <param name="sender">The source of the event, typically the button that was clicked.</param>
        /// <param name="e">An <see cref="EventArgs"/> object containing event data.</param>
        private void ConvertButtonClickEvent(object sender, EventArgs e)
        {
          //Declare and Initialize
          decimal earthWeight = 0.0M;
          decimal finalValue = 0.0M;
          decimal gravAccEarth = 9.81M;
          decimal gravAccMars = 3.711M;

            //Read in Earth Weight
            earthWeight = Convert.ToDecimal(txtEarthWeight.Text);

            //Calculate the final value
            finalValue = (earthWeight / gravAccEarth) * gravAccMars;

            //Display the results
            //Use tsring format to format the string  and show only 2 decimal places
            //This is a  string argument
            lblMarsWeight.Text = string.Format("{0:.##} lbs" , finalValue);

            //Make sure to show the mars value and label
            lblMars.Visible = true;
            lblMarsWeight.Visible = true;
        }
    }
}
