namespace ReadStoredProceduers
{
	public partial class ReadSp : Form
	{
		private bool _conncetionSet = false;
		private System.Timers.Timer timer1;

		private List<string> spName = new();
		SQLOperation_Repo _sqlRespository { get; set; }
		public ReadSp()
		{
			InitializeComponent();
			Initialize();
		}

		private void btn_GetSPText_Click(object sender, EventArgs e)
		{
			btn_CopyText.Enabled = false;

			SetLoading(true);
			if (string.IsNullOrEmpty(txt_ConnectionString.Text) || !_conncetionSet)
			{
				SetErrorMessage("Please provide correct connection string.");
			}
			else if (string.IsNullOrEmpty(comboBox1.Text))
			{
				SetErrorMessage("Please provide SP name.");
			}
			else
			{
				try
				{
					string spDetail = _sqlRespository.GetStoredProcedureText(comboBox1.Text);

					txt_DetailedSP.Text = spDetail;
					btn_CopyText.Enabled = true;
					SetMessage("SP Fetched successfully.");
				}
				catch (Exception ex)
				{
					SetErrorMessage(ex.Message);
				}
			}
			SetLoading(false);
		}

		private void btn_CopyText_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(txt_DetailedSP.Text);
			SetMessage("Coppied.");
		}

		private void btn_Clear_Click(object sender, EventArgs e)
		{
			ResetControls();
		}
		
		private void btn_TestConnectionString_Click(object sender, EventArgs e)
		{
			SetLoading(true);
			if (SQLOperation_Repo.TestConnection(txt_ConnectionString.Text))
			{
				SetMessage("Connection Successed.");
				_conncetionSet = true;
				EnableActions(true);
				btn_EditConnection.Enabled = true;
				_sqlRespository = new SQLOperation_Repo(txt_ConnectionString.Text);
				spName = _sqlRespository.GetStoredProcedureNameList();
				comboBox1.DataSource = null;
				comboBox1.Items.Clear();
				comboBox1.DataSource = spName;
				comboBox1.SelectedIndex = -1;
			}
			else
			{
				SetErrorMessage("Please check connection string and try again.");
				_conncetionSet = false;
				EnableActions(false);
			}
			SetLoading(false);
		}

		private void btn_EditConnectionString_Click(object sender, EventArgs e)
		{
			lbl_message.Text = "";
			lbl_message.Visible = false;
			EnableActions(false);
			btn_EditConnection.Enabled = false;
		}

		private void comboBox1_KeyUp(object sender, KeyEventArgs e)
		{
			string filter_param = comboBox1.Text;

			List<string> filteredItems = spName.FindAll(x => x.ToLower().Contains(filter_param.ToLower()));
			// another variant for filtering using StartsWith:
			// List<string> filteredItems = arrProjectList.FindAll(x => x.StartsWith(filter_param));

			comboBox1.DataSource = filteredItems;

			if (String.IsNullOrWhiteSpace(filter_param))
			{
				comboBox1.DataSource = spName;
			}
			comboBox1.DroppedDown = true;

			// drop down height as per data size
			comboBox1.IntegralHeight = true;

			// remove automatically selected first item
			comboBox1.SelectedIndex = -1;

			comboBox1.Text = filter_param;

			// set the position of the cursor
			comboBox1.SelectionStart = filter_param.Length;
			comboBox1.SelectionLength = 0;

			comboBox1.DroppedDown = true;
			Cursor.Current = Cursors.Default;
		}

		#region Private

		private void Initialize()
		{
			txt_ConnectionString.Text = "Data Source=KRS-WORLD;Initial Catalog=Ecommerce; Integrated Security=True;";
			EnableActions(false);
			StartTimmer(ChangeOpacity, 1000000);
		}

		private void StartTimmer(Action<object, EventArgs> action, double interval = 10000)
		{
			if (timer1 != null)
			{
				ResetTimer();
			}
			timer1 = new System.Timers.Timer
			{
				Interval = interval,
				Enabled = true
			};

			timer1.Elapsed += (sender, e) => action(sender, e);
			timer1.Start();
		}

		private void ResetTimer()
		{
			timer1.Stop();
			timer1.Close();
			timer1.Dispose();
		}

		private void ResetControls()
		{
			txt_DetailedSP.Text = "";
			comboBox1.Text = "";
			comboBox1.SelectedIndex = -1;
			comboBox1.DataSource = spName;
			btn_CopyText.Enabled = false;
		}

		private void EnableActions(bool enable)
		{
			txt_ConnectionString.Enabled = enable ? false : true;
			btn_EditConnection.Enabled = txt_ConnectionString.Enabled ? false : true;
			comboBox1.Enabled = enable;
			txt_DetailedSP.Enabled = enable;
			btn_Clear.Enabled = enable;
			btn_GetSPText.Enabled = enable;
		}

		private void SetLoading(bool displayLoader)
		{
			if (displayLoader)
			{
				this.Invoke((MethodInvoker)delegate
				{
					this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
				});
			}
			else
			{
				this.Invoke((MethodInvoker)delegate
				{
					this.Cursor = System.Windows.Forms.Cursors.Default;
				});
			}
		}

		private void ChangeOpacity(object sender, EventArgs e)
		{
			this.Opacity += 0.00001;
			if (this.Opacity == 1)
				ResetTimer();
		}

		private void ClearMessage(object sender, EventArgs e)
		{
			lbl_message.BeginInvoke(delegate { lbl_message.Text = ""; });
			lbl_message.BeginInvoke(delegate { lbl_message.Visible = false; });
			ResetTimer();
		}

		private void SetMessage(string message)
		{
			lbl_message.Text = message;
			lbl_message.Visible = true;
			lbl_message.ForeColor = Color.Green;
			StartTimmer(ClearMessage, 3000);
		}

		private void SetErrorMessage(string message)
		{
			lbl_message.Text = message;
			lbl_message.Visible = true;
			lbl_message.ForeColor = Color.Red;
			StartTimmer(action: ClearMessage);
		}
		#endregion
	}
}
