using System.IO;

namespace Lb8
{
    public partial class Form1 : Form
    {
        Handler manager;
        Handler accountant;
        Handler director;
        public Form1()
        {
            InitializeComponent();

            manager = new ManagerHandler();
            accountant = new AccountantHandler();
            director = new DirectorHandler();

            manager.SetNext(accountant);
            accountant.SetNext(director);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string title = textBox1.Text;
            double amount = Convert.ToDouble(textBox2.Text);

            Document doc = new Document(title, amount);

            listBox1.Items.Add("Document sent for approval...");
            manager.Handle(doc, listBox1);
        }
    }
}
