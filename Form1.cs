namespace farenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorfarenheit, tempcelcius, conversaototal;

            valorfarenheit = Convert.ToDouble(textBox1.Text);
            
            conversaototal = (5.0/9.0) * (valorfarenheit - 32);
            
            tempcelcius = conversaototal;

            label3.Text = tempcelcius.ToString();

        }
    }
}