using System.Globalization;

namespace magicky_ctverec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();   
        }
      

     
        int[] cb = new int[9];
        private void tlacitko(Button bt, int i )
        {
            cb[i]+=1;
            if (cb[i] == 10)
            {
                cb[i] = 1;
            }
            bt.Text = cb[i].ToString();
        }

        private void t1_Click(object sender, EventArgs e)
        {
            tlacitko(t1, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tlacitko(t2, 1);
        }

        private void t3_Click(object sender, EventArgs e)
        {
            tlacitko(t3, 2);
        }

        private void t4_Click(object sender, EventArgs e)
        {
            tlacitko(t4, 3);
        }

        private void t5_Click(object sender, EventArgs e)
        {
            tlacitko(t5, 4);
        }

        private void t6_Click(object sender, EventArgs e)
        {
            tlacitko(t6, 5);
        }

        private void t7_Click(object sender, EventArgs e)
        {
            tlacitko(t7, 6);
        }

        private void t8_Click(object sender, EventArgs e)
        {
            tlacitko(t8, 7);
        }

        private void t9_Click(object sender, EventArgs e)
        {
            tlacitko(t9, 8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soucet = 0;
           
            if (cb[0] + cb[1] + cb[2] == 15)
            {
                soucet += 1;
            }

            if (cb[3] + cb[4] + cb[5] == 15)
            {
                soucet += 1;
            }
            if (cb[6] + cb[7] + cb[8] == 15)
            {
                soucet += 1;
            }
            if (cb[0] + cb[3] + cb[6] == 15)
            {
                soucet += 1;
            }
            if (cb[1] + cb[4] + cb[7] == 15)
            {
                soucet += 1;
            }
            if (cb[2] + cb[5] + cb[8] == 15)
            {
                soucet += 1;
            }
            if (cb[0] + cb[4] + cb[8] == 15)
            {
                soucet += 1;
            }
            if (cb[2] + cb[4] + cb[6] == 15)
            {
                soucet += 1;
            }
            

            if (soucet==8)
            {
                tb1.Text = ("ok");
            }
            else
            {
                tb1.Text = ("SPATNE");
            }

        }
    }
}