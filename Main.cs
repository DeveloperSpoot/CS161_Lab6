using CS161_Lab6.Programing_Problems;

namespace CS161_Lab6
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void hospitalButton_Click(object sender, EventArgs e)
        {
            Form form = new Hospital_Charges();
            form.Show();
        }

        private void presentValueButton_Click(object sender, EventArgs e)
        {
            Form form = new Present_Value();
            form.Show();
        }
    }
}
