using UnityEngine;
using UnityEditor;

namespace Yosh.Editor
{
	[CustomPropertyDrawer(typeof(LabelAttribute))]
	public sealed class LabelAttributeDrawer : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			var inst = attribute as LabelAttribute;

			if(inst.IsDropShadow)
				EditorGUI.DropShadowLabel(position, inst.Label);
			else
				EditorGUI.LabelField(position, inst.Label);
		}	
	}
}