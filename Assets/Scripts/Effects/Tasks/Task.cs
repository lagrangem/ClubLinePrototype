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
		Character,
	};
	
	public bool Valid
	{
		get{return _valid;}
		set{_valid = value;}
	}
	private bool _valid = true;
	
	public bool TaskHasRun
	{
		get{return _complete;}
		set{_complete = value;}
	}
	private bool _complete = false;
	
	
	
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
