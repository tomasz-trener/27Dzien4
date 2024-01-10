namespace P06ZadaniePogoda
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
            this.btnPodajTemperature = new System.Windows.Forms.Button();
            this.cbMiasta = new System.Windows.Forms.ComboBox();
            this.rbCelsjusz = new System.Windows.Forms.RadioButton();
            this.rbFrenheit = new System.Windows.Forms.RadioButton();
            this.rbKelvin = new System.Windows.Forms.RadioButton();
            this.lblRaport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPodajTemperature
            // 
            this.btnPodajTemperature.Location = new System.Drawing.Point(12, 39);
            this.btnPodajTemperature.Name = "btnPodajTemperature";
            this.btnPodajTemperature.Size = new System.Drawing.Size(127, 40);
            this.btnPodajTemperature.TabIndex = 0;
            this.btnPodajTemperature.Text = "Podaj temperature";
            this.btnPodajTemperature.UseVisualStyleBackColor = true;
            this.btnPodajTemperature.Click += new System.EventHandler(this.btnPodajTemperature_Click);
            // 
            // cbMiasta
            // 
            this.cbMiasta.FormattingEnabled = true;
            this.cbMiasta.Location = new System.Drawing.Point(12, 12);
            this.cbMiasta.Name = "cbMiasta";
            this.cbMiasta.Size = new System.Drawing.Size(127, 21);
            this.cbMiasta.TabIndex = 1;
            // 
            // rbCelsjusz
            // 
            this.rbCelsjusz.AutoSize = true;
            this.rbCelsjusz.Location = new System.Drawing.Point(162, 16);
            this.rbCelsjusz.Name = "rbCelsjusz";
            this.rbCelsjusz.Size = new System.Drawing.Size(63, 17);
            this.rbCelsjusz.TabIndex = 2;
            this.rbCelsjusz.TabStop = true;
            this.rbCelsjusz.Text = "Celsjusz";
            this.rbCelsjusz.UseVisualStyleBackColor = true;
            // 
            // rbFrenheit
            // 
            this.rbFrenheit.AutoSize = true;
            this.rbFrenheit.Location = new System.Drawing.Point(161, 39);
            this.rbFrenheit.Name = "rbFrenheit";
            this.rbFrenheit.Size = new System.Drawing.Size(69, 17);
            this.rbFrenheit.TabIndex = 3;
            this.rbFrenheit.TabStop = true;
            this.rbFrenheit.Text = "Farenheit";
            this.rbFrenheit.UseVisualStyleBackColor = true;
            // 
            // rbKelvin
            // 
            this.rbKelvin.AutoSize = true;
            this.rbKelvin.Location = new System.Drawing.Point(161, 62);
            this.rbKelvin.Name = "rbKelvin";
            this.rbKelvin.Size = new System.Drawing.Size(54, 17);
            this.rbKelvin.TabIndex = 4;
            this.rbKelvin.TabStop = true;
            this.rbKelvin.Text = "Kelvin";
            this.rbKelvin.UseVisualStyleBackColor = true;
            // 
            // lblRaport
            // 
            this.lblRaport.AutoSize = true;
            this.lblRaport.Location = new System.Drawing.Point(13, 98);
            this.lblRaport.Name = "lblRaport";
            this.lblRaport.Size = new System.Drawing.Size(35, 13);
            this.lblRaport.TabIndex = 5;
            this.lblRaport.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 193);
            this.Controls.Add(this.lblRaport);
            this.Controls.Add(this.rbKelvin);
            this.Controls.Add(this.rbFrenheit);
            this.Controls.Add(this.rbCelsjusz);
            this.Controls.Add(this.cbMiasta);
            this.Controls.Add(this.btnPodajTemperature);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPodajTemperature;
        private System.Windows.Forms.ComboBox cbMiasta;
        private System.Windows.Forms.RadioButton rbCelsjusz;
        private System.Windows.Forms.RadioButton rbFrenheit;
        private System.Windows.Forms.RadioButton rbKelvin;
        private System.Windows.Forms.Label lblRaport;
    }
}

