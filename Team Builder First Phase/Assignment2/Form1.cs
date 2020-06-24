using System;
using System.Globalization;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Assignment2 : Form
    {
        public Assignment2()
        {
            InitializeComponent();
        }

        //Declaring global integer and decimal variables.
        decimal FullFare = 5.50m, StudentFare = 4.50m, DiscountFare = 3.75m, TotalFare = 0m, TotalReceipts;
        int TotalDrivers, TotalPassengers;
        
        //Clears the form for the next user data input.
        private void ClearButton_Click(object sender, EventArgs e)
        {
            DetailsGroupBox.Enabled = true;
            DetailsGroupBox.Visible = true;
            CalculateGroupBox.Visible = false;
            SummaryGroupBox.Visible = false;
            FullFareTextBox.Text = string.Empty;
            StudentRiderTextBox.Text = string.Empty;
            DiscountRiderTextBox.Text = string.Empty;
            DriversNameTextBox.Text = string.Empty;
            DriversNameTextBox.Focus();
            CalculateButton.Enabled = true;
            SummaryButton.Enabled = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Dislays the cummulative summary of all the drivers of company.
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            SummaryGroupBox.Visible = true;
            DetailsGroupBox.Visible = false;
            CalculateGroupBox.Visible = false;
            
            //String conversion and currency formatting is done.
            TotalDriverDisplayLabel.Text = TotalDrivers.ToString();
            SummaryTotalPassengerDisplay.Text = TotalPassengers.ToString();
            SummaryTotalReceiptDisplay.Text = TotalReceipts.ToString("C", new CultureInfo("en-FR"));
            SummaryAvgReceiptDisplay.Text = (TotalReceipts / TotalPassengers).ToString("C", new CultureInfo("en-FR"));
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
           
            int NoOfFullFareRider = 0, NoOfStudentRider = 0, NoOfDiscountRider = 0,NoOfTotalPassenger=0;

            //This block is executed until an exception is thrown.
            try
            {
                if (DriversNameTextBox.Text != "")
                {


                    //Counts the total drivers in the company.
                    CalculateNameDisplay.Text = DriversNameTextBox.Text;
                    if (CalculateNameDisplay.Text != "")
                    {
                        TotalDrivers = TotalDrivers + 1;
                    }

                    /*
                      Parsing the input values into an integer and displaying the total passengers.
                      Parsed values are stored inside the assigned int var.
                    */
                    TotalPassengerDisplayLabel.Text = ((NoOfFullFareRider = int.Parse(FullFareTextBox.Text)) + (NoOfStudentRider = int.Parse(StudentRiderTextBox.Text)) + (NoOfDiscountRider = int.Parse(DiscountRiderTextBox.Text))).ToString();
                    NoOfTotalPassenger = NoOfFullFareRider + NoOfStudentRider + NoOfDiscountRider;
                    TotalFare = NoOfFullFareRider * FullFare + NoOfStudentRider * StudentFare + NoOfDiscountRider * DiscountFare;

                    //Currency Formatting is done do display amount in euros.
                    TotalReceiptsDisplay.Text = (TotalFare).ToString("C", new CultureInfo("en-FR"));
                    CalculateButton.Enabled = false;
                    SummaryButton.Enabled = true;
                    DetailsGroupBox.Enabled = false;
                    CalculateGroupBox.Visible = true;
                    AvgReceiptsDisplay.Text = (TotalFare / NoOfTotalPassenger).ToString("c", new CultureInfo("en-FR"));

                    //Counts the total passengers & receipts if condition satisfies.
                    if (NoOfFullFareRider != 0 && NoOfStudentRider != 0 && NoOfDiscountRider != 0)
                    {
                        TotalPassengers = TotalPassengers + NoOfTotalPassenger;
                        TotalReceipts = TotalReceipts + TotalFare;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter driver name", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DriversNameTextBox.Focus();
                }
            }
            //This block handles an exception if found.
            catch
            {


                if (NoOfFullFareRider != 0)
                {
                    if (NoOfStudentRider != 0)
                    {
                        if (NoOfDiscountRider != 0)
                        { }

                        /*
                          Every else block displays an error message respective to its if condition,
                          Empties and focusses on the box of error.
                          Decrements the default increment of total drivers.
                         */
                        else
                        {
                            MessageBox.Show("Please enter numerical data for discount rider", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            DiscountRiderTextBox.Text = string.Empty;
                            DiscountRiderTextBox.Focus();
                            TotalDrivers -= 1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter numerical data for student rider", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        StudentRiderTextBox.Text = string.Empty;
                        StudentRiderTextBox.Focus();
                        TotalDrivers -= 1;
                    }
                }

                else
                {
                    MessageBox.Show("Please enter numerical data for full fare rider", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FullFareTextBox.Text = string.Empty;
                    FullFareTextBox.Focus();
                    TotalDrivers -= 1;
                }
            }

        }

        
    }
}
