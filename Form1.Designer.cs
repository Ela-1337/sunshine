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
            this.UhrzeitTextBox = new System.Windows.Forms.TextBox();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.Temp = new System.Windows.Forms.Label();
            this.TemperaturTextBox = new System.Windows.Forms.TextBox();
            this.Wind = new System.Windows.Forms.Label();
            this.WindTextBox = new System.Windows.Forms.TextBox();
            this.windkmh = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.LuftfeuchteTextBox = new System.Windows.Forms.TextBox();
            this.GradC = new System.Windows.Forms.Label();
            this.Prozent = new System.Windows.Forms.Label();
            this.AbfrageAuswahlListe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
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
            this.Excel.Click += new System.EventHandler(this.Excel_Click);
            // 
            // Abfrage
            // 
            this.Abfrage.Location = new System.Drawing.Point(781, 529);
            this.Abfrage.Name = "Abfrage";
            this.Abfrage.Size = new System.Drawing.Size(177, 51);
            this.Abfrage.TabIndex = 2;
            this.Abfrage.Text = "Aktualisieren";
            this.Abfrage.UseVisualStyleBackColor = true;
            this.Abfrage.Click += new System.EventHandler(this.Abfrage_Click);
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
            // 
            // UhrzeitTextBox
            // 
            this.UhrzeitTextBox.Location = new System.Drawing.Point(642, 51);
            this.UhrzeitTextBox.Multiline = true;
            this.UhrzeitTextBox.Name = "UhrzeitTextBox";
            this.UhrzeitTextBox.ReadOnly = true;
            this.UhrzeitTextBox.Size = new System.Drawing.Size(186, 54);
            this.UhrzeitTextBox.TabIndex = 4;
            // 
            // IconBox
            // 
            this.IconBox.Location = new System.Drawing.Point(49, 159);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(336, 309);
            this.IconBox.TabIndex = 5;
            this.IconBox.TabStop = false;
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
            // TemperaturTextBox
            // 
            this.TemperaturTextBox.Location = new System.Drawing.Point(642, 200);
            this.TemperaturTextBox.Multiline = true;
            this.TemperaturTextBox.Name = "TemperaturTextBox";
            this.TemperaturTextBox.ReadOnly = true;
            this.TemperaturTextBox.Size = new System.Drawing.Size(186, 54);
            this.TemperaturTextBox.TabIndex = 7;
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
            // WindTextBox
            // 
            this.WindTextBox.Location = new System.Drawing.Point(642, 299);
            this.WindTextBox.Multiline = true;
            this.WindTextBox.Name = "WindTextBox";
            this.WindTextBox.ReadOnly = true;
            this.WindTextBox.Size = new System.Drawing.Size(186, 54);
            this.WindTextBox.TabIndex = 9;
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
            // LuftfeuchteTextBox
            // 
            this.LuftfeuchteTextBox.Location = new System.Drawing.Point(642, 384);
            this.LuftfeuchteTextBox.Multiline = true;
            this.LuftfeuchteTextBox.Name = "LuftfeuchteTextBox";
            this.LuftfeuchteTextBox.ReadOnly = true;
            this.LuftfeuchteTextBox.Size = new System.Drawing.Size(186, 54);
            this.LuftfeuchteTextBox.TabIndex = 12;
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
            // AbfrageAuswahlListe
            // 
            this.AbfrageAuswahlListe.FormattingEnabled = true;
            this.AbfrageAuswahlListe.Items.AddRange(new object[] {
            "Germany",
            "Italy",
            "England",
            "Spain",
            "Japan"});
            this.AbfrageAuswahlListe.Location = new System.Drawing.Point(49, 51);
            this.AbfrageAuswahlListe.Name = "AbfrageAuswahlListe";
            this.AbfrageAuswahlListe.Size = new System.Drawing.Size(336, 33);
            this.AbfrageAuswahlListe.TabIndex = 15;
            this.AbfrageAuswahlListe.SelectedIndexChanged += new System.EventHandler(this.AbfrageAuswahlListe_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 621);
            this.Controls.Add(this.AbfrageAuswahlListe);
            this.Controls.Add(this.Prozent);
            this.Controls.Add(this.GradC);
            this.Controls.Add(this.LuftfeuchteTextBox);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.windkmh);
            this.Controls.Add(this.WindTextBox);
            this.Controls.Add(this.Wind);
            this.Controls.Add(this.TemperaturTextBox);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.IconBox);
            this.Controls.Add(this.UhrzeitTextBox);
            this.Controls.Add(this.Uhrzeit);
            this.Controls.Add(this.Abfrage);
            this.Controls.Add(this.Excel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BietigheimSunshine - Die Wetterabfrage";
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Excel;
        private System.Windows.Forms.Button Abfrage;
        private System.Windows.Forms.Label Uhrzeit;
        private System.Windows.Forms.TextBox UhrzeitTextBox;
        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.Label Temp;
        private System.Windows.Forms.TextBox TemperaturTextBox;
        private System.Windows.Forms.Label Wind;
        private System.Windows.Forms.TextBox WindTextBox;
        private System.Windows.Forms.Label windkmh;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.TextBox LuftfeuchteTextBox;
        private System.Windows.Forms.Label GradC;
        private System.Windows.Forms.Label Prozent;
        private System.Windows.Forms.ComboBox AbfrageAuswahlListe;
    }
}

