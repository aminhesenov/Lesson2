namespace Lesson2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MessageBox.Show("Bütün məlumatları sildiniz");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.Text + "məlumatı silindi");
            listBox1.Items.Remove(listBox1.Text);

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Close(); - bütün formaları bağlayar
            Form1 form = new Form1();
            this.Close(); // cari formanı bağlayar
        }
    }
}