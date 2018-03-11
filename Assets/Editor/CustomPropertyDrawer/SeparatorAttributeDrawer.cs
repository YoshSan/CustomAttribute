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
			rect.y += 5;
			rect.height = inst.Height;
			rect.width -= 10;
			EditorGUI.LabelField(rect, "", GUI.skin.box);
		}
	}
}