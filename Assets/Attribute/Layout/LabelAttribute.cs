using UnityEngine;
using System;
using System.Reflection;

namespace Yosh
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public class LabelAttribute : PropertyAttribute
	{
		public string Label { get; private set; }

		public bool IsDropShadow { get; private set; }

		public LabelAttribute(string label, bool isDropShadow = false)
		{
			Label = label;
			IsDropShadow = isDropShadow;
		}
	}
}