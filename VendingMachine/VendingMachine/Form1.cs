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

            Image cahoy = Image.FromFile(@"assets\logos\chips ahoy.png");
            bproducto2.Image = cahoy;
            bproducto2.BackgroundImageLayout = ImageLayout.Stretch;

            Image ccola = Image.FromFile(@"assets\logos\coca cola.png");
            bproducto3.Image = ccola;
            bproducto3.BackgroundImageLayout = ImageLayout.Stretch;

            Image doritos = Image.FromFile(@"assets\logos\doritos.png");
            bproducto4.Image = doritos;
            bproducto4.BackgroundImageLayout = ImageLayout.Stretch;


        }
    }
}
