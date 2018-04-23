Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DefaultEditor
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private gridControl1 As UserGridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Friend DataSet1 As System.Data.DataSet
		Friend DataTable1 As System.Data.DataTable
		Friend DataColumn1 As System.Data.DataColumn
		Friend DataColumn2 As System.Data.DataColumn
		Private colLastAccessTime As DevExpress.XtraGrid.Columns.GridColumn
		Private colEncrypted As DevExpress.XtraGrid.Columns.GridColumn
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DefaultEditor.UserGridControl()
			Me.DataTable1 = New System.Data.DataTable()
			Me.DataColumn1 = New System.Data.DataColumn()
			Me.DataColumn2 = New System.Data.DataColumn()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colLastAccessTime = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colEncrypted = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.DataSet1 = New System.Data.DataSet()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.DataTable1
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			' 
			' gridControl1.EmbeddedNavigator
			' 
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(416, 270)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' DataTable1
			' 
			Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.DataColumn1, Me.DataColumn2})
			Me.DataTable1.TableName = "Table1"
			' 
			' DataColumn1
			' 
			Me.DataColumn1.ColumnName = "LastAccessTime"
			Me.DataColumn1.DataType = GetType(System.DateTime)
			' 
			' DataColumn2
			' 
			Me.DataColumn2.ColumnName = "Encrypted"
			Me.DataColumn2.DataType = GetType(Boolean)
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colLastAccessTime, Me.colEncrypted})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colLastAccessTime
			' 
			Me.colLastAccessTime.Caption = "LastAccessTime"
			Me.colLastAccessTime.FieldName = "LastAccessTime"
			Me.colLastAccessTime.Name = "colLastAccessTime"
			Me.colLastAccessTime.Visible = True
			Me.colLastAccessTime.VisibleIndex = 0
			' 
			' colEncrypted
			' 
			Me.colEncrypted.Caption = "Encrypted"
			Me.colEncrypted.FieldName = "Encrypted"
			Me.colEncrypted.Name = "colEncrypted"
			Me.colEncrypted.Visible = True
			Me.colEncrypted.VisibleIndex = 1
			' 
			' DataSet1
			' 
			Me.DataSet1.DataSetName = "NewDataSet"
			Me.DataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.DataSet1.Tables.AddRange(New System.Data.DataTable() { Me.DataTable1})
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(416, 270)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			DataTable1.Rows.Add(New Object() {DateTime.Now, True})
			DataTable1.Rows.Add(New Object() {DateTime.Today.AddDays(-1), False})
		End Sub
	End Class
End Namespace
