using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
	public partial class Form1 : Form
	{
		double value = 0;
		double result;
		string operationPerformed = "";
		bool isOperationPerformed = false;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			txtResult.Text = "0";
		}

		private void btnRestart_Click(object sender, EventArgs e)
		{
			txtResult.Text = "0";
			lblCalculation.Text = "";

			if (txtResult.Text == "0")
			{
				value = 0;
				result = 0;
			}

		}

		private void btnOperator_Click(object sender, EventArgs e)
		{
			try
			{
				Button button = (Button)sender;
				operationPerformed = button.Text;
				value = double.Parse(txtResult.Text);
				lblCalculation.Text = value + " " + operationPerformed;
				isOperationPerformed = true;

				if (txtResult.Text == "0")
				{
					value = 0;
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("Invalid Number");
			}
		}

		private void btnNumber_Click(object sender, EventArgs e)
		{
			if (txtResult.Text == "0" || isOperationPerformed)
				txtResult.Clear();

			Button button = (Button)sender;
			if (button.Text == ".")
			{
				if (!txtResult.Text.Contains("."))
					txtResult.Text += button.Text;

			}
			else
				txtResult.Text += button.Text;

			isOperationPerformed = false;
		}

		private void btnEquals_Click(object sender, EventArgs e)
		{
			switch (operationPerformed)
			{
				case "+":
					txtResult.Text = (result = value + double.Parse(txtResult.Text)).ToString();
					break;
				case "-":
					txtResult.Text = (result = value - double.Parse(txtResult.Text)).ToString();
					break;
				case "*":
					txtResult.Text = (result = value * double.Parse(txtResult.Text)).ToString();
					break;
				case "/":
					txtResult.Text = (result = value / double.Parse(txtResult.Text)).ToString();
					break;
			}

		}
	}
}
