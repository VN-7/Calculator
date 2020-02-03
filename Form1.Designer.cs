namespace WindowsFormsApplication2
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
            this.display = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnAns = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.display.Font = new System.Drawing.Font("Bahnschrift Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.display.Location = new System.Drawing.Point(12, 22);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.display.Size = new System.Drawing.Size(421, 43);
            this.display.TabIndex = 0;
            this.display.Tag = "dd";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(357, 81);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDiv.Location = new System.Drawing.Point(357, 177);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(76, 32);
            this.btnDiv.TabIndex = 2;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btn8
            // 
            this.btn8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn8.Location = new System.Drawing.Point(121, 81);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(93, 32);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn5.Location = new System.Drawing.Point(121, 128);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(93, 32);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn2
            // 
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn2.Location = new System.Drawing.Point(121, 177);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(93, 32);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn0
            // 
            this.btn0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn0.Location = new System.Drawing.Point(121, 224);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(93, 32);
            this.btn0.TabIndex = 6;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn7
            // 
            this.btn7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn7.Location = new System.Drawing.Point(12, 81);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(93, 32);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn4
            // 
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn4.Location = new System.Drawing.Point(12, 128);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(93, 32);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn1.Location = new System.Drawing.Point(12, 177);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(93, 32);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(12, 224);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 32);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMult.Location = new System.Drawing.Point(357, 128);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(76, 32);
            this.btnMult.TabIndex = 11;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btn9
            // 
            this.btn9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn9.Location = new System.Drawing.Point(226, 81);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(93, 32);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn3
            // 
            this.btn3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn3.Location = new System.Drawing.Point(226, 177);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(93, 32);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnAns
            // 
            this.btnAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAns.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAns.Location = new System.Drawing.Point(226, 224);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(93, 32);
            this.btnAns.TabIndex = 14;
            this.btnAns.Text = "=";
            this.btnAns.UseVisualStyleBackColor = true;
            this.btnAns.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // btn6
            // 
            this.btn6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn6.Location = new System.Drawing.Point(226, 128);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(93, 32);
            this.btn6.TabIndex = 15;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSub.Location = new System.Drawing.Point(357, 224);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(76, 32);
            this.btnSub.TabIndex = 16;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(449, 273);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnAns);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.display);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(465, 312);
            this.MinimumSize = new System.Drawing.Size(465, 312);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnAns;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnSub;
    }
}

