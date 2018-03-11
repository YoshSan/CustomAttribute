﻿using UnityEngine;
using System;
using System.Reflection;

namespace Yosh
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public class IndentAttribute : PropertyAttribute
	{
		public int Level { get; private set; }
		
		public IndentAttribute(int level = 1)
		{
			Level = level;
		}
	}
}