using UnityEngine;
using System;
using System.Reflection;

namespace Yosh
{
	/// <summary>
	/// インスペクター区切り線を表示する
	/// </summary>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
	public class SeparatorAttribute : PropertyAttribute
	{
		public float Height { get; private set; }
		
		public SeparatorAttribute(float height = 1)
		{
			Height = height;
		}
	}
}