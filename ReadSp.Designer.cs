namespace ReadStoredProceduers
{
	partial class ReadSp
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadSp));
			txt_ConnectionString = new TextBox();
			label1 = new Label();
			btn_TestConnectionString = new Button();
			label2 = new Label();
			txt_DetailedSP = new TextBox();
			btn_GetSPText = new Button();
			btn_CopyText = new Button();
			btn_Clear = new Button();
			lbl_message = new Label();
			btn_EditConnection = new Button();
			comboBox1 = new ComboBox();
			ToolTip1 = new ToolTip(components);
			btn_CopyText_ToolTip = new ToolTip(components);
			SuspendLayout();
			// 
			// txt_ConnectionString
			// 
			txt_ConnectionString.Location = new Point(135, 28);
			txt_ConnectionString.Margin = new Padding(3, 4, 3, 4);
			txt_ConnectionString.Multiline = true;
			txt_ConnectionString.Name = "txt_ConnectionString";
			txt_ConnectionString.PlaceholderText = "Enter connection string.";
			txt_ConnectionString.Size = new Size(625, 64);
			txt_ConnectionString.TabIndex = 0;
			txt_ConnectionString.WordWrap = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(9, 32);
			label1.Name = "label1";
			label1.Size = new Size(125, 20);
			label1.TabIndex = 1;
			label1.Text = "Connection string";
			// 
			// btn_TestConnectionString
			// 
			btn_TestConnectionString.Location = new Point(763, 27);
			btn_TestConnectionString.Margin = new Padding(3, 4, 3, 4);
			btn_TestConnectionString.Name = "btn_TestConnectionString";
			btn_TestConnectionString.Size = new Size(135, 31);
			btn_TestConnectionString.TabIndex = 2;
			btn_TestConnectionString.Text = "Connect";
			btn_TestConnectionString.UseVisualStyleBackColor = true;
			btn_TestConnectionString.Click += btn_TestConnectionString_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(9, 104);
			label2.Name = "label2";
			label2.Size = new Size(124, 20);
			label2.TabIndex = 1;
			label2.Text = "Stored Procedure";
			// 
			// txt_DetailedSP
			// 
			txt_DetailedSP.BackColor = SystemColors.AppWorkspace;
			txt_DetailedSP.Enabled = false;
			txt_DetailedSP.Location = new Point(12, 203);
			txt_DetailedSP.Margin = new Padding(3, 4, 3, 4);
			txt_DetailedSP.Multiline = true;
			txt_DetailedSP.Name = "txt_DetailedSP";
			txt_DetailedSP.ReadOnly = true;
			txt_DetailedSP.ScrollBars = ScrollBars.Vertical;
			txt_DetailedSP.Size = new Size(886, 553);
			txt_DetailedSP.TabIndex = 4;
			// 
			// btn_GetSPText
			// 
			btn_GetSPText.Location = new Point(763, 100);
			btn_GetSPText.Margin = new Padding(3, 4, 3, 4);
			btn_GetSPText.Name = "btn_GetSPText";
			btn_GetSPText.Size = new Size(133, 31);
			btn_GetSPText.TabIndex = 2;
			btn_GetSPText.Text = "Get";
			btn_GetSPText.UseVisualStyleBackColor = true;
			btn_GetSPText.Click += btn_GetSPText_Click;
			// 
			// btn_CopyText
			// 
			btn_CopyText.Cursor = Cursors.Hand;
			btn_CopyText.Enabled = false;
			btn_CopyText.FlatAppearance.BorderSize = 0;
			btn_CopyText.FlatAppearance.MouseOverBackColor = SystemColors.GradientInactiveCaption;
			btn_CopyText.FlatStyle = FlatStyle.Flat;
			btn_CopyText.Image = (Image)resources.GetObject("btn_CopyText.Image");
			btn_CopyText.Location = new Point(826, 170);
			btn_CopyText.Margin = new Padding(3, 4, 3, 4);
			btn_CopyText.Name = "btn_CopyText";
			btn_CopyText.Size = new Size(33, 29);
			btn_CopyText.TabIndex = 2;
			btn_CopyText_ToolTip.SetToolTip(btn_CopyText, "Copy");
			btn_CopyText.UseVisualStyleBackColor = false;
			btn_CopyText.Click += btn_CopyText_Click;
			// 
			// btn_Clear
			// 
			btn_Clear.AutoSize = true;
			btn_Clear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btn_Clear.BackColor = Color.Transparent;
			btn_Clear.Cursor = Cursors.Hand;
			btn_Clear.FlatAppearance.BorderColor = SystemColors.Control;
			btn_Clear.FlatAppearance.BorderSize = 0;
			btn_Clear.FlatAppearance.MouseDownBackColor = Color.Transparent;
			btn_Clear.FlatAppearance.MouseOverBackColor = SystemColors.GradientInactiveCaption;
			btn_Clear.FlatStyle = FlatStyle.Flat;
			btn_Clear.Image = Properties.Resources.Reset_image;
			btn_Clear.Location = new Point(865, 170);
			btn_Clear.Margin = new Padding(3, 4, 3, 4);
			btn_Clear.Name = "btn_Clear";
			btn_Clear.RightToLeft = RightToLeft.No;
			btn_Clear.Size = new Size(31, 26);
			btn_Clear.TabIndex = 2;
			ToolTip1.SetToolTip(btn_Clear, "Reset the search text and result area.");
			btn_Clear.UseVisualStyleBackColor = false;
			btn_Clear.Click += btn_Clear_Click;
			// 
			// lbl_message
			// 
			lbl_message.AutoSize = true;
			lbl_message.FlatStyle = FlatStyle.Popup;
			lbl_message.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lbl_message.ForeColor = Color.SeaGreen;
			lbl_message.Location = new Point(135, 144);
			lbl_message.Name = "lbl_message";
			lbl_message.Size = new Size(51, 20);
			lbl_message.TabIndex = 5;
			lbl_message.Text = "label3";
			lbl_message.Visible = false;
			// 
			// btn_EditConnection
			// 
			btn_EditConnection.Location = new Point(763, 63);
			btn_EditConnection.Margin = new Padding(3, 4, 3, 4);
			btn_EditConnection.Name = "btn_EditConnection";
			btn_EditConnection.Size = new Size(135, 31);
			btn_EditConnection.TabIndex = 2;
			btn_EditConnection.Text = "Edit Connection";
			btn_EditConnection.UseVisualStyleBackColor = true;
			btn_EditConnection.Click += btn_EditConnectionString_Click;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(135, 101);
			comboBox1.MaxDropDownItems = 10;
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(625, 28);
			comboBox1.TabIndex = 7;
			comboBox1.KeyUp += comboBox1_KeyUp;
			// 
			// ReadSp
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientActiveCaption;
			ClientSize = new Size(909, 769);
			Controls.Add(comboBox1);
			Controls.Add(lbl_message);
			Controls.Add(txt_DetailedSP);
			Controls.Add(btn_Clear);
			Controls.Add(btn_CopyText);
			Controls.Add(btn_GetSPText);
			Controls.Add(btn_EditConnection);
			Controls.Add(btn_TestConnectionString);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txt_ConnectionString);
			Margin = new Padding(3, 4, 3, 4);
			MaximizeBox = false;
			Name = "ReadSp";
			Text = "Read SPs";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txt_ConnectionString;
		private Label label1;
		private Button btn_TestConnectionString;
		private Label label2;
		private TextBox txt_DetailedSP;
		private Button btn_GetSPText;
		private Button btn_CopyText;
		private Button btn_Clear;
		private Label lbl_message;
		private Button btn_EditConnection;
		private ComboBox comboBox1;
		private ToolTip ToolTip1;
		private ToolTip btn_CopyText_ToolTip;

	}
}