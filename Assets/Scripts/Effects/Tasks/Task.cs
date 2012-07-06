/// <summary>
/// Task.
/// Written By Michael LaGrange
/// June 15, 2012
/// 
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Task {
	
	public enum TargetType
	{
		Player,
		Bouncer,
		PlayerScore,
		BouncerScore,
		PlayerCollection,
		BouncerCollection,
		CharacterQueue,
	};
	
	
	public TargetType Type
	{
		get {return _type;}
		set { _type = value;}
	}
	private TargetType _type;
	
	public Task(TargetType type)
	{
		_type = type;
	}
	
	public virtual bool DoTask()
	{
		return true;
	}
		
}
