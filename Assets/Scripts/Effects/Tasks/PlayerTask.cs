/// <summary>
/// PlayerTask.
/// Written By Michael LaGrange
/// June 15, 2012
/// 
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerTask : Task {

	public Player PlayerTarget
	{
		get{ return _pTarget; }
		set{ _pTarget = value; }
	}
	private Player _pTarget;
	
	
	public PlayerTask(Player target) : base(Task.TargetType.Player)
	{
		_pTarget = target;
	}
	
	public override bool DoTask ()
	{
		return true;
	}


}
