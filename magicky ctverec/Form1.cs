namespace magicky_ctverec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();   
        }
        int a = 0;
        int b = 0;
        int c =0;
        int d =0;
        int z = 0;
        int f = 0;
        int g = 0;
        int h = 0;
        int i = 0;

        int t = 0;
        int[,] tlacitka = new int[3, 3];
        private void t1_Click(object sender, EventArgs e)
        {
        a = a + 1;
            if (a == 10)
            {
                a = 1;
            }
            t1.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = b + 1;
            if (b == 10)
            {
                b = 1;
            }
            t2.Text = b.ToString();
        }

        private void t3_Click(object sender, EventArgs e)
        {
            c = c + 1;
            if (c == 10)
            {
                c = 1;
            }
            t3.Text = c.ToString();
        }

        private void t4_Click(object sender, EventArgs e)
        {
            d = d + 1;
            if (d == 10)
            {
                d = 1;
            }
            t4.Text = d.ToString();
        }

        private void t5_Click(object sender, EventArgs e)
        {
            z = z + 1;
            if (z == 10)
            {
                z = 1;
            }
            t5.Text = z.ToString();
        }

        private void t6_Click(object sender, EventArgs e)
        {
            f = f + 1;
            if (f == 10)
            {
                f = 1;
            }
            t6.Text = f.ToString();
        }

        private void t7_Click(object sender, EventArgs e)
        {
            g = g + 1;
            if (g == 10)
            {
                g = 1;
            }
            t7.Text = g.ToString();
        }

        private void t8_Click(object sender, EventArgs e)
        {
            h = h + 1;
            if (h == 10)
            {
                h = 1;
            }
            t8.Text = h.ToString();
        }

        private void t9_Click(object sender, EventArgs e)
        {
            i = i + 1;
            if (i == 10)
            {
                i = 1;
            }
            t9.Text = i.ToString();
        }
    }
}