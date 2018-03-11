using UnityEngine;
using UnityEditor;

namespace Yosh.Editor
{
	[CustomPropertyDrawer(typeof(ColorAttribute))]
	public sealed class ColorAttributeDrawer : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			var inst = attribute as ColorAttribute;

			using (new ColorGroup(inst.Color)) {
				EditorGUI.PropertyField(position, property);
			}
		}	
	}
}