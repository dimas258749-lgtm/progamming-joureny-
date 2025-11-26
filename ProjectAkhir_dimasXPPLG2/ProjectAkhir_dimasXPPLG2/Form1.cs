namespace ProjectAkhir_dimasXPPLG2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Tas", "300.000");
            dataGridView1.Rows.Add("Sepatu", "400.000");
            dataGridView1.Rows.Add("baju", "150.000");
            dataGridView1.Rows.Add("Hoodie", "350.000");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            string jeber = comboBox1.SelectedItem?.ToString();
            string jumpes = comboBox2.SelectedItem?.ToString();
            string tangpes = dateTimePicker1.Text;
            int harga = 0;

            if (jeber == "Tas") harga = 300000 * Convert.ToInt32(jumpes);
            if (jeber == "Sepatu") harga = 400000 * Convert.ToInt32(jumpes);
            if (jeber == "Baju") harga = 150000 * Convert.ToInt32(jumpes);
            if (jeber == "Hoodie") harga = 350000 * Convert.ToInt32(jumpes);
            dataGridView2.Rows.Add(nama, jeber, jumpes, harga, tangpes);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            MessageBox.Show(" PILIHAN TELAH DIRESET ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                textBox1.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
