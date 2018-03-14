using UnityEngine;
using System;
using System.Reflection;

namespace Yosh
{
	/// <summary>
	/// インスペクターに表示するプロパティを編集不可にする
	/// </summary>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public class DisableAttribute : PropertyAttribute
	{
		public DisableAttribute() { }
	}
}