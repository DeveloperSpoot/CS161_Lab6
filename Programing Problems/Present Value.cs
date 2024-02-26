namespace CS161_Lab6.Programing_Problems
{
    public partial class Present_Value : Form
    {
        public Present_Value()
        {
            InitializeComponent();
        }

        
        //Main calculation method, calc button event.
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Retreiving all the inputs.
            string future = futureTextBox.Text;
            string interest = interestRateTextBox.Text;
            string years = yearsTextBox.Text;

            //Calling our method to calculate the total needed to be deposit today to meet the future goal.
            decimal depositNeeded = getDepositNeeded(future, interest, years);

            //Outputting said needed deposit.
            depositNeededLabel.Text = depositNeeded.ToString("c");
        }

        //Calculation method for our Needed Deposit.
        private decimal getDepositNeeded(string future, string interest, string years)
        {
            double futureGoal = 0.00, interestRate = 0.00, yearsAmount = 0.00; // Delcaring vairables for our  convereted inputs.

            try // Catching any incompetence.
            {
                //Converting our inputs/arguments into doubles (which is needed for math.POW).
              futureGoal = double.Parse(future);
              interestRate = double.Parse(interest);
              yearsAmount = double.Parse(years);


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            double denominator = Math.Pow((1 + (interestRate/100)), yearsAmount); // Intermediate step, calculating (1+r)^n;

            return (decimal) futureGoal / (decimal) denominator; // returning the present value.
        }

        //Exit button event method.
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
