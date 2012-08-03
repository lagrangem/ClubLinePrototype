/// <summary>
/// QueueTask.
/// Written By Michael LaGrange
/// June 15, 2012
/// 
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class QueueTask : Task {

	public CharacterQueue QTarget
	{
		get{return _qTarget;}
		set{_qTarget = value;}
	}
	private CharacterQueue _qTarget;
	
	public QueueTask() : base(Task.TargetType.CharacterQueue)
	{
		_qTarget = new CharacterQueue();	
	}
	public QueueTask(CharacterQueue queue) : base(Task.TargetType.CharacterQueue)
	{
		_qTarget = queue;
	}
	
	public override bool DoTask()
	{
		return true;
	}

}
