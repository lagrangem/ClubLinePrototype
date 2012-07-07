/// <summary>
/// SwapCharacterTask.
/// Written By Michael LaGrange
/// June 15, 2012
/// 
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CharacterTask : Task {

	public Character CharacterTarget
	{
		get{return _characterTarget;}
		set{_characterTarget = value;}
		
	}
	private Character _characterTarget;
	
	
	public CharacterTask(Character target) : base(Task.TargetType.CharacterQueue)
	{
		_characterTarget = target;	
	}
	
	public override bool DoTask ()
	{
		return true;
	}
}
