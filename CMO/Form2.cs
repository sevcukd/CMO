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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Многоканальна СМО з нетерплячими заявками";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            double N = Convert.ToDouble(textN.Text);
            double SL = Convert.ToDouble(textSL.Text);
            double SM = Convert.ToDouble(textSM.Text);
            double OM = Convert.ToDouble(textOM.Text);
            double EPS = Convert.ToDouble(textEPS.Text);
            double RO = SL / SM;
            double BE = OM / SM;
            double XI = RO / N;
            double NSM = 1 / (N * SM);
            double RR = RO / OM;
            double NF = 0;

            double RRR = 0;
            int IKI = 1;
            double NN = 0;
            double IRR = 0,IRN = 0, ER=0;
            do
            {
                IKI += 1;
                NN = Convert.ToDouble(IKI);
                IRR = returnNF(NN, NF);
                IRN = Math.Pow(RR, IKI) / IRR;
                ER = Math.Exp(RR);
                RRR = IRN * ER;
            } while (RRR > EPS);
            

            double NSUM = IKI - 1;
            //////////////////////ВИВІД NSUM ///////////////////
            //labelTEST.Text = NSUM+" ";
            int IN;
            if (OM != 0)
            {
                IN = Convert.ToInt32(N / BE + 0.5);
            }
            else IN = 10000000;
            NN = N;
            double NFF = returnNF(NN, NF);
            double RNN = Math.Pow(RO, N) / NFF;

            double S0 = 1;
            double KF = 0, SS = 0;
            double[] P = new double[100];
            double K = 0;
            for (int i = 0; i < N; i++)
            {
                K = i;
                NN = K;
                KF = returnNF(NN, NF);
                SS = Math.Pow(RO, K) / KF;
                P[i] = SS;
                S0 = S0 + SS;
            }
            
            double S1 = 0, S2 = 0, S3 = 0, S4 = 0;
            K = N;
            double KN = 0, RK = 0, PP = 1, NK = 0, NI2 = 0;
            double A = 0;
            for (int LL = 0; LL < NSUM; LL++)
            {
                K = K + 1;
                KN = K * N;
                RK = Math.Pow(RO, KN);
                for (int I = 0; I < KN; I++)
                {
                    PP = PP * (N + I * BE);
                }
                P[Convert.ToInt32(K)] = PP;
                A = RK / PP;
                S1 = S1 + A;
                S2 = S2 + A * KN;
                NK = K;
                if (IN < 3) 
                {
                    continue;
                }
                NI2 = N + IN - 2;
                if (K > NI2)
                {
                    S4 = S4 + A;
                }
                else S3 = S3 + (K - N + 1) * A;
            }
            S1 = S1 * RNN;
            double P0 = 1 / (S0 + S1);
            P[0] = 0;
            double SP = P0;
            double RP0 = RNN * P0;
            double NOSH = RP0 * S2;
            Console.WriteLine(NOSH+"_____"+RP0+"______"+S2);
            for (int i = 0; i < N; i++)//K == i
            {
                P[i] = P[i] * P0;
                SP = SP + P[i];
            }
            double N1 = N + 1;
            for (int i = Convert.ToInt32(N1); i < NK; i++)//K==i
            {
                P[i] = P0 * Math.Pow(RO, K) / (P[i] * NFF);
                SP = SP + P[i];
            }
            double TOSH = 0;
            if (OM == 0)
            {
                TOSH = Math.Pow(N, N) * P0 * Math.Pow(XI, N1) / (SL * NFF * Math.Pow(1 - XI, 2));
            }
            if (IN == 1)
            {
                TOSH = RP0 * (1 + S1) / OM;
            }
            if (IN==2)
            {
                TOSH = RP0 * (NSM + 1 / OM * S1);
            }
            if (IN==3)
            {
                TOSH = RP0 * (NSM + NSM * S3 + 1 / OM * S4);
            }
            /////////Вивід SP//////

            A = SL - NOSH * OM;
            double Q = A / SL;
            K = A / SM;
            double NSIS = K + NOSH;
            double TSIS = TOSH + Q / SM;

            labelP0.Text = "P0 = " + P0;
            labelA.Text = "A = " + A;
            labelQ.Text = "Q = " + Q;
            labelK.Text = "K = " + K;
            labelNOSH.Text = "NOSH = " + NOSH;
            labelNSIS.Text = "NSIS = " + NSIS;
            labelTOSH.Text = "TOSH = " + TOSH;
            labelTSIS.Text = "TSIS = " + TSIS;
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
