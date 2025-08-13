namespace CalculatorApplication
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
            this.frstnumber = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sndnumber = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // frstnumber
            // 
            this.frstnumber.AutoSize = true;
            this.frstnumber.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frstnumber.Location = new System.Drawing.Point(37, 49);
            this.frstnumber.Name = "frstnumber";
            this.frstnumber.Size = new System.Drawing.Size(120, 17);
            this.frstnumber.TabIndex = 0;
            this.frstnumber.Text = "Enter First Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 1;
            // 
            // sndnumber
            // 
            this.sndnumber.AutoSize = true;
            this.sndnumber.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sndnumber.Location = new System.Drawing.Point(37, 139);
            this.sndnumber.Name = "sndnumber";
            this.sndnumber.Size = new System.Drawing.Size(135, 17);
            this.sndnumber.TabIndex = 2;
            this.sndnumber.Text = "Enter Second Number:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(244, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 475);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sndnumber);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.frstnumber);
            this.Name = "Form1";
            this.Text = "FrmCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frstnumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label sndnumber;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

