namespace wf312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (radioButton2.Checked) ? "Верно" : "Ошибка";
        }
    }
}
