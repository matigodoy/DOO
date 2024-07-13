namespace DOO
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) >= 70)
            {
                MessageBox.Show("jaja gordo XD");
            }
            else
            {
                MessageBox.Show("no eres gordo");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
