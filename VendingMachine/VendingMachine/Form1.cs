using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
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
            bproducto1.Image = cheetos;
            bproducto1.BackgroundImageLayout = ImageLayout.Stretch;

            Image chipAhoy = Image.FromFile(@"assets\logos\chips ahoy.png");
            bproducto2.Image = chipAhoy;
            bproducto2.BackgroundImageLayout = ImageLayout.Stretch;

            Image cocaCola = Image.FromFile(@"assets\logos\coca cola.png");
            bproducto3.Image = cocaCola;
            bproducto3.BackgroundImageLayout = ImageLayout.Stretch;

            Image doritos = Image.FromFile(@"assets\logos\doritos.png");
            bproducto4.Image = doritos;
            bproducto4.BackgroundImageLayout = ImageLayout.Stretch;

            Image gatorade = Image.FromFile(@"assets\logos\gatorade.png");
            bproducto5.Image = gatorade;
            bproducto5.BackgroundImageLayout = ImageLayout.Stretch;

            Image kitKat = Image.FromFile(@"assets\logos\kit kat.png");
            bproducto6.Image = kitKat;
            bproducto6.BackgroundImageLayout = ImageLayout.Stretch;

            Image monster = Image.FromFile(@"assets\logos\monster.png");
            bproducto7.Image = monster;
            bproducto7.BackgroundImageLayout = ImageLayout.Stretch;

            Image oreo = Image.FromFile(@"assets\logos\oreo.png");
            bproducto8.Image = oreo;
            bproducto8.BackgroundImageLayout = ImageLayout.Stretch;

            Image pepsi = Image.FromFile(@"assets\logos\pepsi.png");
            bproducto9.Image = pepsi;
            bproducto9.BackgroundImageLayout = ImageLayout.Stretch;

            Image redBull = Image.FromFile(@"assets\logos\red bull.png");
            bproducto10.Image = redBull;
            bproducto10.BackgroundImageLayout = ImageLayout.Stretch;

            Image skittles = Image.FromFile(@"assets\logos\skittles.png");
            bproducto11.Image = skittles;
            bproducto11.BackgroundImageLayout = ImageLayout.Stretch;

            Image snickers = Image.FromFile(@"assets\logos\snickers.png");
            bproducto12.Image = snickers;
            bproducto12.BackgroundImageLayout = ImageLayout.Stretch;

            Image sprite = Image.FromFile(@"assets\logos\sprite.png");
            bproducto13.Image = sprite;
            bproducto13.BackgroundImageLayout = ImageLayout.Stretch;

            Image drPepper = Image.FromFile(@"assets\logos\dr pepper.png");
            bproducto14.Image = drPepper;
            bproducto14.BackgroundImageLayout = ImageLayout.Stretch;

            Image fanta = Image.FromFile(@"assets\logos\fanta.png");
            bproducto15.Image = fanta;
            bproducto15.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
