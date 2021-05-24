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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "СМО з обмеженим очікуванням";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            double N = Convert.ToDouble(textN.Text);
            double SL = Convert.ToDouble(textSL.Text);
            double SM = Convert.ToDouble(textSM.Text);
            double M = Convert.ToDouble(textM.Text);
            double RO = SL / SM;
            double XI = RO / N;
            double N1 = N + 1;
            double NM = N + M;
            double M1 = M + 1;
            double XM = Math.Pow(XI, M);
            double XM1 = XM * XI;
            double NN = N;
            double NF = 0;
            double NFF = returnNF(NN, NF);
            double NNF = Math.Pow(N, N) / NFF;

            double XX = 0;
            if (XI != 1)
            {
                XX = NNF * Math.Pow(XI, N1) * (1 - XM) / (1 - XI);
            }
            double S = 1, S1 = 1;

            double[] P = new double[50];
            double KF = 0, SS1 = 0, SS = 0;
            for (int K = 0; K < N; K++)
            {
                NN = K;
                KF = returnNF(NN, NF);
                SS1 = Math.Pow(N, K) / KF;
                SS = SS1 * Math.Pow(XI, K);
                P[K] = SS;
                S = S + SS;
                S1 = S1 + SS1;
            }
            double P0 = 0;
            if (XI != 1)
            {
                P0 = 1 / (S + XX);
            }

            P0 = 1 / (S1 + NNF * M);
            for (int K = 0; K < N; K++)
            {
                P[K] = P[K] * P0;
            }
            P[0] = P0;
            for (int K = Convert.ToInt32( N1 ); K < NM; K++)
            {
                P[K] = NNF * Math.Pow(XI, K) * P0;
            }
            double SP = 0;
            for (int K = 0; K < NM; K++)
            {
                SP = SP + P[K];
            }
            double POT = NNF * Math.Pow(XI, NM) * P0;
            double Q = 1 - POT;
            double A = SL * Q;
            double Kdoub = A / SM;
            double NOSH = 0;
            if (XI != 1)
            {
                NOSH = NNF * Math.Pow(XI, N1) * (1 - M1 * XM + M * XM1) * P0 / Math.Pow((1 - XI), 2);
            }
            NOSH = NNF * M * M1 * P0 / 2;
            double NSIS = Kdoub + NOSH;
            double TOSH = NOSH / SL;
            double TSIS = NSIS / SL;

            labelP0.Text = "P0 = " + P0;
            labelPOT.Text = "POT = " + POT;
            labelA.Text = "A = " + A;
            labelQ.Text = "Q = " + Q;
            labelK.Text = "K = " + Kdoub;
            labelNOSH.Text = "NOSH = " + NOSH;
            labelNSIS.Text = "NSIS = " + NSIS;
            labelTOSH.Text = "TOSH = " + TOSH;
            labelTSIS.Text = "TSIS = " + TSIS;
            labelSP.Text = "SP = " + SP;
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

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            Menu runmenu = new Menu();
            runmenu.ShowDialog();
            Close();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
