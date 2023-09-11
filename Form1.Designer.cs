namespace AtlasTelemetri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.networkliste = new System.Windows.Forms.ComboBox();
            this.plannerCheck = new System.Windows.Forms.CheckBox();
            this.agekle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 287);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bağlan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 287);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Bağlantını Kes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // networkliste
            // 
            this.networkliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.networkliste.ForeColor = System.Drawing.SystemColors.WindowText;
            this.networkliste.FormattingEnabled = true;
            this.networkliste.Items.AddRange(new object[] {
            "1d71939404c2b5bc"});
            this.networkliste.Location = new System.Drawing.Point(41, 197);
            this.networkliste.Margin = new System.Windows.Forms.Padding(2);
            this.networkliste.Name = "networkliste";
            this.networkliste.Size = new System.Drawing.Size(327, 33);
            this.networkliste.TabIndex = 3;
            // 
            // plannerCheck
            // 
            this.plannerCheck.AutoSize = true;
            this.plannerCheck.Location = new System.Drawing.Point(41, 358);
            this.plannerCheck.Margin = new System.Windows.Forms.Padding(2);
            this.plannerCheck.Name = "plannerCheck";
            this.plannerCheck.Size = new System.Drawing.Size(210, 17);
            this.plannerCheck.TabIndex = 4;
            this.plannerCheck.Text = "Bağlanırken MissionPlanner\'ı da çalıştır.";
            this.plannerCheck.UseVisualStyleBackColor = true;
            // 
            // agekle
            // 
            this.agekle.Location = new System.Drawing.Point(370, 201);
            this.agekle.Margin = new System.Windows.Forms.Padding(2);
            this.agekle.Name = "agekle";
            this.agekle.Size = new System.Drawing.Size(26, 24);
            this.agekle.TabIndex = 5;
            this.agekle.Text = "+";
            this.agekle.UseVisualStyleBackColor = true;
            this.agekle.Click += new System.EventHandler(this.agekle_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 379);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(248, 20);
            this.textBox1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(294, 377);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 7;
            this.button3.Text = "Göz at";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(77, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 80);
            this.label2.TabIndex = 8;
            this.label2.Text = "Atlas Telemetri \r\nArayüzü";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AtlasTelemetri.Properties.Resources.Adsız_tasarım__1_;
            this.ClientSize = new System.Drawing.Size(400, 465);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.agekle);
            this.Controls.Add(this.plannerCheck);
            this.Controls.Add(this.networkliste);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(416, 504);
            this.MinimumSize = new System.Drawing.Size(416, 504);
            this.Name = "Form1";
            this.Text = "Atlas Telemetri Arayüzü";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox networkliste;
        private System.Windows.Forms.CheckBox plannerCheck;
        private System.Windows.Forms.Button agekle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

