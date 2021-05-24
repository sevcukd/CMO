using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Многоканальная СМО с ожиданием";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            double N = Convert.ToDouble(textN.Text);
            double SL = Convert.ToDouble(textSL.Text);
            double SM = Convert.ToDouble(textSM.Text);
            double RO = SL / SM;
            double XI = RO / N;
            double N1 = N + 1;
            double NN = N;
            double NF = 0, KF=0, SS1, SS;
            //returnNF(NN, NF);
            double NFF = returnNF(NN,NF);
            double NNF = Math.Pow(N, N) / NFF;
            double S = 1, S1 = 1;
            double[] P = new double[Convert.ToInt32(N)];
            P[0] = 1;
            for (int Ki = 1; Ki < N; Ki++)
            {
                NN = Ki;
                KF = returnNF(NN, NF);
                SS1 = Math.Pow(N, Ki) / KF;
                SS = SS1 * Math.Pow(XI, Ki);
                P[Ki] = SS;
                S = SS + S;
            }
            double P0 = 1 / (S + NNF * Math.Pow(XI, N1) / (1 - XI));
            double POT = 0, Q = 1, A = SL;
            double K = RO;
            double NOSH = NNF * Math.Pow(XI, N1) * P0 / Math.Pow(1 - XI, 2);
            double NSIS = K + NOSH;
            double TOSH = NOSH / SL;
            double TSIS = NSIS / SL;


            labelP0.Text = "P0 = " + P0;
            labelPOT.Text = "POT = " + POT;
            labelA.Text = "A = " + A;
            labelQ.Text = "Q = " + Q;
            labelK.Text = "K = " + K;
            labelNOSH.Text = "NOSH = " + NOSH;
            labelNSIS.Text = "NSIS = " + NSIS;
            labelTOSH.Text = "TOSH = " + TOSH;
            labelTSIS.Text = "TSIS = " + TSIS;



            double I = Convert.ToDouble(textI.Text);
            if (I<=N)
            {
                P[Convert.ToInt32(I)] = P[Convert.ToInt32(I)] * K;
            }
            else
            {
                P[Convert.ToInt32(I)] = NNF * Math.Pow(XI, I) * P0;
            }
            labelP_I.Text = "Вероятность состояния: " + P[Convert.ToInt32(I)];
        }

        public double returnNF(double NN, double NF)
        {
            NF = 1;
            if (NN == 0)
            {
                return NF;
            }
            else
            {
                for (int i = 1; i < NN; i++)
                {
                    NF = NF * i;
                }
            }
            return NF;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Menu runmenu = new Menu();
            runmenu.ShowDialog();
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
