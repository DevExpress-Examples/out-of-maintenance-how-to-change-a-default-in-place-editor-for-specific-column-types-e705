using System;
using System.Collections.Generic;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace DefaultEditor {
	public class UserEditorsRepository : DefaultEditorsRepository {
        Dictionary<EditorType, RepositoryItem> EditorsCache = new Dictionary<EditorType, RepositoryItem>();

		public override RepositoryItem GetRepositoryItem(Type type) {
            if (type.Equals(typeof(DateTime)))
                return GetRepositoryItem(EditorType.DateTime);
            else if (type.Equals(typeof(bool)))
                return GetRepositoryItem(EditorType.Boolean);
            else return base.GetRepositoryItem(type);
		}

        RepositoryItem GetRepositoryItem(EditorType editorType) {
            if (EditorsCache.ContainsKey(editorType)) 
                return EditorsCache[editorType];
            RepositoryItem result = CreateRepositoryItem(editorType);
            EditorsCache.Add(editorType, result);
            return result;
        }

        RepositoryItem CreateRepositoryItem(EditorType editorType) {
            switch (editorType) {
                case EditorType.DateTime: return new RepositoryItemTextEdit();
                case EditorType.Boolean:
                    RepositoryItemRadioGroup result = new RepositoryItemRadioGroup();
                    result.Columns = 2;
                    result.Items.Add(new RadioGroupItem(true, "Yes"));
                    result.Items.Add(new RadioGroupItem(false, "No"));
                    return result;
                default: return new RepositoryItemTextEdit();
            }
        }

        enum EditorType { DateTime, Boolean }
	}
}

