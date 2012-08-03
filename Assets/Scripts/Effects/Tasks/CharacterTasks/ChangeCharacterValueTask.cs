/// <summary>
/// SwapCharacterTask.
/// Written By Michael LaGrange
/// June 15, 2012
/// 
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ChangeCharacterValueTask : CharacterTask {


	public int NewCharValue
	{
		get{ return _newCharValue;}
		set{_newCharValue = value;}
	}
	private int _newCharValue = 1;
	
	
	public ChangeCharacterValueTask(Character target, int newValue) : base(target)
	{
		_newCharValue = newValue;
	}
	
	public override bool DoTask ()
	{
		CharacterTarget.Value = NewCharValue;
		TaskHasRun = true;
		return true;
	}
	
	
}
