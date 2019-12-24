using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Prefix_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList yigin = new ArrayList();
        public string prefix;
        char[] ayrac = new char[] { ' ' };
        string[] prefix_ayrac;
        public int sonuc;

        private void button1_Click(object sender, EventArgs e)
        {
            prefix = textBox1.Text;
            prefix_ayrac = prefix.Split(ayrac);
            Array.Reverse(prefix_ayrac);
            prefix = String.Concat(prefix_ayrac);

            foreach (char i in prefix) 
            { 
              if (i == '*' || i == '+' || i == '/' || i == '-')
              {
                int a = int.Parse(yigin[yigin.Count - 1].ToString());
                int b = int.Parse(yigin[yigin.Count - 2].ToString());

                if (i == '*')
                {
                    sonuc = a * b;
                }
                else if (i == '+')
                {
                    sonuc = a + b;
                }
                else if (i == '/')
                {
                    sonuc = a / b;
                }
                else
                {
                    sonuc = a - b;
                }

                    yigin.RemoveAt(yigin.Count - 1);
                    yigin.RemoveAt(yigin.Count - 1);
                    yigin.Add(sonuc);
              }
              else
              {
                yigin.Add(i);
              }
            }
        Console.WriteLine(sonuc);
               
        }              
    }
}

    


