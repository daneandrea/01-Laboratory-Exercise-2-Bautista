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
            this.frstname = new System.Windows.Forms.Label();
            this.txtBoxInput1 = new System.Windows.Forms.TextBox();
            this.sndnumber = new System.Windows.Forms.Label();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.answer = new System.Windows.Forms.Label();
            this.txtBoxInput2 = new System.Windows.Forms.TextBox();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.btnEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frstname
            // 
            this.frstname.AutoSize = true;
            this.frstname.BackColor = System.Drawing.Color.Transparent;
            this.frstname.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frstname.Location = new System.Drawing.Point(37, 49);
            this.frstname.Name = "frstname";
            this.frstname.Size = new System.Drawing.Size(147, 21);
            this.frstname.TabIndex = 0;
            this.frstname.Text = "Enter First Number:";
            // 
            // txtBoxInput1
            // 
            this.txtBoxInput1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(176)))), ((int)(((byte)(232)))));
            this.txtBoxInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInput1.Location = new System.Drawing.Point(235, 49);
            this.txtBoxInput1.Name = "txtBoxInput1";
            this.txtBoxInput1.Size = new System.Drawing.Size(169, 26);
            this.txtBoxInput1.TabIndex = 1;
            // 
            // sndnumber
            // 
            this.sndnumber.AutoSize = true;
            this.sndnumber.BackColor = System.Drawing.Color.Transparent;
            this.sndnumber.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sndnumber.Location = new System.Drawing.Point(22, 131);
            this.sndnumber.Name = "sndnumber";
            this.sndnumber.Size = new System.Drawing.Size(167, 21);
            this.sndnumber.TabIndex = 2;
            this.sndnumber.Text = "Enter Second Number:";
            // 
            // cbOperator
            // 
            this.cbOperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(176)))), ((int)(((byte)(232)))));
            this.cbOperator.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Location = new System.Drawing.Point(345, 88);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(59, 27);
            this.cbOperator.TabIndex = 3;
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.BackColor = System.Drawing.Color.Transparent;
            this.answer.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(104, 187);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(66, 21);
            this.answer.TabIndex = 4;
            this.answer.Text = "Answer:";
            // 
            // txtBoxInput2
            // 
            this.txtBoxInput2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(176)))), ((int)(((byte)(232)))));
            this.txtBoxInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInput2.Location = new System.Drawing.Point(235, 125);
            this.txtBoxInput2.Name = "txtBoxInput2";
            this.txtBoxInput2.Size = new System.Drawing.Size(169, 26);
            this.txtBoxInput2.TabIndex = 5;
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.AutoSize = true;
            this.lblDisplayTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayTotal.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTotal.Location = new System.Drawing.Point(231, 187);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(14, 21);
            this.lblDisplayTotal.TabIndex = 6;
            this.lblDisplayTotal.Text = ".";
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(260, 231);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(121, 31);
            this.btnEqual.TabIndex = 7;
            this.btnEqual.Text = "Calculate";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CalculatorApplication.Properties.Resources.Screenshot_2025_08_13_195314;
            this.ClientSize = new System.Drawing.Size(448, 299);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.lblDisplayTotal);
            this.Controls.Add(this.txtBoxInput2);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.sndnumber);
            this.Controls.Add(this.txtBoxInput1);
            this.Controls.Add(this.frstname);
            this.Name = "Form1";
            this.Text = "FrmCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frstname;
        private System.Windows.Forms.TextBox txtBoxInput1;
        private System.Windows.Forms.Label sndnumber;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.TextBox txtBoxInput2;
        private System.Windows.Forms.Label lblDisplayTotal;
        private System.Windows.Forms.Button btnEqual;
    }
}

