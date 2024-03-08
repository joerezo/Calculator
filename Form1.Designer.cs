namespace Assignment4_2Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtInputDisplay = new System.Windows.Forms.TextBox();
            this.lblCurrentDisplay = new System.Windows.Forms.Label();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.lblDecimalPlaces = new System.Windows.Forms.Label();
            this.panelDecimal = new System.Windows.Forms.Panel();
            this.btnConvertToRomanNumerals = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnPI = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.checkBoxConvertToRN = new System.Windows.Forms.CheckBox();
            this.richTextBoxDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.pictureBoxUnderDecimal = new System.Windows.Forms.PictureBox();
            this.panelRomanNumerals = new System.Windows.Forms.Panel();
            this.btnRNtoDecimalConvert = new System.Windows.Forms.Button();
            this.btnRN_M = new System.Windows.Forms.Button();
            this.btnRN_D = new System.Windows.Forms.Button();
            this.btnRN_C = new System.Windows.Forms.Button();
            this.btnRN_L = new System.Windows.Forms.Button();
            this.btnRN_X = new System.Windows.Forms.Button();
            this.btnRN_V = new System.Windows.Forms.Button();
            this.btnRN_I = new System.Windows.Forms.Button();
            this.lblHistory = new System.Windows.Forms.Label();
            this.numericUpDownDecimal = new System.Windows.Forms.NumericUpDown();
            this.panelDecimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnderDecimal)).BeginInit();
            this.panelRomanNumerals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInputDisplay
            // 
            this.txtInputDisplay.Location = new System.Drawing.Point(271, 72);
            this.txtInputDisplay.Name = "txtInputDisplay";
            this.txtInputDisplay.Size = new System.Drawing.Size(201, 20);
            this.txtInputDisplay.TabIndex = 0;
            this.txtInputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCurrentDisplay
            // 
            this.lblCurrentDisplay.AutoSize = true;
            this.lblCurrentDisplay.Location = new System.Drawing.Point(268, 28);
            this.lblCurrentDisplay.Name = "lblCurrentDisplay";
            this.lblCurrentDisplay.Size = new System.Drawing.Size(204, 13);
            this.lblCurrentDisplay.TabIndex = 1;
            this.lblCurrentDisplay.Text = "This Will Display the values being entered";
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(3, 86);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 23);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(79, 86);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 23);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(159, 86);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 23);
            this.btn9.TabIndex = 4;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(3, 115);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(79, 115);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(159, 115);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 23);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(3, 144);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(79, 144);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(159, 144);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // lblDecimalPlaces
            // 
            this.lblDecimalPlaces.AutoSize = true;
            this.lblDecimalPlaces.Location = new System.Drawing.Point(55, 72);
            this.lblDecimalPlaces.Name = "lblDecimalPlaces";
            this.lblDecimalPlaces.Size = new System.Drawing.Size(80, 13);
            this.lblDecimalPlaces.TabIndex = 12;
            this.lblDecimalPlaces.Text = "Decimal Places";
            // 
            // panelDecimal
            // 
            this.panelDecimal.Controls.Add(this.btnConvertToRomanNumerals);
            this.panelDecimal.Controls.Add(this.btnSqrt);
            this.panelDecimal.Controls.Add(this.btnSquare);
            this.panelDecimal.Controls.Add(this.btnPI);
            this.panelDecimal.Controls.Add(this.btnEquals);
            this.panelDecimal.Controls.Add(this.btnAdd);
            this.panelDecimal.Controls.Add(this.btnPlusMinus);
            this.panelDecimal.Controls.Add(this.btnDecimal);
            this.panelDecimal.Controls.Add(this.btnSubtract);
            this.panelDecimal.Controls.Add(this.btnMultiply);
            this.panelDecimal.Controls.Add(this.btnDivide);
            this.panelDecimal.Controls.Add(this.btnZero);
            this.panelDecimal.Controls.Add(this.btn1);
            this.panelDecimal.Controls.Add(this.btn2);
            this.panelDecimal.Controls.Add(this.btn6);
            this.panelDecimal.Controls.Add(this.btn9);
            this.panelDecimal.Controls.Add(this.btn3);
            this.panelDecimal.Controls.Add(this.btn8);
            this.panelDecimal.Controls.Add(this.btn5);
            this.panelDecimal.Controls.Add(this.btn7);
            this.panelDecimal.Controls.Add(this.btn4);
            this.panelDecimal.Location = new System.Drawing.Point(226, 100);
            this.panelDecimal.Name = "panelDecimal";
            this.panelDecimal.Size = new System.Drawing.Size(356, 235);
            this.panelDecimal.TabIndex = 13;
            // 
            // btnConvertToRomanNumerals
            // 
            this.btnConvertToRomanNumerals.Location = new System.Drawing.Point(3, 18);
            this.btnConvertToRomanNumerals.Name = "btnConvertToRomanNumerals";
            this.btnConvertToRomanNumerals.Size = new System.Drawing.Size(75, 52);
            this.btnConvertToRomanNumerals.TabIndex = 28;
            this.btnConvertToRomanNumerals.Text = "Convert To \r\nRoman Numerals";
            this.btnConvertToRomanNumerals.UseVisualStyleBackColor = true;
            this.btnConvertToRomanNumerals.Click += new System.EventHandler(this.btnConvertToRomanNumerals_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(160, 19);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(75, 23);
            this.btnSqrt.TabIndex = 27;
            this.btnSqrt.Text = "sqrt(x)";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(160, 48);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(75, 23);
            this.btnSquare.TabIndex = 26;
            this.btnSquare.Text = "x^2";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnPI
            // 
            this.btnPI.Location = new System.Drawing.Point(79, 48);
            this.btnPI.Name = "btnPI";
            this.btnPI.Size = new System.Drawing.Size(75, 23);
            this.btnPI.TabIndex = 25;
            this.btnPI.Text = "PI";
            this.btnPI.UseVisualStyleBackColor = true;
            this.btnPI.Click += new System.EventHandler(this.btnPI_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(229, 341);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 52);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(55, 202);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(179, 23);
            this.btnEquals.TabIndex = 23;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.Location = new System.Drawing.Point(3, 173);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(75, 23);
            this.btnPlusMinus.TabIndex = 16;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(160, 173);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(75, 23);
            this.btnDecimal.TabIndex = 18;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(79, 173);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(75, 23);
            this.btnZero.TabIndex = 17;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(278, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(278, 142);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 23);
            this.btnSubtract.TabIndex = 21;
            this.btnSubtract.Text = "─";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(278, 113);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 23);
            this.btnMultiply.TabIndex = 20;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(278, 84);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 19;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // checkBoxConvertToRN
            // 
            this.checkBoxConvertToRN.AutoSize = true;
            this.checkBoxConvertToRN.Location = new System.Drawing.Point(12, 118);
            this.checkBoxConvertToRN.Name = "checkBoxConvertToRN";
            this.checkBoxConvertToRN.Size = new System.Drawing.Size(123, 30);
            this.checkBoxConvertToRN.TabIndex = 15;
            this.checkBoxConvertToRN.Text = "Convert Roman \r\nNumerals to Decimal";
            this.checkBoxConvertToRN.UseVisualStyleBackColor = true;
            this.checkBoxConvertToRN.CheckedChanged += new System.EventHandler(this.checkBoxConvertToRN_CheckedChanged);
            // 
            // richTextBoxDisplayHistory
            // 
            this.richTextBoxDisplayHistory.Location = new System.Drawing.Point(605, 100);
            this.richTextBoxDisplayHistory.Name = "richTextBoxDisplayHistory";
            this.richTextBoxDisplayHistory.Size = new System.Drawing.Size(183, 294);
            this.richTextBoxDisplayHistory.TabIndex = 16;
            this.richTextBoxDisplayHistory.Text = "";
            // 
            // pictureBoxUnderDecimal
            // 
            this.pictureBoxUnderDecimal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnderDecimal.BackgroundImage")));
            this.pictureBoxUnderDecimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUnderDecimal.Location = new System.Drawing.Point(198, 55);
            this.pictureBoxUnderDecimal.Name = "pictureBoxUnderDecimal";
            this.pictureBoxUnderDecimal.Size = new System.Drawing.Size(335, 392);
            this.pictureBoxUnderDecimal.TabIndex = 17;
            this.pictureBoxUnderDecimal.TabStop = false;
            // 
            // panelRomanNumerals
            // 
            this.panelRomanNumerals.Controls.Add(this.btnRNtoDecimalConvert);
            this.panelRomanNumerals.Controls.Add(this.btnRN_M);
            this.panelRomanNumerals.Controls.Add(this.btnRN_D);
            this.panelRomanNumerals.Controls.Add(this.btnRN_C);
            this.panelRomanNumerals.Controls.Add(this.btnRN_L);
            this.panelRomanNumerals.Controls.Add(this.btnRN_X);
            this.panelRomanNumerals.Controls.Add(this.btnRN_V);
            this.panelRomanNumerals.Controls.Add(this.btnRN_I);
            this.panelRomanNumerals.Location = new System.Drawing.Point(17, 154);
            this.panelRomanNumerals.Name = "panelRomanNumerals";
            this.panelRomanNumerals.Size = new System.Drawing.Size(161, 211);
            this.panelRomanNumerals.TabIndex = 18;
            // 
            // btnRNtoDecimalConvert
            // 
            this.btnRNtoDecimalConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRNtoDecimalConvert.Location = new System.Drawing.Point(120, 3);
            this.btnRNtoDecimalConvert.Name = "btnRNtoDecimalConvert";
            this.btnRNtoDecimalConvert.Size = new System.Drawing.Size(38, 197);
            this.btnRNtoDecimalConvert.TabIndex = 7;
            this.btnRNtoDecimalConvert.Text = "CONVERT";
            this.btnRNtoDecimalConvert.UseVisualStyleBackColor = true;
            this.btnRNtoDecimalConvert.Click += new System.EventHandler(this.btnRNtoDecimalConvert_Click);
            // 
            // btnRN_M
            // 
            this.btnRN_M.Location = new System.Drawing.Point(22, 177);
            this.btnRN_M.Name = "btnRN_M";
            this.btnRN_M.Size = new System.Drawing.Size(75, 23);
            this.btnRN_M.TabIndex = 6;
            this.btnRN_M.Text = "M";
            this.btnRN_M.UseVisualStyleBackColor = true;
            this.btnRN_M.Click += new System.EventHandler(this.btnRN_M_Click);
            // 
            // btnRN_D
            // 
            this.btnRN_D.Location = new System.Drawing.Point(22, 147);
            this.btnRN_D.Name = "btnRN_D";
            this.btnRN_D.Size = new System.Drawing.Size(75, 23);
            this.btnRN_D.TabIndex = 5;
            this.btnRN_D.Text = "D";
            this.btnRN_D.UseVisualStyleBackColor = true;
            this.btnRN_D.Click += new System.EventHandler(this.btnRN_D_Click);
            // 
            // btnRN_C
            // 
            this.btnRN_C.Location = new System.Drawing.Point(22, 117);
            this.btnRN_C.Name = "btnRN_C";
            this.btnRN_C.Size = new System.Drawing.Size(75, 23);
            this.btnRN_C.TabIndex = 4;
            this.btnRN_C.Text = "C";
            this.btnRN_C.UseVisualStyleBackColor = true;
            this.btnRN_C.Click += new System.EventHandler(this.btnRN_C_Click);
            // 
            // btnRN_L
            // 
            this.btnRN_L.Location = new System.Drawing.Point(22, 89);
            this.btnRN_L.Name = "btnRN_L";
            this.btnRN_L.Size = new System.Drawing.Size(75, 23);
            this.btnRN_L.TabIndex = 3;
            this.btnRN_L.Text = "L";
            this.btnRN_L.UseVisualStyleBackColor = true;
            this.btnRN_L.Click += new System.EventHandler(this.btnRN_L_Click);
            // 
            // btnRN_X
            // 
            this.btnRN_X.Location = new System.Drawing.Point(22, 60);
            this.btnRN_X.Name = "btnRN_X";
            this.btnRN_X.Size = new System.Drawing.Size(75, 23);
            this.btnRN_X.TabIndex = 2;
            this.btnRN_X.Text = "X";
            this.btnRN_X.UseVisualStyleBackColor = true;
            this.btnRN_X.Click += new System.EventHandler(this.btnRN_X_Click);
            // 
            // btnRN_V
            // 
            this.btnRN_V.Location = new System.Drawing.Point(22, 32);
            this.btnRN_V.Name = "btnRN_V";
            this.btnRN_V.Size = new System.Drawing.Size(75, 23);
            this.btnRN_V.TabIndex = 1;
            this.btnRN_V.Text = "V";
            this.btnRN_V.UseVisualStyleBackColor = true;
            this.btnRN_V.Click += new System.EventHandler(this.btnRN_V_Click);
            // 
            // btnRN_I
            // 
            this.btnRN_I.Location = new System.Drawing.Point(22, 3);
            this.btnRN_I.Name = "btnRN_I";
            this.btnRN_I.Size = new System.Drawing.Size(75, 23);
            this.btnRN_I.TabIndex = 0;
            this.btnRN_I.Text = "I";
            this.btnRN_I.UseVisualStyleBackColor = true;
            this.btnRN_I.Click += new System.EventHandler(this.btnRN_I_Click);
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(605, 55);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(39, 13);
            this.lblHistory.TabIndex = 19;
            this.lblHistory.Text = "History";
            // 
            // numericUpDownDecimal
            // 
            this.numericUpDownDecimal.Location = new System.Drawing.Point(58, 88);
            this.numericUpDownDecimal.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownDecimal.Name = "numericUpDownDecimal";
            this.numericUpDownDecimal.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDecimal.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownDecimal);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.panelRomanNumerals);
            this.Controls.Add(this.richTextBoxDisplayHistory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.checkBoxConvertToRN);
            this.Controls.Add(this.panelDecimal);
            this.Controls.Add(this.lblDecimalPlaces);
            this.Controls.Add(this.lblCurrentDisplay);
            this.Controls.Add(this.txtInputDisplay);
            this.Controls.Add(this.pictureBoxUnderDecimal);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDecimal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnderDecimal)).EndInit();
            this.panelRomanNumerals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputDisplay;
        private System.Windows.Forms.Label lblCurrentDisplay;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label lblDecimalPlaces;
        private System.Windows.Forms.Panel panelDecimal;
        private System.Windows.Forms.CheckBox checkBoxConvertToRN;
        private System.Windows.Forms.RichTextBox richTextBoxDisplayHistory;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnPI;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConvertToRomanNumerals;
        private System.Windows.Forms.Panel panelRomanNumerals;
        private System.Windows.Forms.Button btnRNtoDecimalConvert;
        private System.Windows.Forms.Button btnRN_M;
        private System.Windows.Forms.Button btnRN_D;
        private System.Windows.Forms.Button btnRN_C;
        private System.Windows.Forms.Button btnRN_L;
        private System.Windows.Forms.Button btnRN_X;
        private System.Windows.Forms.Button btnRN_V;
        private System.Windows.Forms.Button btnRN_I;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.NumericUpDown numericUpDownDecimal;
        private System.Windows.Forms.PictureBox pictureBoxUnderDecimal;
    }
}

