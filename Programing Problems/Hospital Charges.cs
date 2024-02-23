namespace CS161_Lab6.Programing_Problems
{
    public partial class Hospital_Charges : Form
    {
        public Hospital_Charges()
        {
            InitializeComponent();
        }

        const decimal DAILY_BASE = 350m; // Constant vairabe in case the daily base changes.

        private void calculateButton_Click(object sender, EventArgs e) // Main caulcation button method.
        {
            //Calling our two methods created to retrieve their respective outputs.

            decimal stayCharges = calculateStayCost();
            decimal medicalCharges = calculateMedicalCost();

            //Calculating the total hospital bill.
            decimal totalCharges = stayCharges + medicalCharges;

            totalLabel.Text = totalCharges.ToString("c"); // Outputting said hospital bill total.
        }

        private decimal calculateStayCost()
        {
            decimal daysSpent = 0m;

            try // Catching any incompetence.
            {
                daysSpent = decimal.Parse(daysTextBox.Text); // Retreiving the number of days input.

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           return daysSpent * DAILY_BASE; // Returning the total cost for the hospital room.
        }
        private decimal calculateMedicalCost() 
        {
            decimal medication = 0m, surgical = 0m, lab = 0m, rehab = 0m;

            try // Catching any incompetence.
            {
                //Retreving all the inputed data related to medical fees.
                medication = decimal.Parse(medicationTextBox.Text);
                surgical = decimal.Parse(surgicalTextBox.Text);
                lab = decimal.Parse(labTextBox.Text);
                rehab = decimal.Parse(rehabTextBox.Text);

            }catch(Exception ex )
            {
                MessageBox.Show(ex.Message); // Outputting any user errors, or unforseen errors.
            }

            return medication+surgical+lab+rehab; // Returning the total medical fees.
        }

        //EXIT method, close button.
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
