namespace MoneyInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static bool IsPrime(UInt64 number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (UInt64)Math.Floor(Math.Sqrt(number));

            for (UInt64 i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            label3.Text = "";
            string data;
            data = "";
            if (textBox1.Text.Length > 0)
            {
                data = textBox1.Text;
                string[] input = data.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                UInt64 M = 1;
                bool Prima = false;
                for (int i = 1; i < input.Length; i += 2)
                {
                    UInt64 temp = UInt64.Parse(input[i]);
                    if (IsPrime(temp))
                    {
                        M *= temp;

                    }
                    else
                    {
                        label3.Text = "Не пройдена проверка на простоту: a[" + i/2 +"] = "  + temp;
                        Prima = true;
                    }     

                }
                if (!Prima)
                {
                    label3.Text += "M = " + M + "\n\n";
                    UInt64 Summ = 0;
                    for (uint i = 1; i < input.Length; i += 2)
                    {
                        label3.Text += "Найдем Y_" + (i + 1) / 2 + "\n";
                        UInt64 x = Convert.ToUInt64(input[i - 1]), m = Convert.ToUInt64(input[i]);
                        UInt64 Mi = M / m;
                        UInt64[] r = new UInt64[m];
                        r[1] = 1;
                        for (UInt64 k = 2; k < m; ++k)
                            r[k] = (m - (m / k) * r[m % k] % m) % m;
                        UInt64 y = r[Mi%m];
                        UInt64 s = (Mi * y * x)%M;
                        label3.Text += "M_" + (i + 1) / 2 + " = " + Mi + "\n";
                        label3.Text += "Y_" + (i + 1) / 2 + " = " + y + "\n";
                        label3.Text += Mi + " * " + y + " = " + ((Mi * y) % m) + "(mod " + m + ")" + "\n";
                        label3.Text += "s" + "=" + Mi + " * " + y.ToString() + " * " + x.ToString() + " = " + s.ToString() + "\n\n";
                        Summ = (Summ + s)%M;
                    }
                    Summ = Summ % M;
                    label3.Text += "       Ответ: " + "x=" + Summ + "(mod " + M + ")";
                    
                }
                
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = " ";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            InfoForm1 infoForm1 = new InfoForm1();
            infoForm1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InfoForm2 form2 = new InfoForm2();
            form2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}