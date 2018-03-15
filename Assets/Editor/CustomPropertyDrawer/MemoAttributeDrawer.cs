using UnityEngine;
using UnityEditor;
using System.Linq;

namespace Yosh.Editor
{
	[CustomPropertyDrawer(typeof(MemoAttribute))]
	public sealed class MemoAttributeDrawer : PropertyDrawer
	{
		/// <summary>
		/// 一文字の幅
		/// </summary>
		readonly int CHAR_WIDTH = 8;
		/// <summary>
		/// 一文字の高さ
		/// </summary>
		readonly int CHAR_HEIGHT = 12;
		/// <summary>
		/// メモ表示領域パディング幅
		/// </summary>
		readonly int PADDING_WIDTH = 18;
		/// <summary>
		/// 折り返しが行われる文字数
		/// </summary>
		private int OneLineMaxCharacter { get { return (int) (EditorGUIUtility.currentViewWidth - PADDING_WIDTH) / CHAR_WIDTH; } }


		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			var inst = attribute as MemoAttribute;
			var pos = position;

			label = EditorGUI.BeginProperty(position, label, property);
			DrawTitle(new Rect(pos.x,pos.y,pos.width, EditorGUIUtility.singleLineHeight), "- Memo -");
			// プロパティ表示分の領域を空ける
			pos.y += EditorGUIUtility.singleLineHeight;
			pos.height -= base.GetPropertyHeight(property, label) + EditorGUIUtility.singleLineHeight;
			EditorGUI.LabelField(pos, new GUIContent(inst.Memo), EditorStyles.helpBox);
			// メモ表示領域分位置をずらす
			pos.y += position.height - base.GetPropertyHeight(property, label) - EditorGUIUtility.singleLineHeight;
			pos.height = EditorGUIUtility.singleLineHeight;
			EditorGUI.PropertyField(pos, property);
			EditorGUI.EndProperty();
		}

		public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
		{
			var inst = attribute as MemoAttribute;
			return base.GetPropertyHeight(property, label) + GetTextHeight(inst.Memo) + EditorGUIUtility.singleLineHeight+2;
		}

		/// <summary>
		/// メモに入力された文字列の高さを取得する
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		private float GetTextHeight(string str)
		{
			var lines = str.Split(new[] { "\n" }, System.StringSplitOptions.None);
			int indentCount = lines.Select(s => s.Length / OneLineMaxCharacter).Sum();
			indentCount += lines.Length;
			indentCount = Mathf.Max(1, indentCount);
			float height = CHAR_HEIGHT * indentCount;
			return height;
		}

		private void DrawTitle(Rect position, string label)
		{
			var style = new GUIStyle(EditorStyles.label);
			style.fontSize = CHAR_HEIGHT;

			EditorGUI.LabelField(position, label, style);
			Rect shadowPos = new Rect(position.x + 1, position.y + 1, position.width + 1, position.height + 1);
			EditorGUI.LabelField(shadowPos, label, style);
		}

	}
}