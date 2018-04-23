Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Container
Imports DevExpress.XtraGrid

Namespace DefaultEditor
	Public Class UserGridControl
		Inherits GridControl
		Protected Overrides Function CreateHelper() As EditorContainerHelper
			Return New UserGridEditorContainerHelper(Me)
		End Function
	End Class
	Public Class UserGridEditorContainerHelper
		Inherits GridEditorContainerHelper
		Public Sub New(ByVal owner As GridControl)
			MyBase.New(owner)
		End Sub

		Protected Overrides Function CreateDefaultEditorsRepository() As DefaultEditorsRepository
			Return New UserEditorsRepository()
		End Function
	End Class
End Namespace

