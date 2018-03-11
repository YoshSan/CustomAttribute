using UnityEngine;
using System;
using System.Reflection;

namespace Yosh
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public class SeparatorAttribute : PropertyAttribute
	{
		public float Height { get; private set; }

		public SeparatorAttribute(float height = 1)
		{
			Height = height;
		}
	}
}