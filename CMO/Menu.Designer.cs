
namespace CMO
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.runForm1 = new System.Windows.Forms.Button();
            this.runForm2 = new System.Windows.Forms.Button();
            this.runForm3 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // runForm1
            // 
            this.runForm1.Location = new System.Drawing.Point(139, 131);
            this.runForm1.Name = "runForm1";
            this.runForm1.Size = new System.Drawing.Size(214, 28);
            this.runForm1.TabIndex = 0;
            this.runForm1.Text = "Багатоканальна СМО з очікуванням";
            this.runForm1.UseVisualStyleBackColor = true;
            this.runForm1.Click += new System.EventHandler(this.runForm1_Click);
            // 
            // runForm2
            // 
            this.runForm2.Location = new System.Drawing.Point(99, 181);
            this.runForm2.Name = "runForm2";
            this.runForm2.Size = new System.Drawing.Size(300, 24);
            this.runForm2.TabIndex = 1;
            this.runForm2.Text = "Багатоканальна СМО з  нетерплячими заявками";
            this.runForm2.UseVisualStyleBackColor = true;
            this.runForm2.Click += new System.EventHandler(this.runForm2_Click);
            // 
            // runForm3
            // 
            this.runForm3.Location = new System.Drawing.Point(139, 222);
            this.runForm3.Name = "runForm3";
            this.runForm3.Size = new System.Drawing.Size(214, 30);
            this.runForm3.TabIndex = 2;
            this.runForm3.Text = "СМО з обмеженим очікуванням";
            this.runForm3.UseVisualStyleBackColor = true;
            this.runForm3.Click += new System.EventHandler(this.runForm3_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DodgerBlue;
            this.exit.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.DarkRed;
            this.exit.Location = new System.Drawing.Point(203, 333);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(81, 34);
            this.exit.TabIndex = 42;
            this.exit.Text = "Вихід";
            this.exit.UseMnemonic = false;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 379);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.runForm3);
            this.Controls.Add(this.runForm2);
            this.Controls.Add(this.runForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button runForm1;
        private System.Windows.Forms.Button runForm2;
        private System.Windows.Forms.Button runForm3;
        private System.Windows.Forms.Button exit;
    }
}