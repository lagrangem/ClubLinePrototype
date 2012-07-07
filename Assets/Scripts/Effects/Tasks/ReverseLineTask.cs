/// <summary>
/// ReverseLine Task.
/// Written By Michael LaGrange
/// June 15, 2012
/// 
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ReverseLineTask : QueueTask {

	
	public ReverseLineTask(CharacterQueue queue) : base (queue)
	{
		
	}
	
	public override bool DoTask ()
	{
		QTarget.ReverseLineOrder();
		TaskHasRun = true;		
		return true;
	}
	
}
