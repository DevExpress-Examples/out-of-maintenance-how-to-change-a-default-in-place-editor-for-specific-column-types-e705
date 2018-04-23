Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository

Namespace DefaultEditor
	Public Class UserEditorsRepository
		Inherits DefaultEditorsRepository
		Private EditorsCache As New Dictionary(Of EditorType, RepositoryItem)()

		Public Overrides Function GetRepositoryItem(ByVal type As Type) As RepositoryItem
			If type.Equals(GetType(DateTime)) Then
				Return GetRepositoryItem(EditorType.DateTime)
			ElseIf type.Equals(GetType(Boolean)) Then
				Return GetRepositoryItem(EditorType.Boolean)
			Else
				Return MyBase.GetRepositoryItem(type)
			End If
		End Function

		Private Overloads Function GetRepositoryItem(ByVal editorType As EditorType) As RepositoryItem
			If EditorsCache.ContainsKey(editorType) Then
				Return EditorsCache(editorType)
			End If
			Dim result As RepositoryItem = CreateRepositoryItem(editorType)
			EditorsCache.Add(editorType, result)
			Return result
		End Function

		Private Function CreateRepositoryItem(ByVal editorType As EditorType) As RepositoryItem
			Select Case editorType
				Case EditorType.DateTime
					Return New RepositoryItemTextEdit()
				Case EditorType.Boolean
					Dim result As New RepositoryItemRadioGroup()
					result.Columns = 2
					result.Items.Add(New RadioGroupItem(True, "Yes"))
					result.Items.Add(New RadioGroupItem(False, "No"))
					Return result
				Case Else
					Return New RepositoryItemTextEdit()
			End Select
		End Function

		Private Enum EditorType
			DateTime
			[Boolean]
		End Enum
	End Class
End Namespace