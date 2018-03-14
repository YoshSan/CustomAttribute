using UnityEngine;
using UnityEditor;

namespace Yosh.Editor
{
	[CustomPropertyDrawer(typeof(SeparatorAttribute))]
	public sealed class SeparatorAttributeDrawer : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			var inst = attribute as SeparatorAttribute;
			var rect = position;
			rect.y += inst.Height / 2;
			rect.height = 1;
			rect.width += 5;

			EditorGUI.indentLevel--;
			EditorGUI.LabelField(rect, "", GUI.skin.box);
		}

		public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
		{
			var inst = attribute as SeparatorAttribute;
			return /*base.GetPropertyHeight(property, label)*/ + inst.Height;
		}
	}
}