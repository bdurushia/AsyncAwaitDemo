namespace AsyncAwaitDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ThreadLockButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;

            textBox1.Text = "Getting Text.";
            textBox1.Text += "\r\n" + GetTextThreadBlocking();

        }

        private string GetTextThreadBlocking()
        {
            Thread.Sleep(10000);
            return "Thread blocking task completed!";
        }

        private async Task<string> GetTextThreadNoBlocking()
        {
            await Task.Run(() => Thread.Sleep(10000));
            return "Thread blocking task completed!";
        }

        private async void UnlockThreadButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;

            textBox1.Text = "Getting Text.";
            textBox1.Text += "\r\n" + await GetTextThreadNoBlocking();
        }
    }
}
