namespace ConfigApp
{
	partial class ConnectToDatabaseDialog
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
			this.tbOperationLog = new System.Windows.Forms.TextBox();
			this.btnFinish = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnRetry = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbOperationLog
			// 
			this.tbOperationLog.Location = new System.Drawing.Point(13, 13);
			this.tbOperationLog.Multiline = true;
			this.tbOperationLog.Name = "tbOperationLog";
			this.tbOperationLog.ReadOnly = true;
			this.tbOperationLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbOperationLog.Size = new System.Drawing.Size(490, 208);
			this.tbOperationLog.TabIndex = 0;
			this.tbOperationLog.WordWrap = false;
			// 
			// btnFinish
			// 
			this.btnFinish.Enabled = false;
			this.btnFinish.Location = new System.Drawing.Point(382, 227);
			this.btnFinish.Name = "btnFinish";
			this.btnFinish.Size = new System.Drawing.Size(100, 23);
			this.btnFinish.TabIndex = 3;
			this.btnFinish.Text = "Finish";
			this.btnFinish.UseVisualStyleBackColor = true;
			this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
			// 
			// btnBack
			// 
			this.btnBack.Enabled = false;
			this.btnBack.Location = new System.Drawing.Point(30, 227);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(100, 23);
			this.btnBack.TabIndex = 1;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnRetry
			// 
			this.btnRetry.Enabled = false;
			this.btnRetry.Location = new System.Drawing.Point(206, 227);
			this.btnRetry.Name = "btnRetry";
			this.btnRetry.Size = new System.Drawing.Size(100, 23);
			this.btnRetry.TabIndex = 2;
			this.btnRetry.Text = "Retry";
			this.btnRetry.UseVisualStyleBackColor = true;
			this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
			// 
			// ConnectToDatabaseDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 262);
			this.Controls.Add(this.btnRetry);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnFinish);
			this.Controls.Add(this.tbOperationLog);
			this.Name = "ConnectToDatabaseDialog";
			this.Text = "Connecting";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbOperationLog;
		private System.Windows.Forms.Button btnFinish;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnRetry;
	}
}