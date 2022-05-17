namespace Bietigheim_Sunshine
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Excel = new System.Windows.Forms.Button();
            this.Abfrage = new System.Windows.Forms.Button();
            this.Uhrzeit = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Temp = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Wind = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.windkmh = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.GradC = new System.Windows.Forms.Label();
            this.Prozent = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Excel
            // 
            this.Excel.Location = new System.Drawing.Point(49, 529);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(177, 51);
            this.Excel.TabIndex = 1;
            this.Excel.Text = "Export starten";
            this.Excel.UseVisualStyleBackColor = true;
            this.Excel.Click += new System.EventHandler(this.button1_Click);
            // 
            // Abfrage
            // 
            this.Abfrage.Location = new System.Drawing.Point(781, 529);
            this.Abfrage.Name = "Abfrage";
            this.Abfrage.Size = new System.Drawing.Size(177, 51);
            this.Abfrage.TabIndex = 2;
            this.Abfrage.Text = "Aktualisieren";
            this.Abfrage.UseVisualStyleBackColor = true;
            this.Abfrage.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Uhrzeit
            // 
            this.Uhrzeit.AutoSize = true;
            this.Uhrzeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uhrzeit.Location = new System.Drawing.Point(516, 63);
            this.Uhrzeit.Name = "Uhrzeit";
            this.Uhrzeit.Size = new System.Drawing.Size(101, 31);
            this.Uhrzeit.TabIndex = 3;
            this.Uhrzeit.Text = "Uhrzeit";
            this.Uhrzeit.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(642, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(186, 54);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(49, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 309);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temp.Location = new System.Drawing.Point(463, 212);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(154, 31);
            this.Temp.TabIndex = 6;
            this.Temp.Text = "Temperatur";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(642, 200);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(186, 54);
            this.textBox2.TabIndex = 7;
            // 
            // Wind
            // 
            this.Wind.AutoSize = true;
            this.Wind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wind.Location = new System.Drawing.Point(542, 309);
            this.Wind.Name = "Wind";
            this.Wind.Size = new System.Drawing.Size(75, 31);
            this.Wind.TabIndex = 8;
            this.Wind.Text = "Wind";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(642, 299);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(186, 54);
            this.textBox3.TabIndex = 9;
            // 
            // windkmh
            // 
            this.windkmh.AutoSize = true;
            this.windkmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windkmh.Location = new System.Drawing.Point(833, 309);
            this.windkmh.Name = "windkmh";
            this.windkmh.Size = new System.Drawing.Size(73, 31);
            this.windkmh.TabIndex = 10;
            this.windkmh.Text = "km/h";
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidity.Location = new System.Drawing.Point(467, 396);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(150, 31);
            this.humidity.TabIndex = 11;
            this.humidity.Text = "Luftfeuchte";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(642, 384);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(186, 54);
            this.textBox4.TabIndex = 12;
            // 
            // GradC
            // 
            this.GradC.AutoSize = true;
            this.GradC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradC.Location = new System.Drawing.Point(833, 212);
            this.GradC.Name = "GradC";
            this.GradC.Size = new System.Drawing.Size(45, 31);
            this.GradC.TabIndex = 13;
            this.GradC.Text = "°C";
            // 
            // Prozent
            // 
            this.Prozent.AutoSize = true;
            this.Prozent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prozent.Location = new System.Drawing.Point(834, 396);
            this.Prozent.Name = "Prozent";
            this.Prozent.Size = new System.Drawing.Size(38, 31);
            this.Prozent.TabIndex = 14;
            this.Prozent.Text = "%";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Germany",
            "Italy",
            "England",
            "Spain",
            "Japan"});
            this.comboBox1.Location = new System.Drawing.Point(49, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(336, 33);
            this.comboBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 621);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Prozent);
            this.Controls.Add(this.GradC);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.windkmh);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Wind);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Uhrzeit);
            this.Controls.Add(this.Abfrage);
            this.Controls.Add(this.Excel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BietigheimSunshine - Die Wetterabfrage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Excel;
        private System.Windows.Forms.Button Abfrage;
        private System.Windows.Forms.Label Uhrzeit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Temp;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Wind;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label windkmh;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label GradC;
        private System.Windows.Forms.Label Prozent;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

