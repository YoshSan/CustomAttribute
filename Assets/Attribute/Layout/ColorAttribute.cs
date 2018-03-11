using UnityEngine;
using System;

namespace Yosh
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
	public class ColorAttribute : PropertyAttribute
	{
		public Color Color { get; private set; }

		public ColorAttribute(uint color)
		{
			Color = ColorUtils.GetRgbColor(color);
		}

		public ColorAttribute(float r, float g, float b, float a = 1)
		{
			Color = new Color(r, g, b);
		}

		public ColorAttribute(byte r, byte g, byte b, byte a = 255)
		{
			Color = new Color32(r, g, b, a);
		}
	}
	
	public static class ColorUtils
	{
		/// <summary>
		/// http://waken.hatenablog.com/entry/2016/07/21/132345
		/// </summary>
		/// <param name="color"></param>
		/// <returns></returns>
		public static Color GetRgbColor(uint color)
		{
			float r, g, b, a;
			var inv = 1.0f / 255.0f;
			if (color > 0xffffff) {
				r = ((color >> 24) & 0xff) * inv;
				g = ((color >> 16) & 0xff) * inv;
				b = ((color >> 8) & 0xff) * inv;
				a = ((color) & 0xff) * inv;
			}
			else {
				r = ((color >> 16) & 0xff) * inv;
				g = ((color >> 8) & 0xff) * inv;
				b = ((color) & 0xff) * inv;
				a = 1.0f;
			}
			return new Color(r, g, b, a);
		}
	}
}