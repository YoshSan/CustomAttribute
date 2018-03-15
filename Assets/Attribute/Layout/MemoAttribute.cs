using UnityEngine;
using System;
using System.Reflection;

namespace Yosh
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public class MemoAttribute : PropertyAttribute
	{
		public string Memo { get; private set; }

		public MemoAttribute( string memo )
		{
			Memo = memo;
		}
	}
}