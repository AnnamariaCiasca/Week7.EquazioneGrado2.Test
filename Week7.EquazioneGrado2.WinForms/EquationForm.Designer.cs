
namespace Week7.EquazioneGrado2.WinForms
{
    partial class EquationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtDelta = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.lblDelta = new System.Windows.Forms.Label();
            this.lblSoluzione1 = new System.Windows.Forms.Label();
            this.lblSoluzione2 = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.btnUguale = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(134, 13);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(89, 31);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(134, 77);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(89, 31);
            this.txtB.TabIndex = 1;
            // 
            // txtDelta
            // 
            this.txtDelta.Location = new System.Drawing.Point(134, 321);
            this.txtDelta.Name = "txtDelta";
            this.txtDelta.Size = new System.Drawing.Size(89, 31);
            this.txtDelta.TabIndex = 2;
            this.txtDelta.TextChanged += new System.EventHandler(this.txtDelta_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(134, 135);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(89, 31);
            this.txtC.TabIndex = 3;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(133, 449);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(89, 31);
            this.txtX1.TabIndex = 4;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(133, 505);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(89, 31);
            this.txtX2.TabIndex = 5;
            // 
            // x2
            // 
            this.x2.AutoSize = true;
            this.x2.Location = new System.Drawing.Point(117, 201);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(42, 25);
            this.x2.TabIndex = 6;
            this.x2.Text = "x^2";
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(202, 201);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(20, 25);
            this.x.TabIndex = 7;
            this.x.Text = "x";
            // 
            // lblDelta
            // 
            this.lblDelta.AutoSize = true;
            this.lblDelta.Location = new System.Drawing.Point(8, 327);
            this.lblDelta.Name = "lblDelta";
            this.lblDelta.Size = new System.Drawing.Size(70, 25);
            this.lblDelta.TabIndex = 9;
            this.lblDelta.Text = "Delta =";
            // 
            // lblSoluzione1
            // 
            this.lblSoluzione1.AutoSize = true;
            this.lblSoluzione1.Location = new System.Drawing.Point(8, 455);
            this.lblSoluzione1.Name = "lblSoluzione1";
            this.lblSoluzione1.Size = new System.Drawing.Size(47, 25);
            this.lblSoluzione1.TabIndex = 10;
            this.lblSoluzione1.Text = "x1 =";
            // 
            // lblSoluzione2
            // 
            this.lblSoluzione2.AutoSize = true;
            this.lblSoluzione2.Location = new System.Drawing.Point(7, 508);
            this.lblSoluzione2.Name = "lblSoluzione2";
            this.lblSoluzione2.Size = new System.Drawing.Size(47, 25);
            this.lblSoluzione2.TabIndex = 11;
            this.lblSoluzione2.Text = "x2 =";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(71, 141);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(37, 25);
            this.lblC.TabIndex = 12;
            this.lblC.Text = "c =";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(71, 83);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(40, 25);
            this.lblB.TabIndex = 13;
            this.lblB.Text = "b =";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(73, 19);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(38, 25);
            this.lblA.TabIndex = 14;
            this.lblA.Text = "a =";
            // 
            // btnUguale
            // 
            this.btnUguale.Location = new System.Drawing.Point(134, 245);
            this.btnUguale.Name = "btnUguale";
            this.btnUguale.Size = new System.Drawing.Size(89, 34);
            this.btnUguale.TabIndex = 15;
            this.btnUguale.Text = "=";
            this.btnUguale.UseVisualStyleBackColor = true;
            this.btnUguale.Click += new System.EventHandler(this.btnUguale_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(29, 31);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(228, 195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(31, 31);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(165, 195);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(31, 31);
            this.textBox3.TabIndex = 18;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(108, 358);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 70);
            this.textBox4.TabIndex = 19;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(292, 505);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(60, 34);
            this.btnC.TabIndex = 20;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // EquationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 544);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUguale);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblSoluzione2);
            this.Controls.Add(this.lblSoluzione1);
            this.Controls.Add(this.lblDelta);
            this.Controls.Add(this.x);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtDelta);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "EquationForm";
            this.Text = "RisolutoreDiEquazioni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtDelta;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label x2;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label lblDelta;
        private System.Windows.Forms.Label lblSoluzione1;
        private System.Windows.Forms.Label lblSoluzione2;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button btnUguale;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnC;
    }
}

