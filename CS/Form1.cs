using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DefaultEditor
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private UserGridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		internal System.Data.DataSet DataSet1;
		internal System.Data.DataTable DataTable1;
		internal System.Data.DataColumn DataColumn1;
		internal System.Data.DataColumn DataColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn colLastAccessTime;
		private DevExpress.XtraGrid.Columns.GridColumn colEncrypted;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.gridControl1 = new DefaultEditor.UserGridControl();
			this.DataTable1 = new System.Data.DataTable();
			this.DataColumn1 = new System.Data.DataColumn();
			this.DataColumn2 = new System.Data.DataColumn();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colLastAccessTime = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEncrypted = new DevExpress.XtraGrid.Columns.GridColumn();
			this.DataSet1 = new System.Data.DataSet();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataTable1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.DataTable1;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// gridControl1.EmbeddedNavigator
			// 
			this.gridControl1.EmbeddedNavigator.Name = "";
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(416, 270);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
																										this.gridView1});
			// 
			// DataTable1
			// 
			this.DataTable1.Columns.AddRange(new System.Data.DataColumn[] {
																			  this.DataColumn1,
																			  this.DataColumn2});
			this.DataTable1.TableName = "Table1";
			// 
			// DataColumn1
			// 
			this.DataColumn1.ColumnName = "LastAccessTime";
			this.DataColumn1.DataType = typeof(System.DateTime);
			// 
			// DataColumn2
			// 
			this.DataColumn2.ColumnName = "Encrypted";
			this.DataColumn2.DataType = typeof(bool);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
																							 this.colLastAccessTime,
																							 this.colEncrypted});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// colLastAccessTime
			// 
			this.colLastAccessTime.Caption = "LastAccessTime";
			this.colLastAccessTime.FieldName = "LastAccessTime";
			this.colLastAccessTime.Name = "colLastAccessTime";
			this.colLastAccessTime.Visible = true;
			this.colLastAccessTime.VisibleIndex = 0;
			// 
			// colEncrypted
			// 
			this.colEncrypted.Caption = "Encrypted";
			this.colEncrypted.FieldName = "Encrypted";
			this.colEncrypted.Name = "colEncrypted";
			this.colEncrypted.Visible = true;
			this.colEncrypted.VisibleIndex = 1;
			// 
			// DataSet1
			// 
			this.DataSet1.DataSetName = "NewDataSet";
			this.DataSet1.Locale = new System.Globalization.CultureInfo("en-US");
			this.DataSet1.Tables.AddRange(new System.Data.DataTable[] {
																		  this.DataTable1});
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(416, 270);
			this.Controls.Add(this.gridControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataTable1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e) {
			DataTable1.Rows.Add(new object[] {DateTime.Now, true});
			DataTable1.Rows.Add(new object[] {DateTime.Today.AddDays(-1), false});
		}
	}
}
