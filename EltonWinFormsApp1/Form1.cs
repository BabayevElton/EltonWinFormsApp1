namespace EltonWinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static Dictionary<string, string> users = new Dictionary<string, string>();
        private void button1_Click(object sender, EventArgs e)
        {

            string inUser=textBox1.Text;
            string inPass=textBox2.Text;
            if(users.ContainsKey(inUser)&& users[inUser]==inPass)
            {
                MessageBox.Show("Ugurla daxil oldunuz","Bildirish",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Istifadeci movcud deyil!","Bildirish",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newUser=textBox4.Text;
            string newPass=textBox3.Text;
            if (string.IsNullOrEmpty(newUser) ||
                string.IsNullOrEmpty(newPass))
            {
                MessageBox.Show("Xana bos olmaz","Bildirish",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if(users.ContainsKey(newUser) )
            {
                MessageBox.Show("Bu istifadeci movcuddur","Bildirish",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                users.Add(newUser, newPass);
                MessageBox.Show("Ugurla qeydiyyatdan kechdiniz", "Bildirish", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Clear();
                textBox4.Clear();
            }

        }
    }
}