
namespace CMO
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textN = new System.Windows.Forms.TextBox();
            this.textSL = new System.Windows.Forms.TextBox();
            this.textSM = new System.Windows.Forms.TextBox();
            this.textOM = new System.Windows.Forms.TextBox();
            this.textEPS = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelP0 = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.labelK = new System.Windows.Forms.Label();
            this.labelNOSH = new System.Windows.Forms.Label();
            this.labelNSIS = new System.Windows.Forms.Label();
            this.labelTOSH = new System.Windows.Forms.Label();
            this.labelTSIS = new System.Windows.Forms.Label();
            this.labelTEST = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число каналів обслуговування N";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Інтенсивність вхідного потоку заявок SL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Інтенсивність потоку обслуговування заявок SM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Інтенсивність потоку виходів OM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Точність вираховування суми безкінечного ряду EPS";
            // 
            // textN
            // 
            this.textN.Location = new System.Drawing.Point(344, 8);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(100, 20);
            this.textN.TabIndex = 4;
            // 
            // textSL
            // 
            this.textSL.Location = new System.Drawing.Point(344, 35);
            this.textSL.Name = "textSL";
            this.textSL.Size = new System.Drawing.Size(100, 20);
            this.textSL.TabIndex = 4;
            // 
            // textSM
            // 
            this.textSM.Location = new System.Drawing.Point(344, 62);
            this.textSM.Name = "textSM";
            this.textSM.Size = new System.Drawing.Size(100, 20);
            this.textSM.TabIndex = 4;
            // 
            // textOM
            // 
            this.textOM.Location = new System.Drawing.Point(344, 87);
            this.textOM.Name = "textOM";
            this.textOM.Size = new System.Drawing.Size(100, 20);
            this.textOM.TabIndex = 4;
            // 
            // textEPS
            // 
            this.textEPS.Location = new System.Drawing.Point(344, 112);
            this.textEPS.Name = "textEPS";
            this.textEPS.Size = new System.Drawing.Size(100, 20);
            this.textEPS.TabIndex = 4;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(202, 173);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DodgerBlue;
            this.exit.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.DarkRed;
            this.exit.Location = new System.Drawing.Point(373, 523);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(81, 34);
            this.exit.TabIndex = 41;
            this.exit.Text = "Вихід";
            this.exit.UseMnemonic = false;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 534);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 40;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Ймовірність простоя каналів:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Абсолютна пропускна здатність:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Відносна пропускна здатність:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Середнє число занятих каналів:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Середнє число заявок в черзі:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Середнє число заявок в системі:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 441);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Середній час в черзі:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 477);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Середній час в системі:";
            // 
            // labelP0
            // 
            this.labelP0.AutoSize = true;
            this.labelP0.Location = new System.Drawing.Point(286, 251);
            this.labelP0.Name = "labelP0";
            this.labelP0.Size = new System.Drawing.Size(32, 13);
            this.labelP0.TabIndex = 42;
            this.labelP0.Text = "P0 = ";
            this.labelP0.Click += new System.EventHandler(this.label14_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(286, 283);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(26, 13);
            this.labelA.TabIndex = 42;
            this.labelA.Text = "A = ";
            this.labelA.Click += new System.EventHandler(this.label15_Click);
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Location = new System.Drawing.Point(286, 315);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(27, 13);
            this.labelQ.TabIndex = 42;
            this.labelQ.Text = "Q = ";
            this.labelQ.Click += new System.EventHandler(this.label16_Click);
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Location = new System.Drawing.Point(286, 347);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(26, 13);
            this.labelK.TabIndex = 42;
            this.labelK.Text = "K = ";
            this.labelK.Click += new System.EventHandler(this.label17_Click);
            // 
            // labelNOSH
            // 
            this.labelNOSH.AutoSize = true;
            this.labelNOSH.Location = new System.Drawing.Point(286, 376);
            this.labelNOSH.Name = "labelNOSH";
            this.labelNOSH.Size = new System.Drawing.Size(50, 13);
            this.labelNOSH.TabIndex = 42;
            this.labelNOSH.Text = "NOSH = ";
            this.labelNOSH.Click += new System.EventHandler(this.label18_Click);
            // 
            // labelNSIS
            // 
            this.labelNSIS.AutoSize = true;
            this.labelNSIS.Location = new System.Drawing.Point(286, 409);
            this.labelNSIS.Name = "labelNSIS";
            this.labelNSIS.Size = new System.Drawing.Size(44, 13);
            this.labelNSIS.TabIndex = 42;
            this.labelNSIS.Text = "NSIS = ";
            this.labelNSIS.Click += new System.EventHandler(this.label19_Click);
            // 
            // labelTOSH
            // 
            this.labelTOSH.AutoSize = true;
            this.labelTOSH.Location = new System.Drawing.Point(286, 441);
            this.labelTOSH.Name = "labelTOSH";
            this.labelTOSH.Size = new System.Drawing.Size(49, 13);
            this.labelTOSH.TabIndex = 42;
            this.labelTOSH.Text = "TOSH = ";
            this.labelTOSH.Click += new System.EventHandler(this.label20_Click);
            // 
            // labelTSIS
            // 
            this.labelTSIS.AutoSize = true;
            this.labelTSIS.Location = new System.Drawing.Point(286, 477);
            this.labelTSIS.Name = "labelTSIS";
            this.labelTSIS.Size = new System.Drawing.Size(31, 13);
            this.labelTSIS.TabIndex = 42;
            this.labelTSIS.Text = "TSIS";
            this.labelTSIS.Click += new System.EventHandler(this.label21_Click);
            // 
            // labelTEST
            // 
            this.labelTEST.AutoSize = true;
            this.labelTEST.Location = new System.Drawing.Point(344, 195);
            this.labelTEST.Name = "labelTEST";
            this.labelTEST.Size = new System.Drawing.Size(35, 13);
            this.labelTEST.TabIndex = 43;
            this.labelTEST.Text = "TEST";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 569);
            this.Controls.Add(this.labelTEST);
            this.Controls.Add(this.labelTSIS);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelTOSH);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelNSIS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelNOSH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelP0);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.back);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textEPS);
            this.Controls.Add(this.textOM);
            this.Controls.Add(this.textSM);
            this.Controls.Add(this.textSL);
            this.Controls.Add(this.textN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.TextBox textSL;
        private System.Windows.Forms.TextBox textSM;
        private System.Windows.Forms.TextBox textOM;
        private System.Windows.Forms.TextBox textEPS;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelP0;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.Label labelNOSH;
        private System.Windows.Forms.Label labelNSIS;
        private System.Windows.Forms.Label labelTOSH;
        private System.Windows.Forms.Label labelTSIS;
        private System.Windows.Forms.Label labelTEST;
    }
}