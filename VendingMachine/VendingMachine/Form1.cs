using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vendingMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image cheetos = Image.FromFile(@"assets\logos\cheetos.png");
            btnProduct1.Image = cheetos;
            btnProduct1.BackgroundImageLayout = ImageLayout.Stretch;

            Image chipsAhoy = Image.FromFile(@"assets\logos\chips ahoy.png");
            btnProduct2.Image = chipsAhoy;
            btnProduct2.BackgroundImageLayout = ImageLayout.Stretch;

            Image cocacola = Image.FromFile(@"assets\logos\coca cola.png");
            btnProduct3.Image = cocacola;
            btnProduct3.BackgroundImageLayout = ImageLayout.Stretch;

            Image doritos = Image.FromFile(@"assets\logos\doritos.png");
            btnProduct4.Image = doritos;
            btnProduct4.BackgroundImageLayout = ImageLayout.Stretch;

            Image drPepper = Image.FromFile(@"assets\logos\dr pepper.png");
            btnProduct5.Image = drPepper;
            btnProduct5.BackgroundImageLayout = ImageLayout.Stretch;

            Image fanta = Image.FromFile(@"assets\logos\fanta.png");
            btnProduct6.Image = fanta;
            btnProduct6.BackgroundImageLayout = ImageLayout.Stretch;

            Image gatorade = Image.FromFile(@"assets\logos\gatorade.png");
            btnProduct7.Image = gatorade;
            btnProduct7.BackgroundImageLayout = ImageLayout.Stretch;

            Image kitkat = Image.FromFile(@"assets\logos\kit kat.png");
            btnProduct8.Image = kitkat;
            btnProduct8.BackgroundImageLayout = ImageLayout.Stretch;

            Image monster = Image.FromFile(@"assets\logos\monster.png");
            btnProduct9.Image = monster;
            btnProduct9.BackgroundImageLayout = ImageLayout.Stretch;

            Image oreo = Image.FromFile(@"assets\logos\oreo.png");
            btnProduct10.Image = oreo;
            btnProduct10.BackgroundImageLayout = ImageLayout.Stretch;

            Image pepsi = Image.FromFile(@"assets\logos\pepsi.png");
            btnProduct11.Image = pepsi;
            btnProduct11.BackgroundImageLayout = ImageLayout.Stretch;

            Image redBull = Image.FromFile(@"assets\logos\red bull.png");
            btnProduct12.Image = redBull;
            btnProduct12.BackgroundImageLayout = ImageLayout.Stretch;

            Image skittles = Image.FromFile(@"assets\logos\skittles.png");
            btnProduct13.Image = skittles;
            btnProduct13.BackgroundImageLayout = ImageLayout.Stretch;

            Image snickers = Image.FromFile(@"assets\logos\snickers.png");
            btnProduct14.Image = snickers;  
            btnProduct14.BackgroundImageLayout = ImageLayout.Stretch;

            Image sprite = Image.FromFile(@"assets\logos\sprite.png");
            btnProduct15.Image = sprite;
            btnProduct15.BackgroundImageLayout = ImageLayout.Stretch;

            Image admin = Image.FromFile(@"assets\icons\settings.ico");
            btnAdmin.Image = admin;
            btnAdmin.BackgroundImageLayout = ImageLayout.Stretch;

            Image cashier = Image.FromFile(@"assets\icons\bill.ico");
            btnCashier.Image = cashier;
            btnCashier.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Form2 payment = new Form2();
            payment.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form3 administrator = new Form3();
            administrator.ShowDialog();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            Form4 cashier = new Form4();
            cashier.ShowDialog();
        }
    }
}
