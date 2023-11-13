namespace Komplexni_cisla
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ödecti = new System.Windows.Forms.Button();
            this.nasob = new System.Windows.Forms.Button();
            this.absolut_hodno = new System.Windows.Forms.Button();
            this.sdruzeni = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(166, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Komplexní čísla kalkulačka";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(37, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 80);
            this.button1.TabIndex = 1;
            this.button1.Tag = "Sčítání komplexních čísel";
            this.button1.Text = "Sčítání";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ödecti
            // 
            this.ödecti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ödecti.BackColor = System.Drawing.Color.DarkKhaki;
            this.ödecti.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ödecti.Location = new System.Drawing.Point(282, 116);
            this.ödecti.Margin = new System.Windows.Forms.Padding(4);
            this.ödecti.Name = "ödecti";
            this.ödecti.Size = new System.Drawing.Size(186, 80);
            this.ödecti.TabIndex = 2;
            this.ödecti.Text = "Odčítání";
            this.ödecti.UseVisualStyleBackColor = false;
            this.ödecti.Click += new System.EventHandler(this.ödecti_Click);
            // 
            // nasob
            // 
            this.nasob.BackColor = System.Drawing.Color.DarkKhaki;
            this.nasob.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nasob.Location = new System.Drawing.Point(522, 116);
            this.nasob.Margin = new System.Windows.Forms.Padding(4);
            this.nasob.Name = "nasob";
            this.nasob.Size = new System.Drawing.Size(203, 80);
            this.nasob.TabIndex = 3;
            this.nasob.Text = "Násobení";
            this.nasob.UseVisualStyleBackColor = false;
            this.nasob.Click += new System.EventHandler(this.nasob_Click);
            // 
            // absolut_hodno
            // 
            this.absolut_hodno.BackColor = System.Drawing.Color.DarkKhaki;
            this.absolut_hodno.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.absolut_hodno.Location = new System.Drawing.Point(151, 241);
            this.absolut_hodno.Margin = new System.Windows.Forms.Padding(4);
            this.absolut_hodno.Name = "absolut_hodno";
            this.absolut_hodno.Size = new System.Drawing.Size(226, 102);
            this.absolut_hodno.TabIndex = 4;
            this.absolut_hodno.Text = "Absolutní hodnota";
            this.absolut_hodno.UseVisualStyleBackColor = false;
            this.absolut_hodno.Click += new System.EventHandler(this.absolut_hodno_Click);
            // 
            // sdruzeni
            // 
            this.sdruzeni.BackColor = System.Drawing.Color.DarkKhaki;
            this.sdruzeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sdruzeni.Location = new System.Drawing.Point(414, 241);
            this.sdruzeni.Margin = new System.Windows.Forms.Padding(4);
            this.sdruzeni.Name = "sdruzeni";
            this.sdruzeni.Size = new System.Drawing.Size(244, 102);
            this.sdruzeni.TabIndex = 5;
            this.sdruzeni.Text = "Komplexně sdružený";
            this.sdruzeni.UseVisualStyleBackColor = false;
            this.sdruzeni.Click += new System.EventHandler(this.sdruzeni_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(4, 484);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vytvořil: Michal Zděnek";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkKhaki;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(251, 368);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 102);
            this.button2.TabIndex = 7;
            this.button2.Text = "Goniometrický tvar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(787, 505);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sdruzeni);
            this.Controls.Add(this.absolut_hodno);
            this.Controls.Add(this.nasob);
            this.Controls.Add(this.ödecti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulačka na komplexní čísla";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ödecti;
        private System.Windows.Forms.Button nasob;
        private System.Windows.Forms.Button absolut_hodno;
        private System.Windows.Forms.Button sdruzeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

