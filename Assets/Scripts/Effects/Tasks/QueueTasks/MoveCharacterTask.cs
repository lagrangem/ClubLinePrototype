/// <summary>
/// MoveCharacterTask.
/// Written By Michael LaGrange
/// June 15, 2012
/// 
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MoveCharacterTask : QueueTask
{
	
	public int TargetPosition
	{
		get{return _targetPosition;}
		set{_targetPosition = value;}
	}
	private int _targetPosition = -1;
		
	public int TargetDestination
	{
		get{return _targetDestination;}
		set{_targetDestination = value;}
	}
	private int _targetDestination = -1;
	
	
	public MoveCharacterTask(int targetPosition, int destinationPosition, CharacterQueue queue) : base(queue)
	{
		_targetPosition = targetPosition;
		_targetDestination = destinationPosition;
	}
	
	
	public override bool DoTask ()
	{
		if(TargetPosition > QTarget.Length || TargetDestination > QTarget.Length)
		{
			Valid = false;
			return false;	
		}
		
		bool success = QTarget.MoveCharacter(TargetPosition, TargetDestination);
		
		TaskHasRun = true;
		return success;
	}

}
