namespace DBProgramming
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxCombo = new System.Windows.Forms.GroupBox();
            this.buttonComboBoxCalculator = new System.Windows.Forms.Button();
            this.comboBoxComboCalc_Operater = new System.Windows.Forms.ComboBox();
            this.textBoxComboCalc_Result = new System.Windows.Forms.TextBox();
            this.textBoxComboCalc_Oper2 = new System.Windows.Forms.TextBox();
            this.textBoxComboCalc_Oper1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxRadio = new System.Windows.Forms.GroupBox();
            this.radioButtonRadioCalc_Operater_squaring = new System.Windows.Forms.RadioButton();
            this.radioButtonRadioCalc_Operater_divide = new System.Windows.Forms.RadioButton();
            this.radioButtonRadioCalc_Operater_multiply = new System.Windows.Forms.RadioButton();
            this.radioButtonRadioCalc_Operater_minus = new System.Windows.Forms.RadioButton();
            this.radioButtonRadioCalc_Operater_plus = new System.Windows.Forms.RadioButton();
            this.buttonRadioBtnCalculator = new System.Windows.Forms.Button();
            this.textBoxRadioCalc_Result = new System.Windows.Forms.TextBox();
            this.textBoxRadioCalc_Oper2 = new System.Windows.Forms.TextBox();
            this.textBoxRadioCalc_Oper1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxCombo.SuspendLayout();
            this.groupBoxRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCombo
            // 
            this.groupBoxCombo.Controls.Add(this.buttonComboBoxCalculator);
            this.groupBoxCombo.Controls.Add(this.comboBoxComboCalc_Operater);
            this.groupBoxCombo.Controls.Add(this.textBoxComboCalc_Result);
            this.groupBoxCombo.Controls.Add(this.textBoxComboCalc_Oper2);
            this.groupBoxCombo.Controls.Add(this.textBoxComboCalc_Oper1);
            this.groupBoxCombo.Controls.Add(this.label4);
            this.groupBoxCombo.Controls.Add(this.label3);
            this.groupBoxCombo.Controls.Add(this.label2);
            this.groupBoxCombo.Controls.Add(this.label1);
            this.groupBoxCombo.Location = new System.Drawing.Point(55, 37);
            this.groupBoxCombo.Name = "groupBoxCombo";
            this.groupBoxCombo.Size = new System.Drawing.Size(650, 116);
            this.groupBoxCombo.TabIndex = 0;
            this.groupBoxCombo.TabStop = false;
            this.groupBoxCombo.Text = "ComboBox based Calculator";
            // 
            // buttonComboBoxCalculator
            // 
            this.buttonComboBoxCalculator.Location = new System.Drawing.Point(419, 54);
            this.buttonComboBoxCalculator.Name = "buttonComboBoxCalculator";
            this.buttonComboBoxCalculator.Size = new System.Drawing.Size(75, 23);
            this.buttonComboBoxCalculator.TabIndex = 9;
            this.buttonComboBoxCalculator.Text = "Calculate";
            this.buttonComboBoxCalculator.UseVisualStyleBackColor = true;
            this.buttonComboBoxCalculator.Click += new System.EventHandler(this.buttonComboBoxCalculator_Click);
            // 
            // comboBoxComboCalc_Operater
            // 
            this.comboBoxComboCalc_Operater.FormattingEnabled = true;
            this.comboBoxComboCalc_Operater.Location = new System.Drawing.Point(160, 56);
            this.comboBoxComboCalc_Operater.Name = "comboBoxComboCalc_Operater";
            this.comboBoxComboCalc_Operater.Size = new System.Drawing.Size(90, 20);
            this.comboBoxComboCalc_Operater.TabIndex = 8;
            // 
            // textBoxComboCalc_Result
            // 
            this.textBoxComboCalc_Result.Location = new System.Drawing.Point(516, 57);
            this.textBoxComboCalc_Result.Name = "textBoxComboCalc_Result";
            this.textBoxComboCalc_Result.Size = new System.Drawing.Size(110, 21);
            this.textBoxComboCalc_Result.TabIndex = 7;
            // 
            // textBoxComboCalc_Oper2
            // 
            this.textBoxComboCalc_Oper2.Location = new System.Drawing.Point(289, 57);
            this.textBoxComboCalc_Oper2.Name = "textBoxComboCalc_Oper2";
            this.textBoxComboCalc_Oper2.Size = new System.Drawing.Size(100, 21);
            this.textBoxComboCalc_Oper2.TabIndex = 6;
            // 
            // textBoxComboCalc_Oper1
            // 
            this.textBoxComboCalc_Oper1.Location = new System.Drawing.Point(24, 57);
            this.textBoxComboCalc_Oper1.Name = "textBoxComboCalc_Oper1";
            this.textBoxComboCalc_Oper1.Size = new System.Drawing.Size(100, 21);
            this.textBoxComboCalc_Oper1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Operand 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operand 1";
            // 
            // groupBoxRadio
            // 
            this.groupBoxRadio.Controls.Add(this.radioButtonRadioCalc_Operater_squaring);
            this.groupBoxRadio.Controls.Add(this.radioButtonRadioCalc_Operater_divide);
            this.groupBoxRadio.Controls.Add(this.radioButtonRadioCalc_Operater_multiply);
            this.groupBoxRadio.Controls.Add(this.radioButtonRadioCalc_Operater_minus);
            this.groupBoxRadio.Controls.Add(this.radioButtonRadioCalc_Operater_plus);
            this.groupBoxRadio.Controls.Add(this.buttonRadioBtnCalculator);
            this.groupBoxRadio.Controls.Add(this.textBoxRadioCalc_Result);
            this.groupBoxRadio.Controls.Add(this.textBoxRadioCalc_Oper2);
            this.groupBoxRadio.Controls.Add(this.textBoxRadioCalc_Oper1);
            this.groupBoxRadio.Controls.Add(this.label5);
            this.groupBoxRadio.Controls.Add(this.label6);
            this.groupBoxRadio.Controls.Add(this.label7);
            this.groupBoxRadio.Controls.Add(this.label8);
            this.groupBoxRadio.Location = new System.Drawing.Point(55, 209);
            this.groupBoxRadio.Name = "groupBoxRadio";
            this.groupBoxRadio.Size = new System.Drawing.Size(650, 116);
            this.groupBoxRadio.TabIndex = 10;
            this.groupBoxRadio.TabStop = false;
            this.groupBoxRadio.Text = "RadioButton based Calculator";
            // 
            // radioButtonRadioCalc_Operater_squaring
            // 
            this.radioButtonRadioCalc_Operater_squaring.AutoSize = true;
            this.radioButtonRadioCalc_Operater_squaring.Location = new System.Drawing.Point(231, 54);
            this.radioButtonRadioCalc_Operater_squaring.Name = "radioButtonRadioCalc_Operater_squaring";
            this.radioButtonRadioCalc_Operater_squaring.Size = new System.Drawing.Size(29, 16);
            this.radioButtonRadioCalc_Operater_squaring.TabIndex = 14;
            this.radioButtonRadioCalc_Operater_squaring.TabStop = true;
            this.radioButtonRadioCalc_Operater_squaring.Text = "^";
            this.radioButtonRadioCalc_Operater_squaring.UseVisualStyleBackColor = true;
            // 
            // radioButtonRadioCalc_Operater_divide
            // 
            this.radioButtonRadioCalc_Operater_divide.AutoSize = true;
            this.radioButtonRadioCalc_Operater_divide.Location = new System.Drawing.Point(196, 76);
            this.radioButtonRadioCalc_Operater_divide.Name = "radioButtonRadioCalc_Operater_divide";
            this.radioButtonRadioCalc_Operater_divide.Size = new System.Drawing.Size(29, 16);
            this.radioButtonRadioCalc_Operater_divide.TabIndex = 13;
            this.radioButtonRadioCalc_Operater_divide.TabStop = true;
            this.radioButtonRadioCalc_Operater_divide.Text = "/";
            this.radioButtonRadioCalc_Operater_divide.UseVisualStyleBackColor = true;
            // 
            // radioButtonRadioCalc_Operater_multiply
            // 
            this.radioButtonRadioCalc_Operater_multiply.AutoSize = true;
            this.radioButtonRadioCalc_Operater_multiply.Location = new System.Drawing.Point(161, 76);
            this.radioButtonRadioCalc_Operater_multiply.Name = "radioButtonRadioCalc_Operater_multiply";
            this.radioButtonRadioCalc_Operater_multiply.Size = new System.Drawing.Size(29, 16);
            this.radioButtonRadioCalc_Operater_multiply.TabIndex = 12;
            this.radioButtonRadioCalc_Operater_multiply.TabStop = true;
            this.radioButtonRadioCalc_Operater_multiply.Text = "*";
            this.radioButtonRadioCalc_Operater_multiply.UseVisualStyleBackColor = true;
            // 
            // radioButtonRadioCalc_Operater_minus
            // 
            this.radioButtonRadioCalc_Operater_minus.AutoSize = true;
            this.radioButtonRadioCalc_Operater_minus.Location = new System.Drawing.Point(196, 54);
            this.radioButtonRadioCalc_Operater_minus.Name = "radioButtonRadioCalc_Operater_minus";
            this.radioButtonRadioCalc_Operater_minus.Size = new System.Drawing.Size(29, 16);
            this.radioButtonRadioCalc_Operater_minus.TabIndex = 11;
            this.radioButtonRadioCalc_Operater_minus.TabStop = true;
            this.radioButtonRadioCalc_Operater_minus.Text = "-";
            this.radioButtonRadioCalc_Operater_minus.UseVisualStyleBackColor = true;
            // 
            // radioButtonRadioCalc_Operater_plus
            // 
            this.radioButtonRadioCalc_Operater_plus.AutoSize = true;
            this.radioButtonRadioCalc_Operater_plus.Location = new System.Drawing.Point(161, 54);
            this.radioButtonRadioCalc_Operater_plus.Name = "radioButtonRadioCalc_Operater_plus";
            this.radioButtonRadioCalc_Operater_plus.Size = new System.Drawing.Size(29, 16);
            this.radioButtonRadioCalc_Operater_plus.TabIndex = 10;
            this.radioButtonRadioCalc_Operater_plus.TabStop = true;
            this.radioButtonRadioCalc_Operater_plus.Text = "+";
            this.radioButtonRadioCalc_Operater_plus.UseVisualStyleBackColor = true;
            // 
            // buttonRadioBtnCalculator
            // 
            this.buttonRadioBtnCalculator.Location = new System.Drawing.Point(419, 54);
            this.buttonRadioBtnCalculator.Name = "buttonRadioBtnCalculator";
            this.buttonRadioBtnCalculator.Size = new System.Drawing.Size(75, 23);
            this.buttonRadioBtnCalculator.TabIndex = 9;
            this.buttonRadioBtnCalculator.Text = "Calculate";
            this.buttonRadioBtnCalculator.UseVisualStyleBackColor = true;
            this.buttonRadioBtnCalculator.Click += new System.EventHandler(this.buttonRadioBtnCalculator_Click);
            // 
            // textBoxRadioCalc_Result
            // 
            this.textBoxRadioCalc_Result.Location = new System.Drawing.Point(516, 57);
            this.textBoxRadioCalc_Result.Name = "textBoxRadioCalc_Result";
            this.textBoxRadioCalc_Result.Size = new System.Drawing.Size(110, 21);
            this.textBoxRadioCalc_Result.TabIndex = 7;
            // 
            // textBoxRadioCalc_Oper2
            // 
            this.textBoxRadioCalc_Oper2.Location = new System.Drawing.Point(289, 57);
            this.textBoxRadioCalc_Oper2.Name = "textBoxRadioCalc_Oper2";
            this.textBoxRadioCalc_Oper2.Size = new System.Drawing.Size(100, 21);
            this.textBoxRadioCalc_Oper2.TabIndex = 6;
            // 
            // textBoxRadioCalc_Oper1
            // 
            this.textBoxRadioCalc_Oper1.Location = new System.Drawing.Point(24, 57);
            this.textBoxRadioCalc_Oper1.Name = "textBoxRadioCalc_Oper1";
            this.textBoxRadioCalc_Oper1.Size = new System.Drawing.Size(100, 21);
            this.textBoxRadioCalc_Oper1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Operand 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "Operator";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "Operand 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 388);
            this.Controls.Add(this.groupBoxRadio);
            this.Controls.Add(this.groupBoxCombo);
            this.Name = "Form1";
            this.Text = "Calcultor";
            this.groupBoxCombo.ResumeLayout(false);
            this.groupBoxCombo.PerformLayout();
            this.groupBoxRadio.ResumeLayout(false);
            this.groupBoxRadio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonComboBoxCalculator;
        private System.Windows.Forms.ComboBox comboBoxComboCalc_Operater;
        private System.Windows.Forms.TextBox textBoxComboCalc_Result;
        private System.Windows.Forms.TextBox textBoxComboCalc_Oper2;
        private System.Windows.Forms.TextBox textBoxComboCalc_Oper1;
        private System.Windows.Forms.GroupBox groupBoxRadio;
        private System.Windows.Forms.Button buttonRadioBtnCalculator;
        private System.Windows.Forms.TextBox textBoxRadioCalc_Result;
        private System.Windows.Forms.TextBox textBoxRadioCalc_Oper2;
        private System.Windows.Forms.TextBox textBoxRadioCalc_Oper1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonRadioCalc_Operater_plus;
        private System.Windows.Forms.RadioButton radioButtonRadioCalc_Operater_squaring;
        private System.Windows.Forms.RadioButton radioButtonRadioCalc_Operater_divide;
        private System.Windows.Forms.RadioButton radioButtonRadioCalc_Operater_multiply;
        private System.Windows.Forms.RadioButton radioButtonRadioCalc_Operater_minus;
    }
}

