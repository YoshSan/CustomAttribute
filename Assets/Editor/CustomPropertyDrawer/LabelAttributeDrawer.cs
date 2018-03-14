using UnityEngine;
using UnityEditor;

namespace Yosh.Editor
{
	[CustomPropertyDrawer(typeof(TitleLabelAttribute))]
	public sealed class TitleLabelAttributeDrawer : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			var inst = attribute as TitleLabelAttribute;
			var style = new GUIStyle(EditorStyles.label);
			style.fontSize = inst.FontSize;
			style.normal.textColor = ColorUtils.GetRgbColor(inst.Color);

			EditorGUI.LabelField( position, inst.Label, style );
			Rect shadowPos = new Rect(position.x+1,position.y+1,position.width+1,position.height+1);
			EditorGUI.LabelField( shadowPos, inst.Label, style );
		}

		public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
		{
			var inst = attribute as TitleLabelAttribute;

			return base.GetPropertyHeight(property, label) + (inst.FontSize - 11);
		}
	}
}