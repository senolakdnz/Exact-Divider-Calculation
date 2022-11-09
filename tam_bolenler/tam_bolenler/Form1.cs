namespace tam_bolenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt16(textBox1.Text);
            int div = Convert.ToInt16(textBox2.Text);
            int div2 = Convert.ToInt16(textBox3.Text);

            for (int i = 1; i <= number; i++)
            {
                if (i % div == 0 && i % div2 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}