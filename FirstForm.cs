namespace TP_LR_3_1st_contrib
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void ExchangeButton_Click(object sender, EventArgs e)
        {
            ExchangeRateForm form2 = new ExchangeRateForm();
            form2.Show();
            this.Close();
        }

        private void TemperatureButton_Click(object sender, EventArgs e)
        {

        }
    }
}