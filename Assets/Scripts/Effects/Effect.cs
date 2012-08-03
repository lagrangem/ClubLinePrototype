/// <summary>
/// Effect.
/// 
/// Written By Michael LaGrange
/// June 15, 2012
/// 
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Effect  {
	
	public enum Trigger
	{
		Played,
		OnCollection,
		Position,
		OverTime,
		ScoreBonus,
	};
	
	public Trigger TriggerType
	{
		get{return _trigger;}
		set{_trigger = value;}
	}
	private Trigger _trigger;
	
	public List<Task> TaskList
	{
		get {return _taskList;}
		set {_taskList = value;}
	}
	private List<Task> _taskList;
	
	public virtual void ApplyEffect() 
	{
		for(int i = 0; i < _taskList.Count; i++)
			_taskList[0].DoTask();
	}
	
	public Effect(Trigger type)
	{
		_trigger = type;
	}
	
}
