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
            this.Text = "HolmHub";
            this.BackColor = Color.Gray;
            this.Size = new Size(700, 350);
        }
    }
}