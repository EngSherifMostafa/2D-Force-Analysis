namespace _2DForceAnalysis
{
    partial class FrmMain
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rbKg = new System.Windows.Forms.RadioButton();
            this.rbNewton = new System.Windows.Forms.RadioButton();
            this.txtRightAngle = new System.Windows.Forms.TextBox();
            this.txtLeftAngle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtForce1Val = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtForce2Val = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkDraw = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRightOpposite = new System.Windows.Forms.TextBox();
            this.txtRightAdjacent = new System.Windows.Forms.TextBox();
            this.txtRightHypotenuse = new System.Windows.Forms.TextBox();
            this.chkRightTri = new System.Windows.Forms.CheckBox();
            this.chkLeftTri = new System.Windows.Forms.CheckBox();
            this.txtLeftOpposite = new System.Windows.Forms.TextBox();
            this.txtLeftAdjacent = new System.Windows.Forms.TextBox();
            this.txtLeftHypotenuse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCalculate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCalculate.Location = new System.Drawing.Point(638, 489);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(132, 52);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rbKg
            // 
            this.rbKg.AutoSize = true;
            this.rbKg.ForeColor = System.Drawing.Color.White;
            this.rbKg.Location = new System.Drawing.Point(244, 425);
            this.rbKg.Name = "rbKg";
            this.rbKg.Size = new System.Drawing.Size(45, 21);
            this.rbKg.TabIndex = 7;
            this.rbKg.Text = "Kg";
            this.rbKg.UseVisualStyleBackColor = true;
            // 
            // rbNewton
            // 
            this.rbNewton.AutoSize = true;
            this.rbNewton.Checked = true;
            this.rbNewton.ForeColor = System.Drawing.Color.White;
            this.rbNewton.Location = new System.Drawing.Point(244, 398);
            this.rbNewton.Name = "rbNewton";
            this.rbNewton.Size = new System.Drawing.Size(76, 21);
            this.rbNewton.TabIndex = 6;
            this.rbNewton.TabStop = true;
            this.rbNewton.Text = "Newton";
            this.rbNewton.UseVisualStyleBackColor = true;
            // 
            // txtRightAngle
            // 
            this.txtRightAngle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRightAngle.Location = new System.Drawing.Point(718, 258);
            this.txtRightAngle.Name = "txtRightAngle";
            this.txtRightAngle.Size = new System.Drawing.Size(51, 28);
            this.txtRightAngle.TabIndex = 1;
            this.txtRightAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRightAngle.TextChanged += new System.EventHandler(this.txtRightAngle_TextChanged);
            // 
            // txtLeftAngle
            // 
            this.txtLeftAngle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeftAngle.Location = new System.Drawing.Point(71, 264);
            this.txtLeftAngle.Name = "txtLeftAngle";
            this.txtLeftAngle.Size = new System.Drawing.Size(52, 28);
            this.txtLeftAngle.TabIndex = 2;
            this.txtLeftAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLeftAngle.TextChanged += new System.EventHandler(this.txtLeftAngle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(655, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ɵ =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ɵ =";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(138, 404);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 28);
            this.txtWeight.TabIndex = 5;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // txtForce1Val
            // 
            this.txtForce1Val.Enabled = false;
            this.txtForce1Val.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForce1Val.Location = new System.Drawing.Point(669, 16);
            this.txtForce1Val.Name = "txtForce1Val";
            this.txtForce1Val.Size = new System.Drawing.Size(100, 28);
            this.txtForce1Val.TabIndex = 5;
            this.txtForce1Val.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Weight";
            // 
            // txtForce2Val
            // 
            this.txtForce2Val.Enabled = false;
            this.txtForce2Val.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForce2Val.Location = new System.Drawing.Point(129, 16);
            this.txtForce2Val.Name = "txtForce2Val";
            this.txtForce2Val.Size = new System.Drawing.Size(100, 28);
            this.txtForce2Val.TabIndex = 6;
            this.txtForce2Val.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(536, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Right Force";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Left Force";
            // 
            // chkDraw
            // 
            this.chkDraw.AutoSize = true;
            this.chkDraw.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDraw.ForeColor = System.Drawing.Color.White;
            this.chkDraw.Location = new System.Drawing.Point(555, 505);
            this.chkDraw.Name = "chkDraw";
            this.chkDraw.Size = new System.Drawing.Size(77, 25);
            this.chkDraw.TabIndex = 15;
            this.chkDraw.Text = "Draw";
            this.chkDraw.UseVisualStyleBackColor = true;
            this.chkDraw.CheckedChanged += new System.EventHandler(this.chkDraw_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(655, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "H =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(655, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "O =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(656, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "A =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "H =";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(11, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 29);
            this.label10.TabIndex = 3;
            this.label10.Text = "O =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 29);
            this.label11.TabIndex = 3;
            this.label11.Text = "A =";
            // 
            // txtRightOpposite
            // 
            this.txtRightOpposite.Enabled = false;
            this.txtRightOpposite.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtRightOpposite.Location = new System.Drawing.Point(718, 157);
            this.txtRightOpposite.Name = "txtRightOpposite";
            this.txtRightOpposite.Size = new System.Drawing.Size(51, 28);
            this.txtRightOpposite.TabIndex = 10;
            this.txtRightOpposite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRightOpposite.TextChanged += new System.EventHandler(this.txtRightOpposite_TextChanged);
            // 
            // txtRightAdjacent
            // 
            this.txtRightAdjacent.Enabled = false;
            this.txtRightAdjacent.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtRightAdjacent.Location = new System.Drawing.Point(718, 190);
            this.txtRightAdjacent.Name = "txtRightAdjacent";
            this.txtRightAdjacent.Size = new System.Drawing.Size(51, 28);
            this.txtRightAdjacent.TabIndex = 9;
            this.txtRightAdjacent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRightAdjacent.TextChanged += new System.EventHandler(this.txtRightAdjacent_TextChanged);
            // 
            // txtRightHypotenuse
            // 
            this.txtRightHypotenuse.Enabled = false;
            this.txtRightHypotenuse.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtRightHypotenuse.Location = new System.Drawing.Point(718, 224);
            this.txtRightHypotenuse.Name = "txtRightHypotenuse";
            this.txtRightHypotenuse.Size = new System.Drawing.Size(51, 28);
            this.txtRightHypotenuse.TabIndex = 8;
            this.txtRightHypotenuse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRightHypotenuse.TextChanged += new System.EventHandler(this.txtRightHypotenuse_TextChanged);
            // 
            // chkRightTri
            // 
            this.chkRightTri.AutoSize = true;
            this.chkRightTri.ForeColor = System.Drawing.Color.White;
            this.chkRightTri.Location = new System.Drawing.Point(643, 128);
            this.chkRightTri.Name = "chkRightTri";
            this.chkRightTri.Size = new System.Drawing.Size(127, 21);
            this.chkRightTri.TabIndex = 3;
            this.chkRightTri.Text = "Triangle System";
            this.chkRightTri.UseVisualStyleBackColor = true;
            this.chkRightTri.CheckedChanged += new System.EventHandler(this.chkRightTri_CheckedChanged);
            // 
            // chkLeftTri
            // 
            this.chkLeftTri.AutoSize = true;
            this.chkLeftTri.ForeColor = System.Drawing.Color.White;
            this.chkLeftTri.Location = new System.Drawing.Point(11, 128);
            this.chkLeftTri.Name = "chkLeftTri";
            this.chkLeftTri.Size = new System.Drawing.Size(127, 21);
            this.chkLeftTri.TabIndex = 4;
            this.chkLeftTri.Text = "Triangle System";
            this.chkLeftTri.UseVisualStyleBackColor = true;
            this.chkLeftTri.CheckedChanged += new System.EventHandler(this.chkLeftTri_CheckedChanged);
            // 
            // txtLeftOpposite
            // 
            this.txtLeftOpposite.Enabled = false;
            this.txtLeftOpposite.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtLeftOpposite.Location = new System.Drawing.Point(71, 163);
            this.txtLeftOpposite.Name = "txtLeftOpposite";
            this.txtLeftOpposite.Size = new System.Drawing.Size(52, 28);
            this.txtLeftOpposite.TabIndex = 13;
            this.txtLeftOpposite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLeftOpposite.TextChanged += new System.EventHandler(this.txtLeftOpposite_TextChanged);
            // 
            // txtLeftAdjacent
            // 
            this.txtLeftAdjacent.Enabled = false;
            this.txtLeftAdjacent.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtLeftAdjacent.Location = new System.Drawing.Point(71, 197);
            this.txtLeftAdjacent.Name = "txtLeftAdjacent";
            this.txtLeftAdjacent.Size = new System.Drawing.Size(52, 28);
            this.txtLeftAdjacent.TabIndex = 12;
            this.txtLeftAdjacent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLeftAdjacent.TextChanged += new System.EventHandler(this.txtLeftAdjacent_TextChanged);
            // 
            // txtLeftHypotenuse
            // 
            this.txtLeftHypotenuse.Enabled = false;
            this.txtLeftHypotenuse.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtLeftHypotenuse.Location = new System.Drawing.Point(71, 231);
            this.txtLeftHypotenuse.Name = "txtLeftHypotenuse";
            this.txtLeftHypotenuse.Size = new System.Drawing.Size(52, 28);
            this.txtLeftHypotenuse.TabIndex = 11;
            this.txtLeftHypotenuse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLeftHypotenuse.TextChanged += new System.EventHandler(this.txtLeftHypotenuse_TextChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.txtLeftHypotenuse);
            this.Controls.Add(this.txtLeftAdjacent);
            this.Controls.Add(this.txtLeftOpposite);
            this.Controls.Add(this.chkLeftTri);
            this.Controls.Add(this.chkRightTri);
            this.Controls.Add(this.txtRightHypotenuse);
            this.Controls.Add(this.txtRightAdjacent);
            this.Controls.Add(this.txtRightOpposite);
            this.Controls.Add(this.chkDraw);
            this.Controls.Add(this.txtForce2Val);
            this.Controls.Add(this.txtForce1Val);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLeftAngle);
            this.Controls.Add(this.txtRightAngle);
            this.Controls.Add(this.rbNewton);
            this.Controls.Add(this.rbKg);
            this.Controls.Add(this.btnCalculate);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2D Force Analysis";
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton rbKg;
        private System.Windows.Forms.RadioButton rbNewton;
        private System.Windows.Forms.TextBox txtRightAngle;
        private System.Windows.Forms.TextBox txtLeftAngle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtForce1Val;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtForce2Val;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkDraw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRightOpposite;
        private System.Windows.Forms.TextBox txtRightAdjacent;
        private System.Windows.Forms.TextBox txtRightHypotenuse;
        private System.Windows.Forms.CheckBox chkRightTri;
        private System.Windows.Forms.CheckBox chkLeftTri;
        private System.Windows.Forms.TextBox txtLeftOpposite;
        private System.Windows.Forms.TextBox txtLeftAdjacent;
        private System.Windows.Forms.TextBox txtLeftHypotenuse;
    }
}

