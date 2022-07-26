namespace Ndp_Proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstBoxCam = new System.Windows.Forms.ListBox();
            this.lstBoxKagit = new System.Windows.Forms.ListBox();
            this.lstBoxMetal = new System.Windows.Forms.ListBox();
            this.clearOrg = new System.Windows.Forms.Button();
            this.clearMetal = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBoxOrg = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pctrBoxAtik = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblPuan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnOrg = new System.Windows.Forms.Button();
            this.btnMetal = new System.Windows.Forms.Button();
            this.btnKagit = new System.Windows.Forms.Button();
            this.btnCam = new System.Windows.Forms.Button();
            this.prgBarOrg = new System.Windows.Forms.ProgressBar();
            this.prgBarCam = new System.Windows.Forms.ProgressBar();
            this.prgBarKagit = new System.Windows.Forms.ProgressBar();
            this.prgBarMetal = new System.Windows.Forms.ProgressBar();
            this.clearKagit = new System.Windows.Forms.Button();
            this.clearCam = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxAtik)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBoxCam
            // 
            this.lstBoxCam.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstBoxCam.FormattingEnabled = true;
            this.lstBoxCam.Location = new System.Drawing.Point(4, 30);
            this.lstBoxCam.Margin = new System.Windows.Forms.Padding(2);
            this.lstBoxCam.Name = "lstBoxCam";
            this.lstBoxCam.Size = new System.Drawing.Size(104, 160);
            this.lstBoxCam.TabIndex = 1;
            // 
            // lstBoxKagit
            // 
            this.lstBoxKagit.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstBoxKagit.FormattingEnabled = true;
            this.lstBoxKagit.Location = new System.Drawing.Point(7, 30);
            this.lstBoxKagit.Margin = new System.Windows.Forms.Padding(2);
            this.lstBoxKagit.Name = "lstBoxKagit";
            this.lstBoxKagit.Size = new System.Drawing.Size(104, 160);
            this.lstBoxKagit.TabIndex = 2;
            // 
            // lstBoxMetal
            // 
            this.lstBoxMetal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstBoxMetal.FormattingEnabled = true;
            this.lstBoxMetal.Location = new System.Drawing.Point(4, 30);
            this.lstBoxMetal.Margin = new System.Windows.Forms.Padding(2);
            this.lstBoxMetal.Name = "lstBoxMetal";
            this.lstBoxMetal.Size = new System.Drawing.Size(104, 160);
            this.lstBoxMetal.TabIndex = 3;
            // 
            // clearOrg
            // 
            this.clearOrg.Location = new System.Drawing.Point(7, 206);
            this.clearOrg.Margin = new System.Windows.Forms.Padding(2);
            this.clearOrg.Name = "clearOrg";
            this.clearOrg.Size = new System.Drawing.Size(103, 21);
            this.clearOrg.TabIndex = 5;
            this.clearOrg.Text = "BOŞALT";
            this.clearOrg.UseVisualStyleBackColor = true;
            this.clearOrg.Click += new System.EventHandler(this.ClearOrg_Click);
            // 
            // clearMetal
            // 
            this.clearMetal.Location = new System.Drawing.Point(4, 206);
            this.clearMetal.Margin = new System.Windows.Forms.Padding(2);
            this.clearMetal.Name = "clearMetal";
            this.clearMetal.Size = new System.Drawing.Size(103, 21);
            this.clearMetal.TabIndex = 6;
            this.clearMetal.Text = "BOŞALT";
            this.clearMetal.UseVisualStyleBackColor = true;
            this.clearMetal.Click += new System.EventHandler(this.ClearMetal_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCikis.Location = new System.Drawing.Point(16, 267);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(122, 41);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnYeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyun.ForeColor = System.Drawing.SystemColors.Control;
            this.btnYeniOyun.Location = new System.Drawing.Point(16, 17);
            this.btnYeniOyun.Margin = new System.Windows.Forms.Padding(2);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(122, 43);
            this.btnYeniOyun.TabIndex = 9;
            this.btnYeniOyun.Text = "YENİ OYUN";
            this.btnYeniOyun.UseVisualStyleBackColor = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.BtnYeniOyun_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(186, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "ATIK KUTULARI";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.prgBarOrg);
            this.groupBox1.Controls.Add(this.btnOrg);
            this.groupBox1.Controls.Add(this.lstBoxOrg);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.clearOrg);
            this.groupBox1.Location = new System.Drawing.Point(186, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(114, 235);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // lstBoxOrg
            // 
            this.lstBoxOrg.FormattingEnabled = true;
            this.lstBoxOrg.Location = new System.Drawing.Point(7, 30);
            this.lstBoxOrg.Margin = new System.Windows.Forms.Padding(2);
            this.lstBoxOrg.Name = "lstBoxOrg";
            this.lstBoxOrg.Size = new System.Drawing.Size(104, 160);
            this.lstBoxOrg.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Teal;
            this.groupBox3.Location = new System.Drawing.Point(0, 237);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(114, 235);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.clearCam);
            this.groupBox2.Controls.Add(this.prgBarCam);
            this.groupBox2.Controls.Add(this.btnCam);
            this.groupBox2.Controls.Add(this.lstBoxCam);
            this.groupBox2.Location = new System.Drawing.Point(307, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(114, 235);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Teal;
            this.groupBox4.Controls.Add(this.clearKagit);
            this.groupBox4.Controls.Add(this.prgBarKagit);
            this.groupBox4.Controls.Add(this.btnKagit);
            this.groupBox4.Controls.Add(this.lstBoxKagit);
            this.groupBox4.Location = new System.Drawing.Point(186, 271);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(114, 235);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Teal;
            this.groupBox5.Controls.Add(this.prgBarMetal);
            this.groupBox5.Controls.Add(this.btnMetal);
            this.groupBox5.Controls.Add(this.lstBoxMetal);
            this.groupBox5.Controls.Add(this.clearMetal);
            this.groupBox5.Location = new System.Drawing.Point(307, 271);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(114, 235);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox6.Controls.Add(this.pctrBoxAtik);
            this.groupBox6.Location = new System.Drawing.Point(14, 10);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(157, 165);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            // 
            // pctrBoxAtik
            // 
            this.pctrBoxAtik.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pctrBoxAtik.Location = new System.Drawing.Point(4, 7);
            this.pctrBoxAtik.Margin = new System.Windows.Forms.Padding(2);
            this.pctrBoxAtik.Name = "pctrBoxAtik";
            this.pctrBoxAtik.Size = new System.Drawing.Size(148, 152);
            this.pctrBoxAtik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrBoxAtik.TabIndex = 0;
            this.pctrBoxAtik.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox7.Controls.Add(this.lblPuan);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.lblSure);
            this.groupBox7.Controls.Add(this.btnCikis);
            this.groupBox7.Controls.Add(this.btnYeniOyun);
            this.groupBox7.Location = new System.Drawing.Point(14, 189);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(157, 317);
            this.groupBox7.TabIndex = 27;
            this.groupBox7.TabStop = false;
            // 
            // lblPuan
            // 
            this.lblPuan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPuan.Location = new System.Drawing.Point(18, 110);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(120, 37);
            this.lblPuan.TabIndex = 15;
            this.lblPuan.Text = "0";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(18, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "   PUAN";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(16, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "   SÜRE";
            // 
            // lblSure
            // 
            this.lblSure.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSure.Location = new System.Drawing.Point(16, 213);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(120, 37);
            this.lblSure.TabIndex = 10;
            this.lblSure.Text = "0";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // btnOrg
            // 
            this.btnOrg.Location = new System.Drawing.Point(7, 5);
            this.btnOrg.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrg.Name = "btnOrg";
            this.btnOrg.Size = new System.Drawing.Size(103, 21);
            this.btnOrg.TabIndex = 21;
            this.btnOrg.Text = "ORGANİK ATIK";
            this.btnOrg.UseVisualStyleBackColor = true;
            this.btnOrg.Click += new System.EventHandler(this.BtnOrg_Click);
            // 
            // btnMetal
            // 
            this.btnMetal.Location = new System.Drawing.Point(4, 5);
            this.btnMetal.Margin = new System.Windows.Forms.Padding(2);
            this.btnMetal.Name = "btnMetal";
            this.btnMetal.Size = new System.Drawing.Size(103, 21);
            this.btnMetal.TabIndex = 26;
            this.btnMetal.Text = "METAL";
            this.btnMetal.UseVisualStyleBackColor = true;
            this.btnMetal.Click += new System.EventHandler(this.BtnMetal_Click);
            // 
            // btnKagit
            // 
            this.btnKagit.Location = new System.Drawing.Point(6, 5);
            this.btnKagit.Margin = new System.Windows.Forms.Padding(2);
            this.btnKagit.Name = "btnKagit";
            this.btnKagit.Size = new System.Drawing.Size(103, 21);
            this.btnKagit.TabIndex = 27;
            this.btnKagit.Text = "KAĞIT";
            this.btnKagit.UseVisualStyleBackColor = true;
            this.btnKagit.Click += new System.EventHandler(this.BtnKagit_Click);
            // 
            // btnCam
            // 
            this.btnCam.Location = new System.Drawing.Point(4, 6);
            this.btnCam.Margin = new System.Windows.Forms.Padding(2);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(103, 21);
            this.btnCam.TabIndex = 28;
            this.btnCam.Text = "CAM";
            this.btnCam.UseVisualStyleBackColor = true;
            this.btnCam.Click += new System.EventHandler(this.BtnCam_Click);
            // 
            // prgBarOrg
            // 
            this.prgBarOrg.Location = new System.Drawing.Point(9, 192);
            this.prgBarOrg.Name = "prgBarOrg";
            this.prgBarOrg.Size = new System.Drawing.Size(100, 12);
            this.prgBarOrg.TabIndex = 26;
            // 
            // prgBarCam
            // 
            this.prgBarCam.Location = new System.Drawing.Point(5, 192);
            this.prgBarCam.Name = "prgBarCam";
            this.prgBarCam.Size = new System.Drawing.Size(100, 12);
            this.prgBarCam.TabIndex = 27;
            // 
            // prgBarKagit
            // 
            this.prgBarKagit.Location = new System.Drawing.Point(9, 192);
            this.prgBarKagit.Name = "prgBarKagit";
            this.prgBarKagit.Size = new System.Drawing.Size(100, 12);
            this.prgBarKagit.TabIndex = 28;
            // 
            // prgBarMetal
            // 
            this.prgBarMetal.Location = new System.Drawing.Point(5, 192);
            this.prgBarMetal.Name = "prgBarMetal";
            this.prgBarMetal.Size = new System.Drawing.Size(100, 12);
            this.prgBarMetal.TabIndex = 29;
            // 
            // clearKagit
            // 
            this.clearKagit.Location = new System.Drawing.Point(7, 207);
            this.clearKagit.Margin = new System.Windows.Forms.Padding(2);
            this.clearKagit.Name = "clearKagit";
            this.clearKagit.Size = new System.Drawing.Size(103, 21);
            this.clearKagit.TabIndex = 29;
            this.clearKagit.Text = "BOŞALT";
            this.clearKagit.UseVisualStyleBackColor = true;
            this.clearKagit.Click += new System.EventHandler(this.ClearKagit_Click);
            // 
            // clearCam
            // 
            this.clearCam.Location = new System.Drawing.Point(4, 209);
            this.clearCam.Margin = new System.Windows.Forms.Padding(2);
            this.clearCam.Name = "clearCam";
            this.clearCam.Size = new System.Drawing.Size(103, 21);
            this.clearCam.TabIndex = 30;
            this.clearCam.Text = "BOŞALT";
            this.clearCam.UseVisualStyleBackColor = true;
            this.clearCam.Click += new System.EventHandler(this.ClearCam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(432, 513);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ATIK TOPLAMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxAtik)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstBoxCam;
        private System.Windows.Forms.ListBox lstBoxKagit;
        private System.Windows.Forms.ListBox lstBoxMetal;
        private System.Windows.Forms.Button clearOrg;
        private System.Windows.Forms.Button clearMetal;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pctrBoxAtik;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox lstBoxOrg;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrg;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.Button btnKagit;
        private System.Windows.Forms.Button btnMetal;
        private System.Windows.Forms.ProgressBar prgBarOrg;
        private System.Windows.Forms.ProgressBar prgBarCam;
        private System.Windows.Forms.ProgressBar prgBarKagit;
        private System.Windows.Forms.ProgressBar prgBarMetal;
        private System.Windows.Forms.Button clearKagit;
        private System.Windows.Forms.Button clearCam;
    }
}

