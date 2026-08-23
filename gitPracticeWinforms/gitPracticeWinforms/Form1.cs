namespace gitPracticeWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            lblHeightFtCm.Text = "Feet";
            lblHeighInches.Text = "Inches";
            lblWeight.Text = "Pounds";
        }

        private void btnMetric_Click(object sender, EventArgs e)
        {
            lblHeightFtCm.Text = "Centimeter";
            lblHeighInches.Text = "N/A";
            lblWeight.Text = "Kilograms";
        }
    }
}
