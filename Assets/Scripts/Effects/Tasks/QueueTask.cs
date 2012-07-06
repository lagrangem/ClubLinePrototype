/// <summary>
/// Task.
/// Written By Michael LaGrange
/// June 15, 2012
/// 
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class QueueTask : Task {

	public CharacterQueue Target
	{
		get{return _target;}
		set{_target = value;}
	}
	private CharacterQueue _target;
	
	public QueueTask(CharacterQueue queue) : base(Task.TargetType.CharacterQueue)
	{
		
	}
	
	public override bool DoTask()
	{
		return true;
	}

}
