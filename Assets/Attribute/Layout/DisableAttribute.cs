using UnityEngine;
using System;
using System.Reflection;

namespace Yosh
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public class DisableAttribute : PropertyAttribute
	{

		public DisableAttribute() { }
	}
}