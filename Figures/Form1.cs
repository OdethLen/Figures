namespace Figures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Rhombus R1 = new Rhombus(Convert.ToDouble(txtSideR.Text), Convert.ToDouble(txtDiagonal1.Text),Convert.ToDouble(txtDiagonal2.Text));
            txtAreaR.Text = R1.PrintAreaR();
            txtPerimeterR.Text = R1.PrintPerimeterR();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSideR.Clear();
            txtAreaR.Clear();
            txtPerimeterR.Clear();
            txtDiagonal1.Clear();
            txtDiagonal2.Clear();
        }
    }
}
