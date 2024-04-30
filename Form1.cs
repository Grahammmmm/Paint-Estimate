namespace Painting_Estimate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            
                int length = Convert.ToInt32(textBox1.Text);
                int width = Convert.ToInt32(textBox2.Text);
                double cost = DisplayCost(length, width);
                label3.Text = string.Format("My cost is {0}", cost.ToString("C"));
            
            static double DisplayCost(int length, int width)
            {
                double cost;
                cost = ((2 * length * 9) + (2 * width * 9) + (length * width)) * 6;
                return cost;
            }
          
        }
    }
}
