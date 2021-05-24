
namespace CMO
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textN = new System.Windows.Forms.TextBox();
            this.textSL = new System.Windows.Forms.TextBox();
            this.textSM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelP0 = new System.Windows.Forms.Label();
            this.labelPOT = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.labelK = new System.Windows.Forms.Label();
            this.labelNOSH = new System.Windows.Forms.Label();
            this.labelNSIS = new System.Windows.Forms.Label();
            this.labelTOSH = new System.Windows.Forms.Label();
            this.labelTSIS = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textI = new System.Windows.Forms.TextBox();
            this.labelP_I = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(356, 164);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Число каналів обслуговування N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Інтенсивність входящого потоку заявок SL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Інтенсивність потока обслуговування заявок SM";
            // 
            // textN
            // 
            this.textN.Location = new System.Drawing.Point(304, 17);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(100, 20);
            this.textN.TabIndex = 4;
            this.textN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSL
            // 
            this.textSL.Location = new System.Drawing.Point(304, 62);
            this.textSL.Name = "textSL";
            this.textSL.Size = new System.Drawing.Size(100, 20);
            this.textSL.TabIndex = 5;
            this.textSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSM
            // 
            this.textSM.Location = new System.Drawing.Point(304, 109);
            this.textSM.Name = "textSM";
            this.textSM.Size = new System.Drawing.Size(100, 20);
            this.textSM.TabIndex = 6;
            this.textSM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ймовірність простоя каналу:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ймовірність відмови:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Абсолютна пропускна здатність:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Відносна пропускна здатність:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Середнє число занятих каналів:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Середнє число заявок в черзі:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Середнє число заявок в системі:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 415);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Середній час в черзі:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 443);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Середній час в системі:";
            // 
            // labelP0
            // 
            this.labelP0.AutoSize = true;
            this.labelP0.Location = new System.Drawing.Point(301, 219);
            this.labelP0.Name = "labelP0";
            this.labelP0.Size = new System.Drawing.Size(32, 13);
            this.labelP0.TabIndex = 16;
            this.labelP0.Text = "P0 = ";
            // 
            // labelPOT
            // 
            this.labelPOT.AutoSize = true;
            this.labelPOT.Location = new System.Drawing.Point(301, 247);
            this.labelPOT.Name = "labelPOT";
            this.labelPOT.Size = new System.Drawing.Size(41, 13);
            this.labelPOT.TabIndex = 17;
            this.labelPOT.Text = "POT = ";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(301, 275);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(26, 13);
            this.labelA.TabIndex = 18;
            this.labelA.Text = "A = ";
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Location = new System.Drawing.Point(301, 303);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(27, 13);
            this.labelQ.TabIndex = 19;
            this.labelQ.Text = "Q = ";
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Location = new System.Drawing.Point(301, 331);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(26, 13);
            this.labelK.TabIndex = 20;
            this.labelK.Text = "K = ";
            // 
            // labelNOSH
            // 
            this.labelNOSH.AutoSize = true;
            this.labelNOSH.Location = new System.Drawing.Point(301, 359);
            this.labelNOSH.Name = "labelNOSH";
            this.labelNOSH.Size = new System.Drawing.Size(50, 13);
            this.labelNOSH.TabIndex = 21;
            this.labelNOSH.Text = "NOSH = ";
            // 
            // labelNSIS
            // 
            this.labelNSIS.AutoSize = true;
            this.labelNSIS.Location = new System.Drawing.Point(301, 387);
            this.labelNSIS.Name = "labelNSIS";
            this.labelNSIS.Size = new System.Drawing.Size(41, 13);
            this.labelNSIS.TabIndex = 22;
            this.labelNSIS.Text = "NSIS =";
            // 
            // labelTOSH
            // 
            this.labelTOSH.AutoSize = true;
            this.labelTOSH.Location = new System.Drawing.Point(301, 415);
            this.labelTOSH.Name = "labelTOSH";
            this.labelTOSH.Size = new System.Drawing.Size(49, 13);
            this.labelTOSH.TabIndex = 23;
            this.labelTOSH.Text = "TOSH = ";
            // 
            // labelTSIS
            // 
            this.labelTSIS.AutoSize = true;
            this.labelTSIS.Location = new System.Drawing.Point(301, 443);
            this.labelTSIS.Name = "labelTSIS";
            this.labelTSIS.Size = new System.Drawing.Size(43, 13);
            this.labelTSIS.TabIndex = 24;
            this.labelTSIS.Text = "TSIS = ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(547, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Введіть номер стану І:";
            // 
            // textI
            // 
            this.textI.Location = new System.Drawing.Point(569, 50);
            this.textI.Name = "textI";
            this.textI.Size = new System.Drawing.Size(100, 20);
            this.textI.TabIndex = 26;
            this.textI.Text = "0";
            this.textI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelP_I
            // 
            this.labelP_I.AutoSize = true;
            this.labelP_I.Location = new System.Drawing.Point(477, 90);
            this.labelP_I.Name = "labelP_I";
            this.labelP_I.Size = new System.Drawing.Size(105, 13);
            this.labelP_I.TabIndex = 27;
            this.labelP_I.Text = "Ймовірність стану: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DodgerBlue;
            this.exit.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.DarkRed;
            this.exit.Location = new System.Drawing.Point(594, 486);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(81, 34);
            this.exit.TabIndex = 39;
            this.exit.Text = "Вихід";
            this.exit.UseMnemonic = false;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 532);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelP_I);
            this.Controls.Add(this.textI);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelTSIS);
            this.Controls.Add(this.labelTOSH);
            this.Controls.Add(this.labelNSIS);
            this.Controls.Add(this.labelNOSH);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelPOT);
            this.Controls.Add(this.labelP0);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSM);
            this.Controls.Add(this.textSL);
            this.Controls.Add(this.textN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.TextBox textSL;
        private System.Windows.Forms.TextBox textSM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelP0;
        private System.Windows.Forms.Label labelPOT;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.Label labelNOSH;
        private System.Windows.Forms.Label labelNSIS;
        private System.Windows.Forms.Label labelTOSH;
        private System.Windows.Forms.Label labelTSIS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textI;
        private System.Windows.Forms.Label labelP_I;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exit;
    }
}

