namespace ConfigApp
{
	partial class SelectDatabaseDialog
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
			this.components = new System.ComponentModel.Container();
			this.tDatabases = new System.Windows.Forms.TabControl();
			this.tLocalDatabases = new System.Windows.Forms.TabPage();
			this.dgvLocalDatabases = new System.Windows.Forms.DataGridView();
			this.instanceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.databaseInstanceInfoEntityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.tNetworkDatabases = new System.Windows.Forms.TabPage();
			this.dgvNetworkDatabases = new System.Windows.Forms.DataGridView();
			this.instanceNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.databaseInstanceInfoEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.tbSelectedInstance = new System.Windows.Forms.TextBox();
			this.tDatabases.SuspendLayout();
			this.tLocalDatabases.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLocalDatabases)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseInstanceInfoEntityBindingSource1)).BeginInit();
			this.tNetworkDatabases.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNetworkDatabases)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseInstanceInfoEntityBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tDatabases
			// 
			this.tDatabases.Controls.Add(this.tLocalDatabases);
			this.tDatabases.Controls.Add(this.tNetworkDatabases);
			this.tDatabases.Location = new System.Drawing.Point(13, 11);
			this.tDatabases.Name = "tDatabases";
			this.tDatabases.SelectedIndex = 0;
			this.tDatabases.Size = new System.Drawing.Size(301, 426);
			this.tDatabases.TabIndex = 0;
			// 
			// tLocalDatabases
			// 
			this.tLocalDatabases.Controls.Add(this.dgvLocalDatabases);
			this.tLocalDatabases.Location = new System.Drawing.Point(4, 22);
			this.tLocalDatabases.Name = "tLocalDatabases";
			this.tLocalDatabases.Padding = new System.Windows.Forms.Padding(3);
			this.tLocalDatabases.Size = new System.Drawing.Size(293, 400);
			this.tLocalDatabases.TabIndex = 0;
			this.tLocalDatabases.Text = "Local";
			this.tLocalDatabases.UseVisualStyleBackColor = true;
			// 
			// dgvLocalDatabases
			// 
			this.dgvLocalDatabases.AllowUserToAddRows = false;
			this.dgvLocalDatabases.AllowUserToDeleteRows = false;
			this.dgvLocalDatabases.AutoGenerateColumns = false;
			this.dgvLocalDatabases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLocalDatabases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instanceNameDataGridViewTextBoxColumn});
			this.dgvLocalDatabases.DataSource = this.databaseInstanceInfoEntityBindingSource1;
			this.dgvLocalDatabases.Location = new System.Drawing.Point(7, 7);
			this.dgvLocalDatabases.Name = "dgvLocalDatabases";
			this.dgvLocalDatabases.ReadOnly = true;
			this.dgvLocalDatabases.Size = new System.Drawing.Size(278, 385);
			this.dgvLocalDatabases.TabIndex = 0;
			this.dgvLocalDatabases.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocalDatabases_CellContentDoubleClick);
			this.dgvLocalDatabases.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocalDatabases_RowEnter);
			// 
			// instanceNameDataGridViewTextBoxColumn
			// 
			this.instanceNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.instanceNameDataGridViewTextBoxColumn.DataPropertyName = "InstanceName";
			this.instanceNameDataGridViewTextBoxColumn.HeaderText = "InstanceName";
			this.instanceNameDataGridViewTextBoxColumn.Name = "instanceNameDataGridViewTextBoxColumn";
			this.instanceNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.instanceNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// databaseInstanceInfoEntityBindingSource1
			// 
			this.databaseInstanceInfoEntityBindingSource1.DataSource = typeof(ConfigApp.DatabaseInstanceInfoEntity);
			// 
			// tNetworkDatabases
			// 
			this.tNetworkDatabases.Controls.Add(this.dgvNetworkDatabases);
			this.tNetworkDatabases.Location = new System.Drawing.Point(4, 22);
			this.tNetworkDatabases.Name = "tNetworkDatabases";
			this.tNetworkDatabases.Padding = new System.Windows.Forms.Padding(3);
			this.tNetworkDatabases.Size = new System.Drawing.Size(293, 400);
			this.tNetworkDatabases.TabIndex = 1;
			this.tNetworkDatabases.Text = "Network";
			this.tNetworkDatabases.UseVisualStyleBackColor = true;
			// 
			// dgvNetworkDatabases
			// 
			this.dgvNetworkDatabases.AllowUserToAddRows = false;
			this.dgvNetworkDatabases.AllowUserToDeleteRows = false;
			this.dgvNetworkDatabases.AutoGenerateColumns = false;
			this.dgvNetworkDatabases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNetworkDatabases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instanceNameDataGridViewTextBoxColumn1,
            this.ServerName});
			this.dgvNetworkDatabases.DataSource = this.databaseInstanceInfoEntityBindingSource;
			this.dgvNetworkDatabases.Location = new System.Drawing.Point(7, 7);
			this.dgvNetworkDatabases.Name = "dgvNetworkDatabases";
			this.dgvNetworkDatabases.ReadOnly = true;
			this.dgvNetworkDatabases.Size = new System.Drawing.Size(278, 385);
			this.dgvNetworkDatabases.TabIndex = 0;
			this.dgvNetworkDatabases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNetworkDatabases_CellContentClick);
			this.dgvNetworkDatabases.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNetworkDatabases_CellContentDoubleClick);
			this.dgvNetworkDatabases.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNetworkDatabases_RowEnter);
			// 
			// instanceNameDataGridViewTextBoxColumn1
			// 
			this.instanceNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.instanceNameDataGridViewTextBoxColumn1.DataPropertyName = "InstanceName";
			this.instanceNameDataGridViewTextBoxColumn1.HeaderText = "InstanceName";
			this.instanceNameDataGridViewTextBoxColumn1.Name = "instanceNameDataGridViewTextBoxColumn1";
			this.instanceNameDataGridViewTextBoxColumn1.ReadOnly = true;
			this.instanceNameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// ServerName
			// 
			this.ServerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ServerName.DataPropertyName = "ServerName";
			this.ServerName.HeaderText = "ServerName";
			this.ServerName.Name = "ServerName";
			this.ServerName.ReadOnly = true;
			// 
			// databaseInstanceInfoEntityBindingSource
			// 
			this.databaseInstanceInfoEntityBindingSource.DataSource = typeof(ConfigApp.DatabaseInstanceInfoEntity);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(23, 474);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(107, 23);
			this.btnRefresh.TabIndex = 1;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnSubmit
			// 
			this.btnSubmit.BackColor = System.Drawing.SystemColors.Control;
			this.btnSubmit.Enabled = false;
			this.btnSubmit.Location = new System.Drawing.Point(194, 474);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(107, 23);
			this.btnSubmit.TabIndex = 4;
			this.btnSubmit.Text = "Next";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// tbSelectedInstance
			// 
			this.tbSelectedInstance.Enabled = false;
			this.tbSelectedInstance.Location = new System.Drawing.Point(23, 444);
			this.tbSelectedInstance.Name = "tbSelectedInstance";
			this.tbSelectedInstance.Size = new System.Drawing.Size(278, 20);
			this.tbSelectedInstance.TabIndex = 5;
			this.tbSelectedInstance.TextChanged += new System.EventHandler(this.tbSelectedInstance_TextChanged);
			// 
			// SelectDatabaseDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(327, 515);
			this.Controls.Add(this.tbSelectedInstance);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.tDatabases);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "SelectDatabaseDialog";
			this.Text = "SelectDatabaseDialog";
			this.tDatabases.ResumeLayout(false);
			this.tLocalDatabases.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvLocalDatabases)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseInstanceInfoEntityBindingSource1)).EndInit();
			this.tNetworkDatabases.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvNetworkDatabases)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.databaseInstanceInfoEntityBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tDatabases;
		private System.Windows.Forms.TabPage tLocalDatabases;
		private System.Windows.Forms.TabPage tNetworkDatabases;
		private System.Windows.Forms.DataGridView dgvLocalDatabases;
		private System.Windows.Forms.BindingSource databaseInstanceInfoEntityBindingSource;
		private System.Windows.Forms.DataGridView dgvNetworkDatabases;
		private System.Windows.Forms.BindingSource databaseInstanceInfoEntityBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn instanceNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.TextBox tbSelectedInstance;
		private System.Windows.Forms.DataGridViewTextBoxColumn instanceNameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServerName;
	}
}