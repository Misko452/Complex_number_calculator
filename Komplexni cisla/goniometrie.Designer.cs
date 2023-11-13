namespace Komplexni_cisla
{
    partial class goniometrie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(goniometrie));
            this.label3 = new System.Windows.Forms.Label();
            this.prubeh_a_vysledek = new System.Windows.Forms.TextBox();
            this.pustup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.imag_cisloA = new System.Windows.Forms.TextBox();
            this.realne_cisloA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 580);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Vytvořil: Michal Zděnek";
            // 
            // prubeh_a_vysledek
            // 
            this.prubeh_a_vysledek.BackColor = System.Drawing.Color.WhiteSmoke;
            this.prubeh_a_vysledek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prubeh_a_vysledek.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prubeh_a_vysledek.Location = new System.Drawing.Point(13, 332);
            this.prubeh_a_vysledek.Margin = new System.Windows.Forms.Padding(4);
            this.prubeh_a_vysledek.Name = "prubeh_a_vysledek";
            this.prubeh_a_vysledek.ReadOnly = true;
            this.prubeh_a_vysledek.Size = new System.Drawing.Size(758, 56);
            this.prubeh_a_vysledek.TabIndex = 28;
            this.prubeh_a_vysledek.Text = "a = ";
            // 
            // pustup
            // 
            this.pustup.BackColor = System.Drawing.Color.DarkKhaki;
            this.pustup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pustup.Location = new System.Drawing.Point(286, 437);
            this.pustup.Margin = new System.Windows.Forms.Padding(4);
            this.pustup.Name = "pustup";
            this.pustup.Size = new System.Drawing.Size(207, 89);
            this.pustup.TabIndex = 27;
            this.pustup.Text = "Ukaž postup";
            this.pustup.UseVisualStyleBackColor = false;
            this.pustup.Click += new System.EventHandler(this.pustup_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(311, 213);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 70);
            this.button1.TabIndex = 26;
            this.button1.Text = "Převeď";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(612, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 31);
            this.label4.TabIndex = 21;
            this.label4.Text = "i";
            // 
            // imag_cisloA
            // 
            this.imag_cisloA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.imag_cisloA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imag_cisloA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imag_cisloA.Location = new System.Drawing.Point(409, 105);
            this.imag_cisloA.Margin = new System.Windows.Forms.Padding(4);
            this.imag_cisloA.Name = "imag_cisloA";
            this.imag_cisloA.Size = new System.Drawing.Size(195, 37);
            this.imag_cisloA.TabIndex = 20;
            // 
            // realne_cisloA
            // 
            this.realne_cisloA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.realne_cisloA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.realne_cisloA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.realne_cisloA.Location = new System.Drawing.Point(171, 105);
            this.realne_cisloA.Margin = new System.Windows.Forms.Padding(4);
            this.realne_cisloA.Name = "realne_cisloA";
            this.realne_cisloA.Size = new System.Drawing.Size(192, 37);
            this.realne_cisloA.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(105, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "a = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(136, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 48);
            this.label1.TabIndex = 17;
            this.label1.Text = "Komplexní čísla kalkulačka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(371, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 31);
            this.label6.TabIndex = 30;
            this.label6.Text = "+";
            // 
            // goniometrie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(784, 602);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prubeh_a_vysledek);
            this.Controls.Add(this.pustup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imag_cisloA);
            this.Controls.Add(this.realne_cisloA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "goniometrie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Převádění z algebraického tvaru (běžný výraz) na goniometrický";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prubeh_a_vysledek;
        private System.Windows.Forms.Button pustup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imag_cisloA;
        private System.Windows.Forms.TextBox realne_cisloA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}