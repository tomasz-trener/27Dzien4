﻿namespace P01AplikacjaOkienkowa
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
            this.btnPolicz = new System.Windows.Forms.Button();
            this.txtLiczba1 = new System.Windows.Forms.TextBox();
            this.txtLiczba2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWynik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPolicz
            // 
            this.btnPolicz.Location = new System.Drawing.Point(134, 24);
            this.btnPolicz.Name = "btnPolicz";
            this.btnPolicz.Size = new System.Drawing.Size(144, 88);
            this.btnPolicz.TabIndex = 0;
            this.btnPolicz.Text = "Policz";
            this.btnPolicz.UseVisualStyleBackColor = true;
            this.btnPolicz.Click += new System.EventHandler(this.btnPolicz_Click);
            // 
            // txtLiczba1
            // 
            this.txtLiczba1.Location = new System.Drawing.Point(28, 43);
            this.txtLiczba1.Name = "txtLiczba1";
            this.txtLiczba1.Size = new System.Drawing.Size(100, 20);
            this.txtLiczba1.TabIndex = 1;
            // 
            // txtLiczba2
            // 
            this.txtLiczba2.Location = new System.Drawing.Point(28, 92);
            this.txtLiczba2.Name = "txtLiczba2";
            this.txtLiczba2.Size = new System.Drawing.Size(100, 20);
            this.txtLiczba2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liczba 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liczba 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wynik";
            // 
            // txtWynik
            // 
            this.txtWynik.Location = new System.Drawing.Point(134, 121);
            this.txtWynik.Name = "txtWynik";
            this.txtWynik.Size = new System.Drawing.Size(144, 20);
            this.txtWynik.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 156);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWynik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLiczba2);
            this.Controls.Add(this.txtLiczba1);
            this.Controls.Add(this.btnPolicz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPolicz;
        private System.Windows.Forms.TextBox txtLiczba1;
        private System.Windows.Forms.TextBox txtLiczba2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWynik;
    }
}

