using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizzas;

namespace PizzaFabrMet
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

        int bal = 0;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).BorderStyle = BorderStyle.Fixed3D;

            if(Convert.ToInt32(((PictureBox)sender).Tag) == z.numZakaz)
            {
                bal++;
                label5.Text = bal.ToString();
            }
            else
                GameOver();

            ((PictureBox)sender).BorderStyle = BorderStyle.None;
            newZak();
        }

        Zakaz z;
        Pizza p;

        void perenos(string[] piz)
        {
            
            for (int i = 0; i < piz.Length; i++)
                label3.Text += piz[i]+ " \n";
        }

        void newZak()
        {
            timer1.Enabled = true;
            label3.Text = "Ингридиенты: \n";
            Random r = new Random();

            switch (r.Next(1, 4))
            {
                case 1:
                    label2.Text = "Карбонара";
                    z = new ZakazPizzaCarbonara();
                    p = z.createZakaz();
                    perenos(p.ing());
                    break;
                case 2:
                    label2.Text = "Мясная";
                    z = new ZakazMeatPizza();
                    p = z.createZakaz();
                    perenos(p.ing());
                    break;
                case 3:
                    label2.Text = "Маргарита";
                    z = new ZakazPizzaMargarita();
                    p = z.createZakaz();
                    perenos(p.ing());
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            newZak();
        }

        int o = 30;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(o>0)
            {
                o--;
                label9.Text = o.ToString();
            }
            else
                GameOver();
        }

        void GameOver()
        {
            timer1.Enabled = false;
            if (o <= 1)
                label12.Text = "Время вышло";
            else
                label12.Text = "Игра окончена";

            o = 30;
            bal = 0;
            panel1.Visible = false;
            panel2.Visible = true;
            label11.Text = label5.Text;
            label5.Text = "0";
            label9.Text = "30";
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            newZak();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
