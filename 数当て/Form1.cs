namespace 数当て
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btAns_Click(object sender, EventArgs e)
        {
            Random ram = new Random();
            int num = ram.Next(10) +1;
            if (textBox1.Text == num.ToString())
            {
                Anslavel.Text = $"正解！";
            }
            else
            {
                Anslavel.Text = $"残念！正解は{num}";
            }
        }
    }
}
