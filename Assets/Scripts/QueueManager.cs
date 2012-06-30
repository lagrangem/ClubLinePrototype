/// <summary>
/// Queue manager.
/// 
/// Written By Michael LaGrange
/// June 15, 2012
/// 
/// </summary>
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class QueueManager {
	
	public CharacterQueue MainLine
	{
		get {return _mainLine;}
//		set {_mainLine = value;}
	}
	private CharacterQueue _mainLine;
	
	public TaskManager QueueTaskMgr
	{
		get{return _queueTaskMgr;}
	}
	private TaskManager _queueTaskMgr;
	
	
	public QueueManager(params Character[] chars)
	{
		Queue<Character> returnQ = new Queue<Character>();
		foreach (Character character in chars)
			returnQ.Enqueue(character);
		init (returnQ);
	}
	
	public QueueManager(Queue<Character> charQ)
	{
		init(charQ);
	}
	
	public void init(Queue<Character> charQ)
	{
		_queueTaskMgr = new TaskManager();
		_mainLine = new CharacterQueue(charQ);		
	}
	
	public void Update()
	{
		_mainLine.Update();
	}
}
