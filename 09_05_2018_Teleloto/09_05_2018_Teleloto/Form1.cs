using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_05_2018_Teleloto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<int> kamuoliukai = new List<int>();

        private void bGenerate_Click(object sender, EventArgs e)
        {
            kamuoliukai.Clear();
            TextBox[] Mtexboxai = { M1, M2, M3, M4, M5 };
            TextBox[] Rtexboxai = { R1, R2, R3, R4, R5 };
            TextBox[] Gtexboxai = { G1, G2, G3, G4, G5 };
            TextBox[] Ztexboxai = { Z1, Z2, Z3, Z4, Z5 };
            for (int i = 0; i < Mtexboxai.Length; i++)
            {
                Mtexboxai[i].Text = SugeneruojaKamuoliuka(1, 16).ToString();
            }

            J1.Text = SugeneruojaKamuoliuka(16, 31).ToString();
            J2.Text = SugeneruojaKamuoliuka(16, 31).ToString();
            J3.Text = SugeneruojaKamuoliuka(16, 31).ToString();
            J4.Text = SugeneruojaKamuoliuka(16, 31).ToString();
            J5.Text = SugeneruojaKamuoliuka(16, 31).ToString();
            PripildomiTexboxai(31, 46, Rtexboxai);
            PripildomiTexboxai(46, 61, Gtexboxai);
            PripildomiTexboxai(61, 76, Ztexboxai);
        }

        private void PripildomiTexboxai(int a, int b, TextBox[] texboxai)
        {
            for (int i = 0; i < texboxai.Length; i++)
            {
                texboxai[i].Text = SugeneruojaKamuoliuka(a,b).ToString();
            }
        }

        private int SugeneruojaKamuoliuka(int a, int b)
        {
            Random rng = new Random();
            int temp = 0;
            int flag = 0;
            do
            {
                flag = 0;
                temp = rng.Next(a, b);
                foreach (var item in kamuoliukai)
                {
                    if (temp == item)
                    {
                        flag++;
                    }
                }
            } while (flag != 0);
            kamuoliukai.Add(temp);
            return temp;
        }


        List<int> IstrauktiKamuoliukai = new List<int>();
        private void bPlay_Click(object sender, EventArgs e)
        {
            int i = 0;
            Random rng = new Random();
            while (i < 45)
            {
                int temp = rng.Next(1, 76);
                int flag = 0;
                foreach (var item in IstrauktiKamuoliukai)
                {
                    if(item == temp)
                    {
                        flag++;
                    }
                }
                if (flag == 0)
                {
                    IstrauktiKamuoliukai.Add(temp);
                    textBox1.Text += temp.ToString() + " ";
                    i++;
                }
            }
        }
    }
}
