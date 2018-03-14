using UnityEngine;
using System;
using System.Reflection;

namespace Yosh
{
	/// <summary>
	/// 見出し表示用Attribute
	/// </summary>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
	public class TitleLabelAttribute : PropertyAttribute
	{
		public string Label { get; private set; }

		public int FontSize { get; private set; }

		public uint Color { get; private set; }
		
		public TitleLabelAttribute( string label ,int fontSize = 133, uint color = 0x131313)
		{
			Label = label;
			FontSize = fontSize;
			Color = color;
		}
	}
}