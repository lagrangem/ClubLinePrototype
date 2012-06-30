/// <summary>
/// Task manager.
/// 
/// Written By Michael LaGrange
/// June 15th, 2012
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//Representing the human player
public class Player {
	//Taskmanager for applying things to a player
	private TaskManager _taskMgr;
	
	
	
	//player's current score
	//should be updated by CalculateScore
	public int Score
	{
		get{ return _score;}
	}
	private int _score;
	
	//The players collection of characters (ie score pile)
	public List<Character> Collection
	{
		get{ return _collection;}
	}
	private List<Character> _collection;
	
	// List of effects currently on player
	// Effects for calculating score, and perhaps limiting actions.
	public List<Effect> PlayerEffectCollection
	{
		get {return _playerEffectCollection;}
	}
	private List<Effect> _playerEffectCollection;
	
	
	public List<Action> PlayerActionList
	{
		get{return _playerActionList;}
		set{_playerActionList = value;}
	}
	private List<Action> _playerActionList;

	public List<Action> UsedActionList
	{
		get{return _usedActionList;}
		set{_usedActionList = value;}
	}
	private List<Action> _usedActionList;		
	
	public Player()
	{
		_score = 0;
		_collection = new List<Character>();
		_playerEffectCollection = new List<Effect>();
		_playerActionList = new List<Action>();
		_usedActionList = new List<Action>();
		
		
	}
	
	
	//main update loop of the player class
	public virtual void Update()
	{
		
	}
	
	// incase player gets subclassed, score would probably be one to be overridden
	public virtual int CalculateScore()
	{
		int returnScore = 0;
		
		foreach(Character character in _collection)
			returnScore += character.Value;
		
		foreach(Character character in _collection)
		{
			List<Effect> effectList = character.GetEffectsByTrigger(Effect.Trigger.ScoreBonus);

//			foreach (Effect bonus in effectList)
//			{
//				//returnScore += bonus.GetBonusScore(_collection);
//			}
		
		}
		
//		foreach(Effect effect in _playerEffectCollection)
//		{
//		//do work from effects	
//		}
		return 0;
	}
	
	
}
