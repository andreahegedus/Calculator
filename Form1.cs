using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public double elsoszam;
        public string op;
        public char save_mjel = ' ';
        public double save_szam = 0;
        public double eredmeny = 0;
        public Calculator()
        {
            
            InitializeComponent();
        }

        private void One_button_Click(object sender, EventArgs e)
        {
            TextBox.Text += "1";
        }

        private void Two_button_Click(object sender, EventArgs e)
        {
            TextBox.Text += "2";

        }

        private void Three_button_Click(object sender, EventArgs e)
        {
            TextBox.Text += "3";
        }

        private void Four_button_Click(object sender, EventArgs e)
        {
            TextBox.Text += "4";
        }

        private void Five_button_Click(object sender, EventArgs e)
        {
            TextBox.Text += "5";
        }

        private void Six_button_Click(object sender, EventArgs e)
        {
            TextBox.Text += "6";
        }

        private void Seve_button_Click(object sender, EventArgs e)
        {
            TextBox.Text += "7";
        }

        private void Eight_button_Click(object sender, EventArgs e)
        {
            TextBox.Text += "8";
        }

        private void Nine_button_Click(object sender, EventArgs e)
        {
            TextBox.Text += "9";
        }

        private void Zero_button_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                TextBox.Text += "0";
            }
        }

        private void Osszeadas_button_Click(object sender, EventArgs e)
        {
            save_szam = double.Parse(TextBox.Text);
            eredmeny += save_szam;
            save_mjel = '+';
            TextBox.Text = "";
            
        }

        private void Kivonas_button_Click(object sender, EventArgs e)
        {
            save_szam = double.Parse(TextBox.Text);
            eredmeny -= save_szam;
            save_mjel = '-';
            TextBox.Text = "";
        }

        private void Szorzas_button_Click(object sender, EventArgs e)
        {
            save_szam = double.Parse(TextBox.Text);
            if (eredmeny == 0)
            {
                eredmeny = save_szam;
            }
            else
            {
                eredmeny = eredmeny * save_szam;
            }
            save_mjel = '*';
            TextBox.Text = "";
           
        }

        private void Osztas_button_Click(object sender, EventArgs e)
        {
            save_szam = double.Parse(TextBox.Text);
            eredmeny = eredmeny / save_szam;
            save_mjel = '/';
            TextBox.Text = "";
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            
            TextBox.Text = "";
            save_mjel = ' ';
            save_szam = 0;

        }

        private void Egyenlo_button_Click(object sender, EventArgs e)
        {
            save_szam = double.Parse(TextBox.Text);
            switch (save_mjel)
            {
                case '+':
                    eredmeny = eredmeny + save_szam;
                    break;
                case '-':
                    eredmeny = eredmeny - save_szam;
                    break;
                case '*':
                    eredmeny = eredmeny * save_szam;
                    break;
                case '/':
                    eredmeny = eredmeny / save_szam;
                    break;
            }
            TextBox.Text = Convert.ToString(eredmeny);
            eredmeny = 0;
            save_mjel = ' ';
            save_szam = 0;
        }
    }
}
    
    

