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
	private TriggerType _trigger;
	
	public List<Task> TaskList
	{
		get {return _taskList;}
		set {_taskList = value;}
	}
	private List<Task> _taskList;
	
	virtual void ApplyEffect() {}
	
	public Effect(List<Task> tasks)
	{
		_taskList = tasks;
	}
	public Effect(params Task[] tasks)
	{
		_taskList = new List<Task>(tasks);	
	}
	
}
