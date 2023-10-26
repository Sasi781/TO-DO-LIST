namespace TO_DO_LIST
{
    public partial class Form1 : Form
    {
        Queue<string> q = new Queue<string>();
        Queue<string> q1 = new Queue<string>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox1.Text = "";
            if (str != "")
            {
                q.Enqueue(str);
                IEnumerator<string> enumerator = q.GetEnumerator();
                string sub = "";
                while (enumerator.MoveNext())
                {

                    sub += enumerator.Current + '\n';
                }
                richTextBox1.Text = sub;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (q.Count > 0)
            {

                string str1 = q.Peek();
                q.Dequeue();
                IEnumerator<string> enumerator = q.GetEnumerator();
                string sub = "";
                while (enumerator.MoveNext())
                {

                    sub += enumerator.Current + '\n';
                }
                richTextBox1.Text = sub;
                q1.Enqueue(str1);
                IEnumerator<string> enumerator1 = q1.GetEnumerator();
                sub = "";
                while (enumerator1.MoveNext())
                {

                    sub += enumerator1.Current + '\n';
                }
                richTextBox2.Text = sub;

            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}