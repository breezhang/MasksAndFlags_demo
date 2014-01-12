///------------------------------------------------------------------------\\\
///<header>
///  <title>EdwardS: Masks and flags .NET Sample</title>
///  <namespace>EdwardS</namespace>
///  <description>
///    Windows application that hosts the Fields and flags .NET sample
///  </description>
///  <history>
///    <date>04/06/2004</date>
///    <release>Initial Release</release>
///    <author>Edward Smoljanovic</author>
///  </history>
///</header> 		
///------------------------------------------------------------------------\\\
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace EdwardS.Class
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.CheckBox checkBox8;
		private System.Windows.Forms.CheckBox checkBox9;
		private System.Windows.Forms.CheckBox checkBox10;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxHex;
		private System.Windows.Forms.TextBox textBoxDec;
		private System.Windows.Forms.TextBox textBoxBin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonAddFlag;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button buttonRemoveFlag;
		private System.Windows.Forms.Button buttonFill;
		private System.Windows.Forms.ListBox listBoxHistory;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxBinHistory;
		private System.Windows.Forms.TextBox textBoxHexHistory;
		private System.Windows.Forms.TextBox textBoxDecHistory;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button buttonRevert;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label9;
		private BitField bitField;
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Instantiate the bitField object
			bitField = new BitField();
			Redraw();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxHex = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.checkBox8 = new System.Windows.Forms.CheckBox();
			this.checkBox9 = new System.Windows.Forms.CheckBox();
			this.checkBox10 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxDec = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxBin = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonAddFlag = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.buttonRemoveFlag = new System.Windows.Forms.Button();
			this.buttonFill = new System.Windows.Forms.Button();
			this.listBoxHistory = new System.Windows.Forms.ListBox();
			this.textBoxBinHistory = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxHexHistory = new System.Windows.Forms.TextBox();
			this.textBoxDecHistory = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.buttonRevert = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxHex
			// 
			this.textBoxHex.Location = new System.Drawing.Point(296, 72);
			this.textBoxHex.Name = "textBoxHex";
			this.textBoxHex.ReadOnly = true;
			this.textBoxHex.Size = new System.Drawing.Size(104, 20);
			this.textBoxHex.TabIndex = 1;
			this.textBoxHex.Text = "";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(16, 24);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Flag 1";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(16, 56);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.TabIndex = 3;
			this.checkBox2.Text = "Flag 2";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(16, 88);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.TabIndex = 4;
			this.checkBox3.Text = "Flag 3";
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// checkBox4
			// 
			this.checkBox4.Location = new System.Drawing.Point(16, 120);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.TabIndex = 5;
			this.checkBox4.Text = "Flag 4";
			this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
			// 
			// checkBox5
			// 
			this.checkBox5.Location = new System.Drawing.Point(16, 152);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.TabIndex = 6;
			this.checkBox5.Text = "Flag 5";
			this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
			// 
			// checkBox6
			// 
			this.checkBox6.Location = new System.Drawing.Point(120, 24);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.TabIndex = 7;
			this.checkBox6.Text = "Flag 6";
			this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
			// 
			// checkBox7
			// 
			this.checkBox7.Location = new System.Drawing.Point(120, 56);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.TabIndex = 8;
			this.checkBox7.Text = "Flag 7";
			this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
			// 
			// checkBox8
			// 
			this.checkBox8.Location = new System.Drawing.Point(120, 88);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.TabIndex = 9;
			this.checkBox8.Text = "Flag 8";
			this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
			// 
			// checkBox9
			// 
			this.checkBox9.Location = new System.Drawing.Point(120, 120);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.TabIndex = 10;
			this.checkBox9.Text = "Flag 9";
			this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
			// 
			// checkBox10
			// 
			this.checkBox10.Location = new System.Drawing.Point(120, 152);
			this.checkBox10.Name = "checkBox10";
			this.checkBox10.TabIndex = 11;
			this.checkBox10.Text = "Flag 10";
			this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(224, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 12;
			this.label1.Text = "Hexidecimal";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(248, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "Decimal";
			// 
			// textBoxDec
			// 
			this.textBoxDec.Location = new System.Drawing.Point(296, 40);
			this.textBoxDec.Name = "textBoxDec";
			this.textBoxDec.ReadOnly = true;
			this.textBoxDec.Size = new System.Drawing.Size(128, 20);
			this.textBoxDec.TabIndex = 14;
			this.textBoxDec.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(256, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = "Binary";
			// 
			// textBoxBin
			// 
			this.textBoxBin.Location = new System.Drawing.Point(296, 104);
			this.textBoxBin.Name = "textBoxBin";
			this.textBoxBin.ReadOnly = true;
			this.textBoxBin.Size = new System.Drawing.Size(392, 20);
			this.textBoxBin.TabIndex = 16;
			this.textBoxBin.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(320, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 16);
			this.label4.TabIndex = 17;
			this.label4.Text = "BitField";
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(296, 136);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(88, 23);
			this.buttonClear.TabIndex = 18;
			this.buttonClear.Text = "Clear BitField";
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonAddFlag
			// 
			this.buttonAddFlag.Location = new System.Drawing.Point(296, 168);
			this.buttonAddFlag.Name = "buttonAddFlag";
			this.buttonAddFlag.Size = new System.Drawing.Size(88, 23);
			this.buttonAddFlag.TabIndex = 20;
			this.buttonAddFlag.Text = "Add Flag";
			this.buttonAddFlag.Click += new System.EventHandler(this.buttonAddFlag_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(248, 168);
			this.numericUpDown1.Maximum = new System.Decimal(new int[] {
																		   64,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Minimum = new System.Decimal(new int[] {
																		   1,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
			this.numericUpDown1.TabIndex = 4;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																		 1,
																		 0,
																		 0,
																		 0});
			// 
			// buttonRemoveFlag
			// 
			this.buttonRemoveFlag.Location = new System.Drawing.Point(392, 168);
			this.buttonRemoveFlag.Name = "buttonRemoveFlag";
			this.buttonRemoveFlag.Size = new System.Drawing.Size(88, 23);
			this.buttonRemoveFlag.TabIndex = 21;
			this.buttonRemoveFlag.Text = "Remove Flag";
			this.buttonRemoveFlag.Click += new System.EventHandler(this.buttonRemoveFlag_Click);
			// 
			// buttonFill
			// 
			this.buttonFill.Location = new System.Drawing.Point(392, 136);
			this.buttonFill.Name = "buttonFill";
			this.buttonFill.Size = new System.Drawing.Size(88, 23);
			this.buttonFill.TabIndex = 22;
			this.buttonFill.Text = "Fill BitField";
			this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
			// 
			// listBoxHistory
			// 
			this.listBoxHistory.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.listBoxHistory.Location = new System.Drawing.Point(16, 280);
			this.listBoxHistory.Name = "listBoxHistory";
			this.listBoxHistory.Size = new System.Drawing.Size(192, 147);
			this.listBoxHistory.TabIndex = 23;
			this.listBoxHistory.SelectedIndexChanged += new System.EventHandler(this.buttonConvertHistory_Click);
			// 
			// textBoxBinHistory
			// 
			this.textBoxBinHistory.Location = new System.Drawing.Point(296, 344);
			this.textBoxBinHistory.Name = "textBoxBinHistory";
			this.textBoxBinHistory.ReadOnly = true;
			this.textBoxBinHistory.Size = new System.Drawing.Size(392, 20);
			this.textBoxBinHistory.TabIndex = 25;
			this.textBoxBinHistory.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(256, 344);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 23);
			this.label5.TabIndex = 24;
			this.label5.Text = "Binary";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(224, 312);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 23);
			this.label6.TabIndex = 27;
			this.label6.Text = "Hexidecimal";
			// 
			// textBoxHexHistory
			// 
			this.textBoxHexHistory.Location = new System.Drawing.Point(296, 312);
			this.textBoxHexHistory.Name = "textBoxHexHistory";
			this.textBoxHexHistory.ReadOnly = true;
			this.textBoxHexHistory.Size = new System.Drawing.Size(104, 20);
			this.textBoxHexHistory.TabIndex = 26;
			this.textBoxHexHistory.Text = "";
			// 
			// textBoxDecHistory
			// 
			this.textBoxDecHistory.Location = new System.Drawing.Point(296, 280);
			this.textBoxDecHistory.Name = "textBoxDecHistory";
			this.textBoxDecHistory.ReadOnly = true;
			this.textBoxDecHistory.Size = new System.Drawing.Size(128, 20);
			this.textBoxDecHistory.TabIndex = 29;
			this.textBoxDecHistory.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(248, 280);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 23);
			this.label7.TabIndex = 28;
			this.label7.Text = "Decimal";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 256);
			this.label8.Name = "label8";
			this.label8.TabIndex = 31;
			this.label8.Text = "BitField History";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 240);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(672, 8);
			this.button1.TabIndex = 32;
			// 
			// buttonRevert
			// 
			this.buttonRevert.Location = new System.Drawing.Point(296, 376);
			this.buttonRevert.Name = "buttonRevert";
			this.buttonRevert.Size = new System.Drawing.Size(96, 23);
			this.buttonRevert.TabIndex = 33;
			this.buttonRevert.Text = "^ Revert Back ^";
			this.buttonRevert.Click += new System.EventHandler(this.buttonRevert_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(16, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(672, 8);
			this.button2.TabIndex = 34;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(320, 256);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(48, 16);
			this.label9.TabIndex = 35;
			this.label9.Text = "BitField";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(704, 437);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.buttonRevert);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBoxDecHistory);
			this.Controls.Add(this.textBoxHexHistory);
			this.Controls.Add(this.textBoxBinHistory);
			this.Controls.Add(this.textBoxBin);
			this.Controls.Add(this.textBoxDec);
			this.Controls.Add(this.textBoxHex);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.listBoxHistory);
			this.Controls.Add(this.buttonFill);
			this.Controls.Add(this.buttonRemoveFlag);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.buttonAddFlag);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBox10);
			this.Controls.Add(this.checkBox9);
			this.Controls.Add(this.checkBox8);
			this.Controls.Add(this.checkBox7);
			this.Controls.Add(this.checkBox6);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Name = "Form1";
			this.Text = "Masks and Flags";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
 		///Iterate for each checkbox and ensure it is in the proper state
		/// </summary>
		private void RedrawCheckbox()
		{
			SetFlags(BitField.Flag.f1, checkBox1);
			SetFlags(BitField.Flag.f2, checkBox2);
			SetFlags(BitField.Flag.f3, checkBox3);
			SetFlags(BitField.Flag.f4, checkBox4);
			SetFlags(BitField.Flag.f5, checkBox5);
			SetFlags(BitField.Flag.f6, checkBox6);
			SetFlags(BitField.Flag.f7, checkBox7);
			SetFlags(BitField.Flag.f8, checkBox8);
			SetFlags(BitField.Flag.f9, checkBox9);
			SetFlags(BitField.Flag.f10, checkBox10);
		}

		/// <summary>
		/// If flag is set then check the checkbox
		/// </summary>
		/// <param name="flag"></param>
		/// <param name="cb"></param>
		private void SetFlags(BitField.Flag flag, CheckBox cb)
		{
			// if flag is set ensure the box is checked
			if (bitField.AllOn(flag))
			{
				cb.Checked = true;
			}
			else
			{
				cb.Checked = false;
			}
		}


		/// <summary>
		/// Update the Field strings
		/// </summary>
		private void Redraw()
		{
			textBoxDec.Text = bitField.ToStringDec();
			textBoxHex.Text = bitField.ToStringHex();
			textBoxBin.Text = bitField.ToStringBin();
		}

		/// <summary>
		/// Clear the bitField by turning all flags off
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonClear_Click(object sender, System.EventArgs e)
		{
			bitField.ClearField();
			AddToHistory(bitField);
			RedrawCheckbox();
			Redraw();
		}

		/// <summary>
		/// Fill the bit Field by turning all flags on
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonFill_Click(object sender, System.EventArgs e)
		{
			bitField.FillField();
			AddToHistory(bitField);
			RedrawCheckbox();
			Redraw();			
		}

		/// <summary>
		/// Add the specified flag to the bitField
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonAddFlag_Click(object sender, System.EventArgs e)
		{
			bitField.SetOn(BitField.DecimalToFlag(numericUpDown1.Value));
			AddToHistory(bitField);
			RedrawCheckbox();
			Redraw();
		}

		private void buttonRemoveFlag_Click(object sender, System.EventArgs e)
		{
			bitField.SetOff(BitField.DecimalToFlag(numericUpDown1.Value));
			AddToHistory(bitField);
			RedrawCheckbox();
			Redraw();
		
		}

		/// <summary>
		/// Methods to toggle the flag when the check box changes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			//Check if toggle is required
			if (bitField.AllOn(BitField.Flag.f1) != checkBox1.Checked)
			{
				Toggle(BitField.Flag.f1);
			}
			Redraw();
		}

		/// <summary>
		/// Methods to toggle the flag when the check box changes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			//Check if toggle is required
			if (bitField.AllOn(BitField.Flag.f2) != checkBox2.Checked)
			{
				Toggle(BitField.Flag.f2);
			}
			Redraw();
		}

		/// <summary>
		/// Methods to toggle the flag when the check box changes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			//Check if toggle is required
			if (bitField.AllOn(BitField.Flag.f3) != checkBox3.Checked)
			{
				Toggle(BitField.Flag.f3);
			}
			Redraw();
		}

		/// <summary>
		/// Methods to toggle the flag when the check box changes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
		{
			//Check if toggle is required
			if (bitField.AllOn(BitField.Flag.f4) != checkBox4.Checked)
			{
				Toggle(BitField.Flag.f4);
			}
			Redraw();
		}

		/// <summary>
		/// Methods to toggle the flag when the check box changes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkBox5_CheckedChanged(object sender, System.EventArgs e)
		{
			//Check if toggle is required
			if (bitField.AllOn(BitField.Flag.f5) != checkBox5.Checked)
			{
				Toggle(BitField.Flag.f5);
			}
			Redraw();
		}

		/// <summary>
		/// Methods to toggle the flag when the check box changes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkBox6_CheckedChanged(object sender, System.EventArgs e)
		{
			//Check if toggle is required
			if (bitField.AllOn(BitField.Flag.f6) != checkBox6.Checked)
			{
				Toggle(BitField.Flag.f6);
			}
			Redraw();
		}

		/// <summary>
		/// Methods to toggle the flag when the check box changes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkBox7_CheckedChanged(object sender, System.EventArgs e)
		{
			//Check if toggle is required
			if (bitField.AllOn(BitField.Flag.f7) != checkBox7.Checked)
			{
				Toggle(BitField.Flag.f7);
			}
			Redraw();
		}

		/// <summary>
		/// Methods to toggle the flag when the check box changes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkBox8_CheckedChanged(object sender, System.EventArgs e)
		{
			//Check if toggle is required
			if (bitField.AllOn(BitField.Flag.f8) != checkBox8.Checked)
			{
				Toggle(BitField.Flag.f8);
			}
			Redraw();
		}

		/// <summary>
		/// Methods to toggle the flag when the check box changes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkBox9_CheckedChanged(object sender, System.EventArgs e)
		{
			//Check if toggle is required
			if (bitField.AllOn(BitField.Flag.f9) != checkBox9.Checked)
			{
				Toggle(BitField.Flag.f9);
			}
			Redraw();
		}

		/// <summary>
		/// Methods to toggle the flag when the check box changes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkBox10_CheckedChanged(object sender, System.EventArgs e)
		{
			//Check if toggle is required
			if (bitField.AllOn(BitField.Flag.f10) != checkBox10.Checked)
			{
				Toggle(BitField.Flag.f10);
			}
			Redraw();
		}

		/// <summary>
		/// Toggle the flag and add it to the history list
		/// </summary>
		/// <param name="flag"></param>
		private void Toggle(BitField.Flag flag)
		{
			bitField.SetToggle(flag);
			AddToHistory(bitField);

		}

		private void AddToHistory(BitField bm)
		{
			//Add this item to history
			listBoxHistory.Items.Insert(0,bm.ToStringDec());
		}

		/// <summary>
		/// Get the selected item from the history list and polulate the bottom pane
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonConvertHistory_Click(object sender, System.EventArgs e)
		{
			BitField hBitField = new BitField();
			try
			{
				String sVal = listBoxHistory.SelectedItem.ToString();
				hBitField.Mask = System.Convert.ToUInt64(sVal, 10);
			}
			catch (InvalidCastException ice)	//Convert
			{
				Console.WriteLine("Exception caught in buttonConvertHistory_Click: {0}", ice.ToString());
			}
			catch (OverflowException oe)		//Convert
			{
				Console.WriteLine("Exception caught in buttonConvertHistory_Click: {0}", oe.ToString());
			}
			catch (ArgumentNullException ane)	//Format & Convert
			{
				Console.WriteLine("Exception caught in buttonConvertHistory_Click: {0}", ane.ToString());
			}
			catch (FormatException fe)		//Format & Convert
			{
				Console.WriteLine("Exception caught in buttonConvertHistory_Click: {0}", fe.ToString());
			}
			catch (NullReferenceException nre)	//listBoxHistory.SelectedItem
			{
				Console.WriteLine("Exception caught in buttonConvertHistory_Click: {0}", nre.ToString());
			}
			textBoxDecHistory.Text = hBitField.ToStringDec();
			textBoxHexHistory.Text = hBitField.ToStringHex();
			textBoxBinHistory.Text = hBitField.ToStringBin();
			
		}

		/// <summary>
		/// Get the selected item in the history list and populate it in the top pane
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonRevert_Click(object sender, System.EventArgs e)
		{
			BitField hBitField = new BitField();
			try
			{
				String sVal = listBoxHistory.SelectedItem.ToString();
				if (sVal != "")
				{
					hBitField.Mask = System.Convert.ToUInt64(sVal, 10);
					bitField.Mask = hBitField.Mask;
					RedrawCheckbox();
					Redraw();			
				}
			}
			catch (InvalidCastException ice)	//Convert
			{
				Console.WriteLine("Exception caught in buttonRevert_Click: {0}", ice.ToString());
			}
			catch (OverflowException oe)		//Convert
			{
				Console.WriteLine("Exception caught in buttonRevert_Click: {0}", oe.ToString());
			}
			catch (ArgumentNullException ane)	//Format & Convert
			{
				Console.WriteLine("Exception caught in buttonRevert_Click: {0}", ane.ToString());
			}
			catch (FormatException fe)		//Format & Convert
			{
				Console.WriteLine("Exception caught in buttonRevert_Click: {0}", fe.ToString());
			}
			catch (NullReferenceException nre)	//listBoxHistory.SelectedItem
			{
				Console.WriteLine("Exception caught in buttonRevert_Click: {0}", nre.ToString());
			}
		}
	}
}
