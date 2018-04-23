using System;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraGrid;

namespace DefaultEditor {
	public class UserGridControl : GridControl {
		protected override EditorContainerHelper CreateHelper() {
			return new UserGridEditorContainerHelper(this);
		}
	}
	public class UserGridEditorContainerHelper : GridEditorContainerHelper {
		public UserGridEditorContainerHelper(GridControl owner) : base(owner) { }

		protected override DefaultEditorsRepository CreateDefaultEditorsRepository() {
			return new UserEditorsRepository();
		}
	}
}

