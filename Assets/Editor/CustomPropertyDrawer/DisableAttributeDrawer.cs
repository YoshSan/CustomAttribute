using UnityEngine;
using UnityEditor;

namespace Yosh.Editor
{
	[CustomPropertyDrawer(typeof(DisableAttribute))]
	public sealed class DisableAttributeDrawer : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			var inst = attribute as DisableAttribute;

			using (new EditorGUI.DisabledGroupScope(true))
				EditorGUI.PropertyField(position, property);
		}	
	}
}