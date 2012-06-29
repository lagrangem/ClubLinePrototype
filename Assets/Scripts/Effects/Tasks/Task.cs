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
	
	public CharacterQueue TargetQueue
	{
		get{return _targetQueue;}
		set{_targetQueue = value;}
	}
	private CharacterQueue _targetQueue;
	
	public Player TargetPlayer
	{
		get {return _targetPlayer;}
		set {_targetPlayer = value;}
	}
	private Player _targetPlayer;
	
	
	public TargetType Type
	{
		get {return _type;}
		set { _type = value;}
	}
	private TargetType _type;

	public virtual bool DoTask()
	{
		return true;
	}
		
}
