using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smx
{
    public partial class Form1 : Form
    {
        private GeradorNumeroFora _geradorNumeroFora = new GeradorNumeroFora();
        private GeradorNumero _geradorNumero = new GeradorNumero();

        // Clubes-propriedades
        private Clube Tottenham => new Clube("Tottenham", _geradorNumero.MetodoNumeroAleatorio());
        private Clube ManchesterCity => new Clube("Manchester City", _geradorNumeroFora.MetodoNumeroAleatorioFora());
        private Clube Ajax => new Clube("Ajax", _geradorNumero.MetodoNumeroAleatorio());
        private Clube Juventus => new Clube("Juventus", _geradorNumeroFora.MetodoNumeroAleatorioFora());
        private Clube ManchesterUnited => new Clube("Manchester United", _geradorNumero.MetodoNumeroAleatorio());
        private Clube Barcelona => new Clube("Barcelona", _geradorNumeroFora.MetodoNumeroAleatorioFora());
        private Clube Liverpool => new Clube("Liverpool", _geradorNumero.MetodoNumeroAleatorio());
        private Clube Porto => new Clube("Porto", _geradorNumeroFora.MetodoNumeroAleatorioFora());

        public Form1()
        {
            InitializeComponent();
        }

        private void MontarJogos(object sender, EventArgs e)
        {
            nomeClube01.Text = ManchesterCity.Nome;
            nomeClube02.Text = Tottenham.Nome;
            nomeClube03.Text = Ajax.Nome;
            nomeClube04.Text = Juventus.Nome;
            nomeClube05.Text = ManchesterUnited.Nome;
            nomeClube06.Text = Barcelona.Nome;
            nomeClube07.Text = Liverpool.Nome;
            nomeClube08.Text = Porto.Nome;
        }

        private void GerarJogoUm_Click(object sender, EventArgs e)
        {
            // Clube 01:
            nomeClube01.Text = ManchesterCity.Nome;
            golsClube01.Text = Convert.ToString(ManchesterCity.Gols);

            // Clube 02
            nomeClube02.Text = Tottenham.Nome;
            golsClube02.Text = Convert.ToString(Tottenham.Gols);

            var golsTime1 = Convert.ToInt32(golsClube01.Text);
            var golsTime2 = Convert.ToInt32(golsClube02.Text);


            if (golsTime1 > golsTime2)
            {
                nomeClube09.Text = ManchesterCity.Nome;
            }
            else
            {
                nomeClube09.Text = Tottenham.Nome;
            }
        }

        private void GerarJogoDois_Click(object sender, EventArgs e)
        {
            // Clube 03
            nomeClube03.Text = Ajax.Nome;
            golsClube03.Text = Convert.ToString(Ajax.Gols);

            // Clube 04
            nomeClube04.Text = Juventus.Nome;
            golsClube04.Text = Convert.ToString(Juventus.Gols);

            var golsTime03 = Convert.ToInt32(golsClube03.Text);
            var golsTime04 = Convert.ToInt32(golsClube04.Text);

            if (golsTime03 > golsTime04)
            {
                nomeClube10.Text = Ajax.Nome;
            }
            else
            {
                nomeClube10.Text = Juventus.Nome;
            }
        }

        private void GerarJogoTres_Click_1(object sender, EventArgs e)
        {
            // Clube 05
            nomeClube05.Text = ManchesterUnited.Nome;
            golsClube05.Text = Convert.ToString(ManchesterUnited.Gols);

            // Clube 06
            nomeClube06.Text = Barcelona.Nome;
            golsClube06.Text = Convert.ToString(Barcelona.Gols);

            var golsTime5 = Convert.ToInt32(golsClube05.Text);
            var golsTime6 = Convert.ToInt32(golsClube06.Text);

            if (golsTime5 > golsTime6)
            {
                nomeClube11.Text = ManchesterUnited.Nome;
            }
            else
            {
                nomeClube11.Text = Barcelona.Nome;
            }
        }

        private void GerarJogoQuatro_Click(object sender, EventArgs e)
        {
            // Clube 07
            nomeClube07.Text = Liverpool.Nome;
            golsClube07.Text = Convert.ToString(Liverpool.Gols);

            // Clube 08
            nomeClube08.Text = Porto.Nome;
            golsClube08.Text = Convert.ToString(Porto.Gols);

            var golsTime7 = Convert.ToInt32(golsClube05.Text);
            var golsTime8 = Convert.ToInt32(golsClube06.Text);

            if (golsTime7 > golsTime8)
            {
                nomeClube12.Text = Liverpool.Nome;
            }
            else
            {
                nomeClube12.Text = Porto.Nome;
            }
        }

        private void GerarJogoCinco_Click(object sender, EventArgs e)
        {
            var clube09 = new Clube();
            clube09.Gols = _geradorNumero.MetodoNumeroAleatorio();

            var clube10 = new Clube();
            clube10.Gols = _geradorNumeroFora.MetodoNumeroAleatorioFora();

            golsClube09.Text = Convert.ToString(clube09.Gols);
            golsClube10.Text = Convert.ToString(clube10.Gols);

            var golsTime09 = Convert.ToInt32(golsClube09.Text);
            var golsTime10 = Convert.ToInt32(golsClube10.Text);

            if (golsTime09 > golsTime10)
            {
                nomeClube13.Text = nomeClube09.Text;
            }
            else
            {
                nomeClube13.Text = nomeClube10.Text;
            }
        }

        private void GerarJogoSeis_Click(object sender, EventArgs e)
        {
            var clube11 = new Clube();
            clube11.Gols = _geradorNumero.MetodoNumeroAleatorio();

            var clube12 = new Clube();
            clube12.Gols = _geradorNumeroFora.MetodoNumeroAleatorioFora();

            golsClube11.Text = Convert.ToString(clube11.Gols);
            golsClube12.Text = Convert.ToString(clube12.Gols);

            var golsTime11 = Convert.ToInt32(golsClube11.Text);
            var golsTime12 = Convert.ToInt32(golsClube12.Text);

            if (golsTime11 > golsTime12)
            {
                nomeClube14.Text = nomeClube11.Text;
            }
            else
            {
                nomeClube14.Text = nomeClube12.Text;
            }
        }

        private void GerarJogoSete_Click(object sender, EventArgs e)
        {
            var clube13 = new Clube();
            clube13.Gols = _geradorNumero.MetodoNumeroAleatorio();

            var clube14 = new Clube();
            clube14.Gols = _geradorNumeroFora.MetodoNumeroAleatorioFora();

            golsClube13.Text = Convert.ToString(clube13.Gols);
            golsClube14.Text = Convert.ToString(clube14.Gols);

            var golsTime13 = Convert.ToInt32(clube13.Gols);
            var golsTime14 = Convert.ToInt32(clube14.Gols);

            if (golsTime13 > golsTime14)
            {
                nomeClube15.Text = nomeClube13.Text;
            }
            else
            {
                nomeClube15.Text = nomeClube14.Text;
            }
        }

        // Lixeira:
        private void GerarJogoTres_Click(object sender, EventArgs e)
        {

        }
        private void clube02_TextChanged(object sender, EventArgs e)
        {

        }
        private void golsClube02_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void nomeClube03_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
