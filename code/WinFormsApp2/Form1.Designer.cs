namespace WinFormsApp2
{
	partial class Form1
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
			txtResult = new System.Windows.Forms.TextBox();
			btn7 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			btn8 = new System.Windows.Forms.Button();
			btnDelete = new System.Windows.Forms.Button();
			btnClear = new System.Windows.Forms.Button();
			btn4 = new System.Windows.Forms.Button();
			btn5 = new System.Windows.Forms.Button();
			btn6 = new System.Windows.Forms.Button();
			btnMultiply = new System.Windows.Forms.Button();
			btnRestart = new System.Windows.Forms.Button();
			btn1 = new System.Windows.Forms.Button();
			btn2 = new System.Windows.Forms.Button();
			btn3 = new System.Windows.Forms.Button();
			btnEquals = new System.Windows.Forms.Button();
			btnExtraction = new System.Windows.Forms.Button();
			btn0 = new System.Windows.Forms.Button();
			btnDot = new System.Windows.Forms.Button();
			btnSubtraction = new System.Windows.Forms.Button();
			lblCalculation = new System.Windows.Forms.Label();
			SuspendLayout();
			// 
			// txtResult
			// 
			txtResult.Location = new System.Drawing.Point(12, 51);
			txtResult.Multiline = true;
			txtResult.Name = "txtResult";
			txtResult.Size = new System.Drawing.Size(574, 56);
			txtResult.TabIndex = 0;
			// 
			// btn7
			// 
			btn7.Location = new System.Drawing.Point(12, 123);
			btn7.Name = "btn7";
			btn7.Size = new System.Drawing.Size(110, 50);
			btn7.TabIndex = 1;
			btn7.Text = "7";
			btn7.UseVisualStyleBackColor = true;
			btn7.Click += btnNumber_Click;
			// 
			// button2
			// 
			button2.Location = new System.Drawing.Point(244, 123);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(110, 50);
			button2.TabIndex = 2;
			button2.Text = "9";
			button2.UseVisualStyleBackColor = true;
			button2.Click += btnNumber_Click;
			// 
			// btn8
			// 
			btn8.Location = new System.Drawing.Point(128, 123);
			btn8.Name = "btn8";
			btn8.Size = new System.Drawing.Size(110, 50);
			btn8.TabIndex = 2;
			btn8.Text = "8";
			btn8.UseVisualStyleBackColor = true;
			btn8.Click += btnNumber_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new System.Drawing.Point(360, 123);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new System.Drawing.Size(110, 50);
			btnDelete.TabIndex = 3;
			btnDelete.Text = "/";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnOperator_Click;
			// 
			// btnClear
			// 
			btnClear.Location = new System.Drawing.Point(476, 123);
			btnClear.Name = "btnClear";
			btnClear.Size = new System.Drawing.Size(110, 50);
			btnClear.TabIndex = 4;
			btnClear.Text = "CE";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += button5_Click;
			// 
			// btn4
			// 
			btn4.Location = new System.Drawing.Point(12, 179);
			btn4.Name = "btn4";
			btn4.Size = new System.Drawing.Size(110, 50);
			btn4.TabIndex = 5;
			btn4.Text = "4";
			btn4.UseVisualStyleBackColor = true;
			btn4.Click += btnNumber_Click;
			// 
			// btn5
			// 
			btn5.Location = new System.Drawing.Point(128, 179);
			btn5.Name = "btn5";
			btn5.Size = new System.Drawing.Size(110, 50);
			btn5.TabIndex = 6;
			btn5.Text = "5";
			btn5.UseVisualStyleBackColor = true;
			btn5.Click += btnNumber_Click;
			// 
			// btn6
			// 
			btn6.Location = new System.Drawing.Point(244, 179);
			btn6.Name = "btn6";
			btn6.Size = new System.Drawing.Size(110, 50);
			btn6.TabIndex = 7;
			btn6.Text = "6";
			btn6.UseVisualStyleBackColor = true;
			btn6.Click += btnNumber_Click;
			// 
			// btnMultiply
			// 
			btnMultiply.Location = new System.Drawing.Point(360, 179);
			btnMultiply.Name = "btnMultiply";
			btnMultiply.Size = new System.Drawing.Size(110, 50);
			btnMultiply.TabIndex = 8;
			btnMultiply.Text = "*";
			btnMultiply.UseVisualStyleBackColor = true;
			btnMultiply.Click += btnOperator_Click;
			// 
			// btnRestart
			// 
			btnRestart.Location = new System.Drawing.Point(476, 179);
			btnRestart.Name = "btnRestart";
			btnRestart.Size = new System.Drawing.Size(110, 50);
			btnRestart.TabIndex = 9;
			btnRestart.Text = "C";
			btnRestart.UseVisualStyleBackColor = true;
			btnRestart.Click += btnRestart_Click;
			// 
			// btn1
			// 
			btn1.Location = new System.Drawing.Point(12, 235);
			btn1.Name = "btn1";
			btn1.Size = new System.Drawing.Size(110, 50);
			btn1.TabIndex = 10;
			btn1.Text = "1";
			btn1.UseVisualStyleBackColor = true;
			btn1.Click += btnNumber_Click;
			// 
			// btn2
			// 
			btn2.Location = new System.Drawing.Point(128, 235);
			btn2.Name = "btn2";
			btn2.Size = new System.Drawing.Size(110, 50);
			btn2.TabIndex = 11;
			btn2.Text = "2";
			btn2.UseVisualStyleBackColor = true;
			btn2.Click += btnNumber_Click;
			// 
			// btn3
			// 
			btn3.Location = new System.Drawing.Point(244, 235);
			btn3.Name = "btn3";
			btn3.Size = new System.Drawing.Size(110, 50);
			btn3.TabIndex = 12;
			btn3.Text = "3";
			btn3.UseVisualStyleBackColor = true;
			btn3.Click += btnNumber_Click;
			// 
			// btnEquals
			// 
			btnEquals.Location = new System.Drawing.Point(476, 235);
			btnEquals.Name = "btnEquals";
			btnEquals.Size = new System.Drawing.Size(110, 106);
			btnEquals.TabIndex = 13;
			btnEquals.Text = "=";
			btnEquals.UseVisualStyleBackColor = true;
			btnEquals.Click += btnEquals_Click;
			// 
			// btnExtraction
			// 
			btnExtraction.Location = new System.Drawing.Point(360, 235);
			btnExtraction.Name = "btnExtraction";
			btnExtraction.Size = new System.Drawing.Size(110, 50);
			btnExtraction.TabIndex = 13;
			btnExtraction.Text = "-";
			btnExtraction.UseVisualStyleBackColor = true;
			btnExtraction.Click += btnOperator_Click;
			// 
			// btn0
			// 
			btn0.Location = new System.Drawing.Point(12, 291);
			btn0.Name = "btn0";
			btn0.Size = new System.Drawing.Size(226, 50);
			btn0.TabIndex = 14;
			btn0.Text = "0";
			btn0.UseVisualStyleBackColor = true;
			btn0.Click += btnNumber_Click;
			// 
			// btnDot
			// 
			btnDot.Location = new System.Drawing.Point(244, 291);
			btnDot.Name = "btnDot";
			btnDot.Size = new System.Drawing.Size(110, 50);
			btnDot.TabIndex = 15;
			btnDot.Text = ".";
			btnDot.UseVisualStyleBackColor = true;
			btnDot.Click += btnNumber_Click;
			// 
			// btnSubtraction
			// 
			btnSubtraction.Location = new System.Drawing.Point(360, 291);
			btnSubtraction.Name = "btnSubtraction";
			btnSubtraction.Size = new System.Drawing.Size(110, 50);
			btnSubtraction.TabIndex = 17;
			btnSubtraction.Text = "+";
			btnSubtraction.UseVisualStyleBackColor = true;
			btnSubtraction.Click += btnOperator_Click;
			// 
			// lblCalculation
			// 
			lblCalculation.AutoSize = true;
			lblCalculation.Location = new System.Drawing.Point(536, 18);
			lblCalculation.Name = "lblCalculation";
			lblCalculation.Size = new System.Drawing.Size(50, 20);
			lblCalculation.TabIndex = 18;
			lblCalculation.Text = "label1";
			// 
			// Form1
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.ActiveCaption;
			ClientSize = new System.Drawing.Size(596, 354);
			Controls.Add(lblCalculation);
			Controls.Add(btnSubtraction);
			Controls.Add(btnDot);
			Controls.Add(btn0);
			Controls.Add(btnExtraction);
			Controls.Add(btnEquals);
			Controls.Add(btn3);
			Controls.Add(btn2);
			Controls.Add(btn1);
			Controls.Add(btnRestart);
			Controls.Add(btnMultiply);
			Controls.Add(btn6);
			Controls.Add(btn5);
			Controls.Add(btn4);
			Controls.Add(btnClear);
			Controls.Add(btnDelete);
			Controls.Add(btn8);
			Controls.Add(button2);
			Controls.Add(btn7);
			Controls.Add(txtResult);
			Name = "Form1";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btnMultiply;
		private System.Windows.Forms.Button btnRestart;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btnEquals;
		private System.Windows.Forms.Button btnExtraction;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btnDot;
		private System.Windows.Forms.Button btnSubtraction;
		private System.Windows.Forms.Label lblCalculation;
	}
}
