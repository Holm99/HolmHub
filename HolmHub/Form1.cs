namespace HolmHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
//            this.FormBorderStyle = FormBorderStyle.None;
//            this.TransparencyKey = Color.Gray;
            this.Text = "HolmHub";
            this.BackColor = Color.FromArgb(34, 38, 41);
            this.Size = new Size(700, 350);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            //this.Hide();

        }
    }
}