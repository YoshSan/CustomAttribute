using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yosh;

[System.Serializable]
public class A
{
	public int a;
	public string b;
}

public class Sample : MonoBehaviour
{	
	[Separator(15)] public string separator;
	[TitleLabel("ColorTest",15)] public string label;
	[Color(0xff0000)] public int _int;
	[Color(0f,1f,0f)] public float _float;
	[Color(0,0,255)] public string _string;
	[Separator] public string separator2;
	[TitleLabel("Disable",15,0x4444FF)] public string label2;
	[Disable] [SerializeField] string DisableTest = "HELLO WORLD";

	[Indent(5)] public int indent5;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
}
