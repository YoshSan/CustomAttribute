using UnityEngine;
using UnityEditor;

namespace Yosh.Editor
{
	[CustomPropertyDrawer(typeof(IndentAttribute))]
	public sealed class IndentAttributeDrawer : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			var inst = attribute as IndentAttribute;
			EditorGUI.indentLevel = 0;
			EditorGUI.indentLevel += inst.Level;
			EditorGUI.PropertyField(position, property);
			EditorGUI.indentLevel -= inst.Level;
		}	
	}
}