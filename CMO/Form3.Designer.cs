
namespace CMO
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textSM = new System.Windows.Forms.TextBox();
            this.textSL = new System.Windows.Forms.TextBox();
            this.textN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textM = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTSIS = new System.Windows.Forms.Label();
            this.labelTOSH = new System.Windows.Forms.Label();
            this.labelNSIS = new System.Windows.Forms.Label();
            this.labelNOSH = new System.Windows.Forms.Label();
            this.labelK = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelP0 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPOT = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelSP = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Інтенсивність потоку обслуговування заявок SM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Інтенсивність вхідного потоку заявок SL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Число каналів обслуговування N";
            // 
            // textSM
            // 
            this.textSM.Location = new System.Drawing.Point(317, 60);
            this.textSM.Name = "textSM";
            this.textSM.Size = new System.Drawing.Size(100, 20);
            this.textSM.TabIndex = 6;
            // 
            // textSL
            // 
            this.textSL.Location = new System.Drawing.Point(317, 33);
            this.textSL.Name = "textSL";
            this.textSL.Size = new System.Drawing.Size(100, 20);
            this.textSL.TabIndex = 7;
            // 
            // textN
            // 
            this.textN.Location = new System.Drawing.Point(317, 6);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(100, 20);
            this.textN.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Кількість мість в черзі М";
            // 
            // textM
            // 
            this.textM.Location = new System.Drawing.Point(317, 86);
            this.textM.Name = "textM";
            this.textM.Size = new System.Drawing.Size(100, 20);
            this.textM.TabIndex = 6;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(192, 152);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 465);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Середній час в системі:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 429);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Середній час в черзі:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 397);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Середнє число заявок в системі:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Середнє число заявок в черзі:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Середнє число занятих каналів:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Відносна пропускна здатність:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Абсолютна пропускна здатність:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Ймовірність простоя каналів:";
            // 
            // labelTSIS
            // 
            this.labelTSIS.AutoSize = true;
            this.labelTSIS.Location = new System.Drawing.Point(277, 465);
            this.labelTSIS.Name = "labelTSIS";
            this.labelTSIS.Size = new System.Drawing.Size(43, 13);
            this.labelTSIS.TabIndex = 51;
            this.labelTSIS.Text = "TSIS = ";
            // 
            // labelTOSH
            // 
            this.labelTOSH.AutoSize = true;
            this.labelTOSH.Location = new System.Drawing.Point(277, 429);
            this.labelTOSH.Name = "labelTOSH";
            this.labelTOSH.Size = new System.Drawing.Size(49, 13);
            this.labelTOSH.TabIndex = 52;
            this.labelTOSH.Text = "TOSH = ";
            // 
            // labelNSIS
            // 
            this.labelNSIS.AutoSize = true;
            this.labelNSIS.Location = new System.Drawing.Point(277, 397);
            this.labelNSIS.Name = "labelNSIS";
            this.labelNSIS.Size = new System.Drawing.Size(44, 13);
            this.labelNSIS.TabIndex = 53;
            this.labelNSIS.Text = "NSIS = ";
            // 
            // labelNOSH
            // 
            this.labelNOSH.AutoSize = true;
            this.labelNOSH.Location = new System.Drawing.Point(277, 364);
            this.labelNOSH.Name = "labelNOSH";
            this.labelNOSH.Size = new System.Drawing.Size(50, 13);
            this.labelNOSH.TabIndex = 54;
            this.labelNOSH.Text = "NOSH = ";
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Location = new System.Drawing.Point(277, 335);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(26, 13);
            this.labelK.TabIndex = 55;
            this.labelK.Text = "K = ";
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Location = new System.Drawing.Point(277, 303);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(27, 13);
            this.labelQ.TabIndex = 56;
            this.labelQ.Text = "Q = ";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(277, 271);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(26, 13);
            this.labelA.TabIndex = 57;
            this.labelA.Text = "A = ";
            // 
            // labelP0
            // 
            this.labelP0.AutoSize = true;
            this.labelP0.Location = new System.Drawing.Point(277, 214);
            this.labelP0.Name = "labelP0";
            this.labelP0.Size = new System.Drawing.Size(32, 13);
            this.labelP0.TabIndex = 58;
            this.labelP0.Text = "P0 = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ймовірність відмови:";
            // 
            // labelPOT
            // 
            this.labelPOT.AutoSize = true;
            this.labelPOT.Location = new System.Drawing.Point(277, 243);
            this.labelPOT.Name = "labelPOT";
            this.labelPOT.Size = new System.Drawing.Size(38, 13);
            this.labelPOT.TabIndex = 58;
            this.labelPOT.Text = "POT =";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 494);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Нормальна умова:";
            // 
            // labelSP
            // 
            this.labelSP.AutoSize = true;
            this.labelSP.Location = new System.Drawing.Point(277, 494);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(33, 13);
            this.labelSP.TabIndex = 51;
            this.labelSP.Text = "SP = ";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DodgerBlue;
            this.exit.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.DarkRed;
            this.exit.Location = new System.Drawing.Point(349, 532);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(81, 34);
            this.exit.TabIndex = 60;
            this.exit.Text = "Вихід";
            this.exit.UseMnemonic = false;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 543);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 59;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 578);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.back);
            this.Controls.Add(this.labelSP);
            this.Controls.Add(this.labelTSIS);
            this.Controls.Add(this.labelTOSH);
            this.Controls.Add(this.labelNSIS);
            this.Controls.Add(this.labelNOSH);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelPOT);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labelP0);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textM);
            this.Controls.Add(this.textSM);
            this.Controls.Add(this.textSL);
            this.Controls.Add(this.textN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSM;
        private System.Windows.Forms.TextBox textSL;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textM;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTSIS;
        private System.Windows.Forms.Label labelTOSH;
        private System.Windows.Forms.Label labelNSIS;
        private System.Windows.Forms.Label labelNOSH;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelP0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPOT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button back;
    }
}