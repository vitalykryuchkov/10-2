using System.Configuration;

namespace _10_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string minutes = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string days = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Workday")
            {
                double tarif = Convert.ToDouble(textBox1.Text) * 3.5;
                textBox3.Text = Convert.ToString(tarif);
            }
            else if (textBox2.Text == "Weekends")
            {
                double tarif = Convert.ToDouble(textBox1.Text) * 3.5 * 0.8;
                textBox3.Text = Convert.ToString(tarif);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}