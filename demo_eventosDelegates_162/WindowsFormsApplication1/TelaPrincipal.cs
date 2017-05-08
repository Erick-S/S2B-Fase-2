using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lampadas;


namespace WindowsFormsApplication1
{
    public partial class TelaPrincipal : Form
    {
        Lampada lamp = new Lampada();

        public TelaPrincipal()
        {
            InitializeComponent();
        }



        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            lamp.LampQueimadaEvento += new NotificacaoLampada(tratador_LampadaQueimada);
            lamp.LampQueimadaEvento += tratador_LampadaQueimada;

        }

        private void tratador_LampadaQueimada(string  msg)
        {
            cmdAcende.Visible = false;
            cmdApaga.Visible = false;
            MessageBox.Show(msg, "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);

        }

        private void cmdAcende_Click(object sender, EventArgs e)
        {
            lamp.acende();
            this.mostraSituacao(lamp.situacao());


        }

        private void cmdApaga_Click(object sender, EventArgs e)
        {
            lamp.apaga();
            this.mostraSituacao(lamp.situacao());

        }

        private void cmdNova_Click(object sender, EventArgs e)
        {  
            cmdAcende.Visible = true;
            cmdApaga.Visible = true;
            lamp.novaLampada();
            mostraSituacao(lamp.situacao());

        }

        private void mostraSituacao(EstadoLampada e)
        {
            switch (e)
            {
                case EstadoLampada.Acesa: pictureBox1.Load("LampadaAcesa.jpg"); break;
                case EstadoLampada.Apagada: pictureBox1.Load("LampadaApagada.jpg"); break;
                case EstadoLampada.Queimada: pictureBox1.Load("LampadaQueimada.jpg"); break;
            }

        }
    }
}

